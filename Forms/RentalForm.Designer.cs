// ============================================================
// RentalForm.Designer.cs — تصميم التأجير (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class RentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.lblDailyPriceValue = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.dtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTop.Size = new System.Drawing.Size(1000, 55);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 إضافة تأجير جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblCustomer);
            this.panelForm.Controls.Add(this.cmbCustomer);
            this.panelForm.Controls.Add(this.lblCar);
            this.panelForm.Controls.Add(this.cmbCar);
            this.panelForm.Controls.Add(this.lblDailyPrice);
            this.panelForm.Controls.Add(this.lblDailyPriceValue);
            this.panelForm.Controls.Add(this.lblRentalDate);
            this.panelForm.Controls.Add(this.dtpRentalDate);
            this.panelForm.Controls.Add(this.lblDays);
            this.panelForm.Controls.Add(this.nudDays);
            this.panelForm.Controls.Add(this.lblReturnDate);
            this.panelForm.Controls.Add(this.dtpReturnDate);
            this.panelForm.Controls.Add(this.lblTotal);
            this.panelForm.Controls.Add(this.lblTotalValue);
            this.panelForm.Controls.Add(this.lblNotes);
            this.panelForm.Controls.Add(this.rtbNotes);
            this.panelForm.Controls.Add(this.btnCalculate);
            this.panelForm.Controls.Add(this.btnConfirm);
            this.panelForm.Controls.Add(this.btnNewRental);
            this.panelForm.Location = new System.Drawing.Point(0, 55);
            this.panelForm.Name = "panelForm";
            this.panelForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForm.Size = new System.Drawing.Size(380, 600);
            this.panelForm.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCustomer.Location = new System.Drawing.Point(15, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(340, 22);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "العميل:";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomer.Location = new System.Drawing.Point(15, 45);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(340, 25);
            this.cmbCustomer.TabIndex = 1;
            // 
            // lblCar
            // 
            this.lblCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCar.Location = new System.Drawing.Point(15, 80);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(340, 22);
            this.lblCar.TabIndex = 2;
            this.lblCar.Text = "السيارة المتاحة:";
            this.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCar
            // 
            this.cmbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCar.Location = new System.Drawing.Point(15, 105);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(340, 25);
            this.cmbCar.TabIndex = 3;
            this.cmbCar.SelectedIndexChanged += new System.EventHandler(this.cmbCar_SelectedIndexChanged);
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDailyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDailyPrice.Location = new System.Drawing.Point(155, 145);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(200, 22);
            this.lblDailyPrice.TabIndex = 4;
            this.lblDailyPrice.Text = "السعر اليومي:";
            this.lblDailyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDailyPriceValue
            // 
            this.lblDailyPriceValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDailyPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblDailyPriceValue.Location = new System.Drawing.Point(15, 140);
            this.lblDailyPriceValue.Name = "lblDailyPriceValue";
            this.lblDailyPriceValue.Size = new System.Drawing.Size(140, 30);
            this.lblDailyPriceValue.TabIndex = 5;
            this.lblDailyPriceValue.Text = "0.00 ريال";
            this.lblDailyPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentalDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRentalDate.Location = new System.Drawing.Point(185, 180);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(170, 22);
            this.lblRentalDate.TabIndex = 6;
            this.lblRentalDate.Text = "تاريخ التأجير:";
            this.lblRentalDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpRentalDate
            // 
            this.dtpRentalDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentalDate.Location = new System.Drawing.Point(185, 205);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new System.Drawing.Size(170, 25);
            this.dtpRentalDate.TabIndex = 7;
            this.dtpRentalDate.ValueChanged += new System.EventHandler(this.dtpRentalDate_ValueChanged);
            // 
            // lblDays
            // 
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDays.Location = new System.Drawing.Point(15, 180);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(150, 22);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "عدد الأيام:";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudDays
            // 
            this.nudDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudDays.Location = new System.Drawing.Point(15, 205);
            this.nudDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(150, 25);
            this.nudDays.TabIndex = 9;
            this.nudDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblReturnDate.Location = new System.Drawing.Point(15, 240);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(340, 22);
            this.lblReturnDate.TabIndex = 10;
            this.lblReturnDate.Text = "تاريخ الإرجاع المتوقع:";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(15, 265);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(340, 25);
            this.dtpReturnDate.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotal.Location = new System.Drawing.Point(225, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 25);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "إجمالي التكلفة:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblTotalValue.Location = new System.Drawing.Point(15, 305);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(200, 35);
            this.lblTotalValue.TabIndex = 13;
            this.lblTotalValue.Text = "0.00 ريال";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 355);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(340, 22);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "ملاحظات:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbNotes
            // 
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbNotes.Location = new System.Drawing.Point(15, 380);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(340, 60);
            this.rtbNotes.TabIndex = 15;
            this.rtbNotes.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 460);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(340, 40);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "🔄 حساب التكلفة";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(195, 510);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 40);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "✅ تأكيد التأجير";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnNewRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRental.FlatAppearance.BorderSize = 0;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(15, 510);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(160, 40);
            this.btnNewRental.TabIndex = 18;
            this.btnNewRental.Text = "🗙 مسح";
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.dgvRentals.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRentals.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRentals.EnableHeadersVisualStyles = false;
            this.dgvRentals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRentals.Location = new System.Drawing.Point(390, 65);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(600, 580);
            this.dgvRentals.TabIndex = 2;
            // 
            // RentalForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Name = "RentalForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - تأجير جديد";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.Label lblDailyPriceValue;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.DateTimePicker dtpRentalDate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.DataGridView dgvRentals;
    }
}
