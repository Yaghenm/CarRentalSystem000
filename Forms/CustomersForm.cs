// ============================================================
// CustomersForm.cs — إدارة العملاء (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class CustomersForm : Form
    {
        private int selectedCustomerID = -1;

        public CustomersForm() { InitializeComponent(); }

        private void CustomersForm_Load(object sender, EventArgs e) { LoadCustomersGrid(); }

        private void LoadCustomersGrid()
        {
            if (dgvCustomers.Columns.Count == 0)
            {
                dgvCustomers.Columns.Add("CustomerID", "رقم العميل");
                dgvCustomers.Columns.Add("Name", "الاسم");
                dgvCustomers.Columns.Add("Phone", "رقم الهاتف");
                dgvCustomers.Columns.Add("Gender", "الجنس");
                dgvCustomers.Columns.Add("LicenseNumber", "رقم الرخصة");
                dgvCustomers.Columns.Add("LicenseDate", "تاريخ الرخصة");
                dgvCustomers.Columns.Add("Address", "العنوان");
            }
            dgvCustomers.Rows.Clear();
            foreach (Customer c in DataStore.Customers)
            {
                dgvCustomers.Rows.Add(c.CustomerID, c.Name, c.Phone, c.Gender,
                    c.LicenseNumber, c.LicenseDate.ToString("dd/MM/yyyy"),
                    c.Address.Length > 30 ? c.Address.Substring(0, 30) + "..." : c.Address);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Customer nc = new Customer();
            nc.CustomerID    = DataStore.GetNextCustomerID();
            nc.Name          = txtName.Text.Trim();
            nc.Phone         = txtPhone.Text.Trim();
            nc.LicenseNumber = txtLicense.Text.Trim();
            nc.Gender        = rbMale.Checked ? "ذكر" : "أنثى";
            nc.LicenseDate   = dtpLicenseDate.Value;
            nc.Address       = rtbAddress.Text.Trim();

            DataStore.Customers.Add(nc);
            LoadCustomersGrid();
            MessageBox.Show($"تمت إضافة العميل '{nc.Name}' بنجاح!", "تمت الإضافة",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("يرجى اختيار عميل من الجدول أولاً!", "لم يتم الاختيار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!ValidateInputs()) return;

            Customer c = DataStore.Customers.Find(x => x.CustomerID == selectedCustomerID);
            if (c != null)
            {
                c.Name = txtName.Text.Trim(); c.Phone = txtPhone.Text.Trim();
                c.LicenseNumber = txtLicense.Text.Trim();
                c.Gender = rbMale.Checked ? "ذكر" : "أنثى";
                c.LicenseDate = dtpLicenseDate.Value; c.Address = rtbAddress.Text.Trim();
                LoadCustomersGrid();
                MessageBox.Show("تم تعديل بيانات العميل بنجاح!", "تم التعديل",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("يرجى اختيار عميل للحذف!", "لم يتم الاختيار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (MessageBox.Show("هل أنت متأكد من حذف هذا العميل؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.Customers.RemoveAll(c => c.CustomerID == selectedCustomerID);
                LoadCustomersGrid(); ClearForm();
                MessageBox.Show("تم حذف العميل بنجاح!", "تم الحذف",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedCustomerID = int.Parse(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
            Customer c = DataStore.Customers.Find(x => x.CustomerID == selectedCustomerID);
            if (c != null)
            {
                txtName.Text = c.Name; txtPhone.Text = c.Phone; txtLicense.Text = c.LicenseNumber;
                rbMale.Checked = (c.Gender == "ذكر"); rbFemale.Checked = (c.Gender == "أنثى");
                dtpLicenseDate.Value = c.LicenseDate; rtbAddress.Text = c.Address;
            }
        }

        private void editCustomerMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("قم بتعديل الحقول ثم اضغط 'تعديل'.", "وضع التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void deleteCustomerMenuItem_Click(object sender, EventArgs e) { btnDelete_Click(sender, e); }

        private void viewCustomerMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1) return;
            Customer c = DataStore.Customers.Find(x => x.CustomerID == selectedCustomerID);
            if (c != null)
                MessageBox.Show($"الرقم   : {c.CustomerID}\nالاسم   : {c.Name}\nالهاتف  : {c.Phone}\nالجنس   : {c.Gender}\nالرخصة  : {c.LicenseNumber}\nالتاريخ : {c.LicenseDate:dd/MM/yyyy}\nالعنوان : {c.Address}",
                    "تفاصيل العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            { MessageBox.Show("يرجى إدخال اسم العميل!", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtName.Focus(); return false; }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            { MessageBox.Show("يرجى إدخال رقم الهاتف!", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPhone.Focus(); return false; }
            return true;
        }

        private void ClearForm()
        {
            txtName.Clear(); txtPhone.Clear(); txtLicense.Clear(); rtbAddress.Clear();
            rbMale.Checked = true; dtpLicenseDate.Value = System.DateTime.Today;
            selectedCustomerID = -1;
        }
    }
}
