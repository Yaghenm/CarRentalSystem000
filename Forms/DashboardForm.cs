// ============================================================
// DashboardForm.cs — الواجهة الرئيسية (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            timerDash.Start();
            tslUser.Text  = "👤 " + DataStore.CurrentUser;
            sslUser.Text  = "المستخدم: " + DataStore.CurrentUser;
            UpdateStatistics();
        }

        private void timerDash_Tick(object sender, EventArgs e)
        {
            sslTime.Text = DateTime.Now.ToString("HH:mm:ss");
            sslDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void UpdateStatistics()
        {
            int totalCars      = DataStore.Cars.Count;
            int availableCars  = DataStore.Cars.FindAll(c => c.Status == "متاحة").Count;
            int rentedCars     = DataStore.Cars.FindAll(c => c.Status == "مؤجرة").Count;
            int totalCustomers = DataStore.Customers.Count;
            int activeRentals  = DataStore.Rentals.FindAll(r => r.Status == "نشط").Count;

            lblTotalCars.Text      = totalCars.ToString();
            lblAvailableCars.Text  = availableCars.ToString();
            lblRentedCars.Text     = rentedCars.ToString();
            lblTotalCustomers.Text = totalCustomers.ToString();
            lblActiveRentals.Text  = activeRentals.ToString();

            if (totalCars > 0)
            {
                int percentage = (availableCars * 100) / totalCars;
                progressAvailability.Value = percentage;
                lblProgressLabel.Text = $"السيارات المتاحة: {percentage}%";
            }

            sslStatus.Text = "النظام يعمل بشكل صحيح ✓";
        }

        // ---- أحداث MenuStrip ----
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStatistics();
            MessageBox.Show("مرحباً بك في نظام إدارة وتأجير السيارات!", "الرئيسية",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)        { OpenCarsForm(); }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)   { OpenCustomersForm(); }
        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)     { OpenRentalsForm(); }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReturnForm().Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)    { new PaymentsForm().Show(); }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)      { new SearchForm().Show(); }
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)     { new ReportsForm().Show(); }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("الإعدادات: الإصدار 1.0\nتم التطوير لمادة البرمجة المرئية",
                "الإعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "هل تريد الخروج من النظام؟",
                "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        // ---- أحداث ToolStrip ----
        private void tsbCars_Click(object sender, EventArgs e)      { OpenCarsForm(); }
        private void tsbCustomers_Click(object sender, EventArgs e) { OpenCustomersForm(); }
        private void tsbRentals_Click(object sender, EventArgs e)   { OpenRentalsForm(); }
        private void tsbExit_Click(object sender, EventArgs e)      { exitToolStripMenuItem_Click(sender, e); }

        private void OpenCarsForm()
        {
            new CarsForm().Show();
            UpdateStatistics();
        }
        private void OpenCustomersForm() { new CustomersForm().Show(); }
        private void OpenRentalsForm()
        {
            new RentalForm().Show();
            UpdateStatistics();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
