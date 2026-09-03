// ============================================================
// SearchForm.cs — البحث (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class SearchForm : Form
    {
        public SearchForm() { InitializeComponent(); }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmbSearchType.Items.AddRange(new string[] { "السيارات", "العملاء", "عمليات التأجير" });
            cmbSearchType.SelectedIndex = 0;
            PopulateTreeView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            string type = cmbSearchType.SelectedItem?.ToString();

            lstFastResults.Items.Clear();
            dgvResults.Columns.Clear();
            dgvResults.Rows.Clear();

            int count = 0;

            if (type == "السيارات")
            {
                SetupCarsGrid();
                var results = DataStore.Cars.Where(c =>
                    c.Brand.ToLower().Contains(query) ||
                    c.Model.ToLower().Contains(query) ||
                    c.PlateNumber.ToLower().Contains(query) ||
                    c.Status.ToLower().Contains(query) ||
                    c.CarType.ToLower().Contains(query)).ToList();

                foreach (var c in results)
                {
                    lstFastResults.Items.Add($"سيارة: {c.Brand} {c.Model} - {c.PlateNumber} ({c.Status})");
                    dgvResults.Rows.Add(c.CarID, c.Brand, c.Model, c.Year, c.PlateNumber, c.DailyPrice.ToString("C"), c.Status, c.CarType);
                    count++;
                }
            }
            else if (type == "العملاء")
            {
                SetupCustomersGrid();
                var results = DataStore.Customers.Where(c =>
                    c.Name.ToLower().Contains(query) ||
                    c.Phone.Contains(query) ||
                    c.LicenseNumber.ToLower().Contains(query)).ToList();

                foreach (var c in results)
                {
                    lstFastResults.Items.Add($"عميل: {c.Name} - {c.Phone}");
                    dgvResults.Rows.Add(c.CustomerID, c.Name, c.Phone, c.Gender, c.LicenseNumber);
                    count++;
                }
            }
            else if (type == "عمليات التأجير")
            {
                SetupRentalsGrid();
                var results = DataStore.Rentals.Where(r =>
                    r.CustomerName.ToLower().Contains(query) ||
                    r.CarInfo.ToLower().Contains(query) ||
                    r.Status.ToLower().Contains(query)).ToList();

                foreach (var r in results)
                {
                    lstFastResults.Items.Add($"تأجير #{r.RentalID}: {r.CustomerName} - {r.Status}");
                    dgvResults.Rows.Add(r.RentalID, r.CustomerName, r.CarInfo, r.RentalDate.ToString("dd/MM/yyyy"), r.TotalPrice.ToString("C"), r.Status);
                    count++;
                }
            }

            lblResultCount.Text = $"تم العثور على {count} نتيجة";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lstFastResults.Items.Clear();
            dgvResults.Columns.Clear();
            lblResultCount.Text = "لم يتم العثور على نتائج";
            txtSearch.Focus();
        }

        private void PopulateTreeView()
        {
            tvCategories.Nodes.Clear();
            TreeNode rootNode = new TreeNode("🏢 النظام");
            rootNode.NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);

            // --- السيارات ---
            TreeNode carsNode = new TreeNode($"🚗 السيارات ({DataStore.Cars.Count})");
            carsNode.Nodes.Add(new TreeNode($"✅ متاحة ({DataStore.Cars.Count(c => c.Status == "متاحة")})"));
            carsNode.Nodes.Add(new TreeNode($"🔑 مؤجرة ({DataStore.Cars.Count(c => c.Status == "مؤجرة")})"));
            carsNode.Nodes.Add(new TreeNode($"🔧 صيانة ({DataStore.Cars.Count(c => c.Status == "صيانة")})"));

            // --- العملاء ---
            TreeNode customersNode = new TreeNode($"👥 العملاء ({DataStore.Customers.Count})");

            // --- التأجير ---
            TreeNode rentalsNode = new TreeNode($"📋 التأجير ({DataStore.Rentals.Count})");
            rentalsNode.Nodes.Add(new TreeNode($"🟢 نشط ({DataStore.Rentals.Count(r => r.Status == "نشط")})"));
            rentalsNode.Nodes.Add(new TreeNode($"✓ مُرجع ({DataStore.Rentals.Count(r => r.Status == "مُرجع")})"));

            rootNode.Nodes.Add(carsNode);
            rootNode.Nodes.Add(customersNode);
            rootNode.Nodes.Add(rentalsNode);

            tvCategories.Nodes.Add(rootNode);
            tvCategories.ExpandAll();
        }

        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Contains("السيارات"))
            { cmbSearchType.SelectedItem = "السيارات"; txtSearch.Text = ""; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("متاحة"))
            { cmbSearchType.SelectedItem = "السيارات"; txtSearch.Text = "متاحة"; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("مؤجرة"))
            { cmbSearchType.SelectedItem = "السيارات"; txtSearch.Text = "مؤجرة"; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("صيانة"))
            { cmbSearchType.SelectedItem = "السيارات"; txtSearch.Text = "صيانة"; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("العملاء"))
            { cmbSearchType.SelectedItem = "العملاء"; txtSearch.Text = ""; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("التأجير"))
            { cmbSearchType.SelectedItem = "عمليات التأجير"; txtSearch.Text = ""; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("نشط"))
            { cmbSearchType.SelectedItem = "عمليات التأجير"; txtSearch.Text = "نشط"; btnSearch_Click(sender, e); }
            else if (e.Node.Text.Contains("مُرجع"))
            { cmbSearchType.SelectedItem = "عمليات التأجير"; txtSearch.Text = "مُرجع"; btnSearch_Click(sender, e); }
        }

        private void SetupCarsGrid()
        {
            dgvResults.Columns.Add("CarID", "الرقم");
            dgvResults.Columns.Add("Brand", "الماركة");
            dgvResults.Columns.Add("Model", "الموديل");
            dgvResults.Columns.Add("Year", "السنة");
            dgvResults.Columns.Add("Plate", "اللوحة");
            dgvResults.Columns.Add("Price", "السعر اليومي");
            dgvResults.Columns.Add("Status", "الحالة");
            dgvResults.Columns.Add("Type", "النوع");
        }

        private void SetupCustomersGrid()
        {
            dgvResults.Columns.Add("CustID", "الرقم");
            dgvResults.Columns.Add("Name", "الاسم");
            dgvResults.Columns.Add("Phone", "الهاتف");
            dgvResults.Columns.Add("Gender", "الجنس");
            dgvResults.Columns.Add("License", "الرخصة");
        }

        private void SetupRentalsGrid()
        {
            dgvResults.Columns.Add("RentalID", "رقم التأجير");
            dgvResults.Columns.Add("Customer", "العميل");
            dgvResults.Columns.Add("Car", "السيارة");
            dgvResults.Columns.Add("Date", "تاريخ التأجير");
            dgvResults.Columns.Add("Total", "الإجمالي");
            dgvResults.Columns.Add("Status", "الحالة");
        }
    }
}
