// ============================================================
// RentalForm.cs — واجهة التأجير (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class RentalForm : Form
    {
        public RentalForm() { InitializeComponent(); }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            LoadCustomersCombo();
            LoadCarsCombo();
            dtpRentalDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
        }

        private void LoadCustomersCombo()
        {
            cmbCustomer.Items.Clear();
            foreach (Customer c in DataStore.Customers) cmbCustomer.Items.Add(c);
        }

        private void LoadCarsCombo()
        {
            cmbCar.Items.Clear();
            foreach (Car car in DataStore.Cars)
                if (car.Status == "متاحة") cmbCar.Items.Add(car);
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCar.SelectedItem is Car car)
            {
                lblDailyPriceValue.Text = car.DailyPrice.ToString("C");
                CalculateTotal();
            }
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.Value = dtpRentalDate.Value.AddDays((double)nudDays.Value);
            CalculateTotal();
        }

        private void dtpRentalDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.Value = dtpRentalDate.Value.AddDays((double)nudDays.Value);
        }

        private void CalculateTotal()
        {
            if (cmbCar.SelectedItem is Car car)
            {
                decimal total = car.DailyPrice * nudDays.Value;
                lblTotalValue.Text = total.ToString("C");
            }
        }

        private void btnNewRental_Click(object sender, EventArgs e) { ClearForm(); }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbCar.SelectedItem == null)
            { MessageBox.Show("يرجى اختيار سيارة!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            CalculateTotal();
            MessageBox.Show($"إجمالي التأجير: {lblTotalValue.Text}", "نتيجة الحساب", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            { MessageBox.Show("يرجى اختيار عميل!", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cmbCar.SelectedItem == null)
            { MessageBox.Show("يرجى اختيار سيارة!", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Customer customer = (Customer)cmbCustomer.SelectedItem;
            Car car = (Car)cmbCar.SelectedItem;

            Car freshCar = DataStore.Cars.Find(c => c.CarID == car.CarID);
            if (freshCar == null || freshCar.Status != "متاحة")
            { MessageBox.Show("هذه السيارة لم تعد متاحة!", "غير متاحة", MessageBoxButtons.OK, MessageBoxIcon.Error); LoadCarsCombo(); return; }

            Rental rental = new Rental();
            rental.RentalID     = DataStore.GetNextRentalID();
            rental.CustomerID   = customer.CustomerID;
            rental.CustomerName = customer.Name;
            rental.CarID        = car.CarID;
            rental.CarInfo      = car.ToString();
            rental.RentalDate   = dtpRentalDate.Value;
            rental.ReturnDate   = dtpReturnDate.Value;
            rental.NumberOfDays = (int)nudDays.Value;
            rental.DailyPrice   = car.DailyPrice;
            rental.TotalPrice   = car.DailyPrice * nudDays.Value;
            rental.Notes        = rtbNotes.Text;
            rental.Status       = "نشط";

            DataStore.Rentals.Add(rental);
            freshCar.Status = "مؤجرة";

            MessageBox.Show(
                $"✅ تم تأجير السيارة بنجاح!\n\nالعميل: {customer.Name}\nالسيارة: {car.Brand} {car.Model}\nالمدة: {rental.NumberOfDays} يوم\nالإجمالي: {rental.TotalPrice:C}",
                "تم التأجير", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCarsCombo(); LoadRentalsGrid(); ClearForm();
        }

        private void LoadRentalsGrid()
        {
            if (dgvRentals.Columns.Count == 0)
            {
                dgvRentals.Columns.Add("RentalID", "رقم التأجير");
                dgvRentals.Columns.Add("CustomerName", "اسم العميل");
                dgvRentals.Columns.Add("CarInfo", "السيارة");
                dgvRentals.Columns.Add("RentalDate", "تاريخ التأجير");
                dgvRentals.Columns.Add("ReturnDate", "تاريخ الإرجاع");
                dgvRentals.Columns.Add("NumberOfDays", "المدة");
                dgvRentals.Columns.Add("DailyPrice", "السعر اليومي");
                dgvRentals.Columns.Add("TotalPrice", "الإجمالي");
                dgvRentals.Columns.Add("Status", "الحالة");
            }
            dgvRentals.Rows.Clear();
            foreach (Rental r in DataStore.Rentals)
                dgvRentals.Rows.Add(r.RentalID, r.CustomerName, r.CarInfo, r.RentalDate.ToString("dd/MM/yyyy"),
                    r.ReturnDate.ToString("dd/MM/yyyy"), r.NumberOfDays, r.DailyPrice.ToString("C"),
                    r.TotalPrice.ToString("C"), r.Status);
        }

        private void ClearForm()
        {
            cmbCustomer.SelectedIndex = -1; cmbCar.SelectedIndex = -1;
            nudDays.Value = 1; dtpRentalDate.Value = DateTime.Today; dtpReturnDate.Value = DateTime.Today.AddDays(1);
            lblDailyPriceValue.Text = "0.00 ريال"; lblTotalValue.Text = "0.00 ريال"; rtbNotes.Clear();
        }
    }
}
