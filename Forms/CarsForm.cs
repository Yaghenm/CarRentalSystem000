// ============================================================
// CarsForm.cs — إدارة السيارات (عربي)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Models;

namespace CarRentalSystem.Forms
{
    public partial class CarsForm : Form
    {
        private int    selectedCarID  = -1;
        private string selectedColor  = "أبيض";

        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "متاحة", "مؤجرة", "صيانة" });
            cmbStatus.SelectedIndex = 0;

            cmbYear.Items.Clear();
            for (int y = DateTime.Now.Year + 1; y >= 2000; y--)
                cmbYear.Items.Add(y.ToString());
            cmbYear.SelectedIndex = 0;

            LoadCarsGrid();
        }

        private void LoadCarsGrid()
        {
            if (dgvCars.Columns.Count == 0)
            {
                dgvCars.Columns.Add("CarID", "رقم السيارة");
                dgvCars.Columns.Add("Brand", "الماركة");
                dgvCars.Columns.Add("Model", "الموديل");
                dgvCars.Columns.Add("Year", "السنة");
                dgvCars.Columns.Add("Color", "اللون");
                dgvCars.Columns.Add("PlateNumber", "رقم اللوحة");
                dgvCars.Columns.Add("DailyPrice", "السعر اليومي");
                dgvCars.Columns.Add("Status", "الحالة");
                dgvCars.Columns.Add("CarType", "النوع");
            }
            dgvCars.Rows.Clear();
            foreach (Car car in DataStore.Cars)
            {
                dgvCars.Rows.Add(car.CarID, car.Brand, car.Model, car.Year,
                    car.Color, car.PlateNumber,
                    car.DailyPrice.ToString("C"), car.Status, car.CarType);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Car newCar = new Car();
            newCar.CarID       = DataStore.GetNextCarID();
            newCar.Brand       = txtBrand.Text.Trim();
            newCar.Model       = txtModel.Text.Trim();
            newCar.Year        = (int)nudYear.Value;
            newCar.Color       = selectedColor;
            newCar.PlateNumber = txtPlate.Text.Trim();
            newCar.DailyPrice  = nudPrice.Value;
            newCar.Status      = cmbStatus.Text;
            newCar.CarType     = GetSelectedCarType();
            newCar.ImagePath   = picCar.ImageLocation ?? "";

            DataStore.Cars.Add(newCar);
            LoadCarsGrid();

            MessageBox.Show($"تمت إضافة السيارة '{newCar.Brand} {newCar.Model}' بنجاح!",
                "تمت الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCarID == -1)
            {
                MessageBox.Show("يرجى اختيار سيارة من الجدول أولاً!",
                    "لم يتم الاختيار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            Car car = DataStore.Cars.Find(c => c.CarID == selectedCarID);
            if (car != null)
            {
                car.Brand       = txtBrand.Text.Trim();
                car.Model       = txtModel.Text.Trim();
                car.Year        = (int)nudYear.Value;
                car.Color       = selectedColor;
                car.PlateNumber = txtPlate.Text.Trim();
                car.DailyPrice  = nudPrice.Value;
                car.Status      = cmbStatus.Text;
                car.CarType     = GetSelectedCarType();

                LoadCarsGrid();
                MessageBox.Show("تم تعديل بيانات السيارة بنجاح!", "تم التعديل",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCarID == -1)
            {
                MessageBox.Show("يرجى اختيار سيارة للحذف!", "لم يتم الاختيار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من حذف هذه السيارة؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataStore.Cars.RemoveAll(c => c.CarID == selectedCarID);
                LoadCarsGrid();
                ClearForm();
                MessageBox.Show("تم حذف السيارة بنجاح!", "تم الحذف",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title  = "اختيار صورة السيارة";
            openDialog.Filter = "ملفات الصور|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                picCar.Image = Image.FromFile(openDialog.FileName);
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                picCar.ImageLocation = openDialog.FileName;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                selectedColor = ColorTranslator.ToHtml(colorDlg.Color);
                lblColorValue.BackColor = colorDlg.Color;
                lblColorValue.Text = selectedColor;
                lblColorValue.ForeColor = Color.White;
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCars.Rows[e.RowIndex];
            selectedCarID = int.Parse(row.Cells[0].Value.ToString());

            Car car = DataStore.Cars.Find(c => c.CarID == selectedCarID);
            if (car != null)
            {
                txtBrand.Text   = car.Brand;
                txtModel.Text   = car.Model;
                nudYear.Value   = car.Year;
                selectedColor   = car.Color;
                txtPlate.Text   = car.PlateNumber;
                nudPrice.Value  = car.DailyPrice;
                cmbStatus.Text  = car.Status;
                lblColorValue.Text = car.Color;
                SetCarType(car.CarType);

                if (!string.IsNullOrEmpty(car.ImagePath))
                {
                    try { picCar.Image = Image.FromFile(car.ImagePath); picCar.SizeMode = PictureBoxSizeMode.Zoom; }
                    catch { }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("قم بتعديل الحقول ثم اضغط 'تعديل'.", "وضع التعديل",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCarID == -1) return;
            Car car = DataStore.Cars.Find(c => c.CarID == selectedCarID);
            if (car != null)
            {
                string details =
                    $"رقم السيارة : {car.CarID}\n" +
                    $"الماركة     : {car.Brand}\n" +
                    $"الموديل     : {car.Model}\n" +
                    $"السنة       : {car.Year}\n" +
                    $"اللون       : {car.Color}\n" +
                    $"اللوحة      : {car.PlateNumber}\n" +
                    $"السعر اليومي: {car.DailyPrice:C}\n" +
                    $"الحالة      : {car.Status}\n" +
                    $"النوع       : {car.CarType}";

                MessageBox.Show(details, "تفاصيل السيارة",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtBrand.Text.Trim()))
            {
                MessageBox.Show("يرجى إدخال ماركة السيارة!", "حقل مطلوب",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrand.Focus(); return false;
            }
            if (string.IsNullOrEmpty(txtModel.Text.Trim()))
            {
                MessageBox.Show("يرجى إدخال موديل السيارة!", "حقل مطلوب",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus(); return false;
            }
            if (string.IsNullOrEmpty(txtPlate.Text.Trim()))
            {
                MessageBox.Show("يرجى إدخال رقم اللوحة!", "حقل مطلوب",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlate.Focus(); return false;
            }
            return true;
        }

        private string GetSelectedCarType()
        {
            if (rbSUV.Checked)   return "دفع رباعي";
            if (rbTruck.Checked) return "شاحنة";
            return "سيدان";
        }

        private void SetCarType(string carType)
        {
            rbSedan.Checked = (carType == "سيدان");
            rbSUV.Checked   = (carType == "دفع رباعي");
            rbTruck.Checked = (carType == "شاحنة");
        }

        private void ClearForm()
        {
            txtBrand.Clear(); txtModel.Clear(); txtPlate.Clear();
            nudYear.Value  = DateTime.Now.Year;
            nudPrice.Value = 100;
            cmbStatus.SelectedIndex = 0;
            rbSedan.Checked = true;
            picCar.Image = null;
            lblColorValue.Text = "أبيض";
            lblColorValue.BackColor = Color.White;
            selectedCarID = -1;
            selectedColor = "أبيض";
        }
    }
}
