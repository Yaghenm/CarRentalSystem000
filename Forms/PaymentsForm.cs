// ============================================================
// PaymentsForm.cs — المدفوعات والفواتير (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class PaymentsForm : Form
    {
        private Rental selectedRental = null;
        private decimal finalAmount = 0;

        public PaymentsForm() { InitializeComponent(); }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadRentalsCombo();
        }

        private void LoadRentalsCombo()
        {
            cmbRental.Items.Clear();
            foreach (Rental r in DataStore.Rentals)
                cmbRental.Items.Add(r);
        }

        private void cmbRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRental.SelectedItem is Rental rental)
            {
                selectedRental = rental;
                txtCustomerName.Text = rental.CustomerName;
                txtRentalStatus.Text = rental.Status;

                decimal subtotal = rental.TotalPrice;
                decimal fine = rental.LateFine;
                finalAmount = subtotal + fine;

                txtAmount.Text = finalAmount.ToString("F2");
                lblFinalTotal.Text = finalAmount.ToString("C");

                if (rental.Status == "مُرجع" && fine > 0)
                {
                    txtRentalStatus.ForeColor = Color.Red;
                    txtRentalStatus.Text = "مُرجع (يوجد غرامة)";
                }
                else
                {
                    txtRentalStatus.ForeColor = Color.Black;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (selectedRental == null) return;
            if (decimal.TryParse(txtAmount.Text, out decimal userAmount))
            {
                finalAmount = userAmount;
                lblFinalTotal.Text = finalAmount.ToString("C");
                MessageBox.Show($"تم تحديث الإجمالي إلى: {finalAmount:C}", "تحديث السعر", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("يرجى إدخال مبلغ صحيح!", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (selectedRental == null)
            { MessageBox.Show("يرجى اختيار عملية تأجير!", "مفقود", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (finalAmount <= 0)
            { MessageBox.Show("المبلغ يجب أن يكون أكبر من الصفر!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Payment p = new Payment();
            p.PaymentID = DataStore.GetNextPaymentID();
            p.RentalID  = selectedRental.RentalID;
            p.Amount    = finalAmount;
            p.PaymentMethod = rbCash.Checked ? "نقدي (كاش)" : "بطاقة ائتمان";
            p.IsPaid    = chkIsPaid.Checked;
            p.PaymentDate = DateTime.Now;

            string invoice = GenerateInvoiceText(p);
            p.InvoiceDetails = invoice;

            DataStore.Payments.Add(p);

            MessageBox.Show($"تم تسجيل الدفع بنجاح!\nطريقة الدفع: {p.PaymentMethod}\nالمبلغ: {p.Amount:C}", "تم الدفع ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (chkPrintInvoice.Checked)
            {
                rtbInvoice.Clear();
                rtbInvoice.Text = invoice;
            }

            ClearFormInputs();
        }

        private string GenerateInvoiceText(Payment p)
        {
            string status = p.IsPaid ? "مدفوعة ✓" : "غير مدفوعة ⚠";
            string sep = new string('═', 40);
            string sep2 = new string('─', 40);

            return
$@"{sep}
        فاتورة تأجير سيارة
{sep}
رقم الفاتورة: PAY-{DateTime.Now:yyyyMMdd}{p.PaymentID}
التاريخ: {p.PaymentDate:dd/MM/yyyy HH:mm}
{sep2}
العميل      : {selectedRental.CustomerName}
السيارة     : {selectedRental.CarInfo}
تاريخ التأجير: {selectedRental.RentalDate:dd/MM/yyyy}
تاريخ الإرجاع: {selectedRental.ReturnDate:dd/MM/yyyy}
عدد الأيام   : {selectedRental.NumberOfDays} يوم
السعر اليومي : {selectedRental.DailyPrice:C}
{sep2}
المجموع      : {selectedRental.TotalPrice:C}
غرامة تأخير  : {selectedRental.LateFine:C}
{sep2}
الإجمالي     : {p.Amount:C}
طريقة الدفع  : {p.PaymentMethod}
الحالة       : {status}
{sep}
    شكراً لثقتكم بنا!
{sep}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
            rtbInvoice.Clear();
        }

        private void ClearFormInputs()
        {
            cmbRental.SelectedIndex = -1; txtCustomerName.Clear(); txtRentalStatus.Clear();
            txtAmount.Clear(); rbCash.Checked = true; chkIsPaid.Checked = true; chkPrintInvoice.Checked = true;
            lblFinalTotal.Text = "0.00 ريال"; selectedRental = null; finalAmount = 0;
        }
    }
}
