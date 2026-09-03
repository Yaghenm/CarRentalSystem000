// ============================================================
// ReturnForm.cs — إرجاع السيارات (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class ReturnForm : Form
    {
        private Rental selectedRental = null;

        public ReturnForm() { InitializeComponent(); }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            LoadActiveRentalsCombo();
            dtpActualReturn.Value = DateTime.Today;
        }

        private void LoadActiveRentalsCombo()
        {
            cmbRental.Items.Clear();
            foreach (Rental r in DataStore.Rentals)
                if (r.Status == "نشط") cmbRental.Items.Add(r);
        }

        private void cmbRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRental.SelectedItem is Rental rental)
            {
                selectedRental = rental;
                txtCustomerInfo.Text  = rental.CustomerName;
                txtCarInfo.Text       = rental.CarInfo;
                txtExpectedReturn.Text = rental.ReturnDate.ToString("dd/MM/yyyy");
                lblTotalPaid.Text     = rental.TotalPrice.ToString("C");
            }
        }

        private void trackBarCondition_Scroll(object sender, EventArgs e)
        {
            int value = trackBarCondition.Value;
            lblConditionValue.Text = $"تقييم الحالة: {value}/10";
            progressCondition.Value = value * 10;

            if (value >= 7)
            { progressCondition.ForeColor = Color.FromArgb(56, 142, 60); lblConditionValue.ForeColor = Color.FromArgb(56, 142, 60); }
            else if (value >= 4)
            { progressCondition.ForeColor = Color.FromArgb(245, 124, 0); lblConditionValue.ForeColor = Color.FromArgb(245, 124, 0); }
            else
            { progressCondition.ForeColor = Color.FromArgb(211, 47, 47); lblConditionValue.ForeColor = Color.FromArgb(211, 47, 47); }
        }

        private void btnCalculateFine_Click(object sender, EventArgs e)
        {
            if (selectedRental == null)
            { MessageBox.Show("يرجى اختيار تأجير أولاً!", "لم يتم الاختيار", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int lateDays = (int)(dtpActualReturn.Value - selectedRental.ReturnDate).TotalDays;

            if (lateDays > 0)
            {
                decimal fine = lateDays * selectedRental.DailyPrice * 1.5m;
                nudLateDays.Value = lateDays;
                lblFineValue.Text = fine.ToString("C");
                lblFineValue.ForeColor = Color.FromArgb(211, 47, 47);
                rtbReturnNotes.AppendText($"\n⚠ تأخير بمقدار {lateDays} يوم. الغرامة: {fine:C}");
            }
            else
            {
                nudLateDays.Value = 0;
                lblFineValue.Text = "0.00 ريال";
                lblFineValue.ForeColor = Color.FromArgb(56, 142, 60);
                rtbReturnNotes.AppendText("\n✓ تم الإرجاع في الوقت المحدد. لا توجد غرامة.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (selectedRental == null)
            { MessageBox.Show("يرجى اختيار عملية تأجير!", "لم يتم الاختيار", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string condition = rbGood.Checked ? "جيدة" : "تالفة";

            DialogResult result = MessageBox.Show(
                $"تأكيد إرجاع:\n{selectedRental.CarInfo}\n\nالحالة: {condition}\nتاريخ الإرجاع: {dtpActualReturn.Value:dd/MM/yyyy}",
                "تأكيد الإرجاع", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedRental.Status           = "مُرجع";
                selectedRental.ActualReturnDate = dtpActualReturn.Value;

                int lateDays = (int)(dtpActualReturn.Value - selectedRental.ReturnDate).TotalDays;
                if (lateDays > 0) selectedRental.LateFine = lateDays * selectedRental.DailyPrice * 1.5m;

                Car car = DataStore.Cars.Find(c => c.CarID == selectedRental.CarID);
                if (car != null) car.Status = condition == "تالفة" ? "صيانة" : "متاحة";

                MessageBox.Show($"تم إرجاع السيارة بنجاح!\nتغيرت حالة السيارة إلى: {(condition == "تالفة" ? "صيانة" : "متاحة")}", "تم الإرجاع ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadActiveRentalsCombo(); ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        private void ClearForm()
        {
            cmbRental.SelectedIndex = -1; txtCustomerInfo.Clear(); txtCarInfo.Clear(); txtExpectedReturn.Clear();
            dtpActualReturn.Value = DateTime.Today; nudLateDays.Value = 0;
            trackBarCondition.Value = 10; progressCondition.Value = 100;
            rbGood.Checked = true; rtbReturnNotes.Clear();
            lblFineValue.Text = "0.00 ريال"; lblTotalPaid.Text = "0.00 ريال";
            lblConditionValue.Text = "تقييم الحالة: 10/10"; selectedRental = null;
        }
    }
}
