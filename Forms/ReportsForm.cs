// ============================================================
// ReportsForm.cs — التقارير والإحصائيات (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm() { InitializeComponent(); }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            UpdateDashboardStats();
            rbCarsReport.Checked = true;
        }

        private void UpdateDashboardStats()
        {
            int totalCars = DataStore.Cars.Count;
            int availableCars = DataStore.Cars.Count(c => c.Status == "متاحة");
            int rentedCars = DataStore.Cars.Count(c => c.Status == "مؤجرة");
            int maintenanceCars = DataStore.Cars.Count(c => c.Status == "صيانة");
            int totalCustomers = DataStore.Customers.Count;
            int totalRentals = DataStore.Rentals.Count;
            int activeRentals = DataStore.Rentals.Count(r => r.Status == "نشط");
            decimal totalRevenue = DataStore.Payments.Where(p => p.IsPaid).Sum(p => p.Amount);

            lblStatTotalCars.Text = totalCars.ToString();
            lblStatAvailable.Text = availableCars.ToString();
            lblStatRented.Text    = rentedCars.ToString();
            lblStatMaintenance.Text = maintenanceCars.ToString();
            lblStatCustomers.Text = totalCustomers.ToString();
            lblStatRentals.Text   = totalRentals.ToString();
            lblStatActiveRentals.Text = activeRentals.ToString();
            lblStatRevenue.Text   = totalRevenue.ToString("C");

            if (totalCars > 0)
            {
                progAvailable.Value = (availableCars * 100) / totalCars;
                progRented.Value = (rentedCars * 100) / totalCars;
                progMaintenance.Value = (maintenanceCars * 100) / totalCars;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int limit = trackBarLimit.Value;
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();
            rtbReportText.Clear();

            string header = $"--- تقرير تم إنشاؤه في: {DateTime.Now:dd/MM/yyyy HH:mm} ---\n\n";
            rtbReportText.AppendText(header);

            if (rbCarsReport.Checked) GenerateCarsReport(limit);
            else if (rbCustomersReport.Checked) GenerateCustomersReport(limit);
            else if (rbRentalsReport.Checked) GenerateRentalsReport(limit);
            else if (rbPaymentsReport.Checked) GeneratePaymentsReport(limit);

            lblReportInfo.Text = $"عرض {dgvReport.Rows.Count} سجل";
        }

        private void GenerateCarsReport(int limit)
        {
            dgvReport.Columns.Add("CarID", "الرقم");
            dgvReport.Columns.Add("Car", "السيارة");
            dgvReport.Columns.Add("Plate", "اللوحة");
            dgvReport.Columns.Add("Price", "السعر");
            dgvReport.Columns.Add("Status", "الحالة");

            var cars = DataStore.Cars.Take(limit).ToList();
            decimal avgPrice = cars.Count > 0 ? cars.Average(c => c.DailyPrice) : 0;

            rtbReportText.AppendText($"نوع التقرير: تقرير السيارات\n");
            rtbReportText.AppendText($"إجمالي السيارات المعروضة: {cars.Count}\n");
            rtbReportText.AppendText($"متوسط السعر اليومي: {avgPrice:C}\n");

            foreach (var c in cars)
                dgvReport.Rows.Add(c.CarID, $"{c.Brand} {c.Model}", c.PlateNumber, c.DailyPrice.ToString("C"), c.Status);
        }

        private void GenerateCustomersReport(int limit)
        {
            dgvReport.Columns.Add("CustID", "الرقم");
            dgvReport.Columns.Add("Name", "الاسم");
            dgvReport.Columns.Add("Phone", "الهاتف");
            dgvReport.Columns.Add("License", "الرخصة");

            var custs = DataStore.Customers.Take(limit).ToList();

            rtbReportText.AppendText($"نوع التقرير: تقرير العملاء\n");
            rtbReportText.AppendText($"إجمالي العملاء المعروضين: {custs.Count}\n");

            foreach (var c in custs)
                dgvReport.Rows.Add(c.CustomerID, c.Name, c.Phone, c.LicenseNumber);
        }

        private void GenerateRentalsReport(int limit)
        {
            dgvReport.Columns.Add("RentalID", "الرقم");
            dgvReport.Columns.Add("Customer", "العميل");
            dgvReport.Columns.Add("Car", "السيارة");
            dgvReport.Columns.Add("Total", "الإجمالي");
            dgvReport.Columns.Add("Status", "الحالة");

            var rentals = DataStore.Rentals.Take(limit).ToList();
            decimal totalExpected = rentals.Sum(r => r.TotalPrice);

            rtbReportText.AppendText($"نوع التقرير: تقرير التأجير\n");
            rtbReportText.AppendText($"عدد عمليات التأجير المعروضة: {rentals.Count}\n");
            rtbReportText.AppendText($"إجمالي القيمة المتوقعة: {totalExpected:C}\n");

            foreach (var r in rentals)
                dgvReport.Rows.Add(r.RentalID, r.CustomerName, r.CarInfo, r.TotalPrice.ToString("C"), r.Status);
        }

        private void GeneratePaymentsReport(int limit)
        {
            dgvReport.Columns.Add("PayID", "رقم الدفع");
            dgvReport.Columns.Add("RentalID", "رقم التأجير");
            dgvReport.Columns.Add("Amount", "المبلغ");
            dgvReport.Columns.Add("Method", "الطريقة");
            dgvReport.Columns.Add("Date", "التاريخ");

            var payments = DataStore.Payments.Take(limit).ToList();
            decimal totalPaid = payments.Where(p => p.IsPaid).Sum(p => p.Amount);

            rtbReportText.AppendText($"نوع التقرير: تقرير المدفوعات\n");
            rtbReportText.AppendText($"عدد المدفوعات المعروضة: {payments.Count}\n");
            rtbReportText.AppendText($"إجمالي المدفوعات المستلمة: {totalPaid:C}\n");

            foreach (var p in payments)
                dgvReport.Rows.Add(p.PaymentID, p.RentalID, p.Amount.ToString("C"), p.PaymentMethod, p.PaymentDate.ToString("dd/MM/yyyy"));
        }

        private void trackBarLimit_Scroll(object sender, EventArgs e)
        {
            lblLimitValue.Text = $"الحد: {trackBarLimit.Value}";
        }
    }
}
