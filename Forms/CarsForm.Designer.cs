// ============================================================
// CarsForm.Designer.cs — تصميم إدارة السيارات (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class CarsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorValue = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.grpCarType = new System.Windows.Forms.GroupBox();
            this.rbSedan = new System.Windows.Forms.RadioButton();
            this.rbSUV = new System.Windows.Forms.RadioButton();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblPic = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.contextMenuCars = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.grpCarType.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.contextMenuCars.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1120, 55);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🚗 إدارة السيارات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblBrand);
            this.panelLeft.Controls.Add(this.txtBrand);
            this.panelLeft.Controls.Add(this.lblModel);
            this.panelLeft.Controls.Add(this.txtModel);
            this.panelLeft.Controls.Add(this.lblPlate);
            this.panelLeft.Controls.Add(this.txtPlate);
            this.panelLeft.Controls.Add(this.lblYear);
            this.panelLeft.Controls.Add(this.nudYear);
            this.panelLeft.Controls.Add(this.cmbYear);
            this.panelLeft.Controls.Add(this.lblPrice);
            this.panelLeft.Controls.Add(this.nudPrice);
            this.panelLeft.Controls.Add(this.lblStatus);
            this.panelLeft.Controls.Add(this.cmbStatus);
            this.panelLeft.Controls.Add(this.lblColor);
            this.panelLeft.Controls.Add(this.lblColorValue);
            this.panelLeft.Controls.Add(this.btnColor);
            this.panelLeft.Controls.Add(this.grpCarType);
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelLeft.Size = new System.Drawing.Size(330, 520);
            this.panelLeft.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblBrand.Location = new System.Drawing.Point(10, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(300, 22);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "الماركة:";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrand.Location = new System.Drawing.Point(10, 38);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(300, 34);
            this.txtBrand.TabIndex = 1;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblModel.Location = new System.Drawing.Point(10, 75);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(300, 22);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "الموديل:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModel.Location = new System.Drawing.Point(10, 98);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(300, 34);
            this.txtModel.TabIndex = 3;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPlate
            // 
            this.lblPlate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPlate.Location = new System.Drawing.Point(10, 135);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(300, 22);
            this.lblPlate.TabIndex = 4;
            this.lblPlate.Text = "رقم اللوحة:";
            this.lblPlate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlate
            // 
            this.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlate.Location = new System.Drawing.Point(10, 158);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(300, 34);
            this.txtPlate.TabIndex = 5;
            this.txtPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblYear.Location = new System.Drawing.Point(10, 195);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(300, 22);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "سنة الصنع:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudYear.Location = new System.Drawing.Point(10, 218);
            this.nudYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(130, 34);
            this.nudYear.TabIndex = 7;
            this.nudYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYear.Location = new System.Drawing.Point(155, 218);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(155, 36);
            this.cmbYear.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPrice.Location = new System.Drawing.Point(10, 255);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(300, 22);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "السعر اليومي (ريال):";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPrice.Location = new System.Drawing.Point(10, 278);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(300, 34);
            this.nudPrice.TabIndex = 10;
            this.nudPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStatus.Location = new System.Drawing.Point(10, 315);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 22);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "الحالة:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(10, 338);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(300, 36);
            this.cmbStatus.TabIndex = 12;
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblColor.Location = new System.Drawing.Point(10, 375);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(300, 22);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "اللون:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblColorValue
            // 
            this.lblColorValue.BackColor = System.Drawing.Color.White;
            this.lblColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColorValue.Location = new System.Drawing.Point(10, 398);
            this.lblColorValue.Name = "lblColorValue";
            this.lblColorValue.Size = new System.Drawing.Size(165, 28);
            this.lblColorValue.TabIndex = 14;
            this.lblColorValue.Text = "أبيض";
            this.lblColorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(182, 398);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(128, 28);
            this.btnColor.TabIndex = 15;
            this.btnColor.Text = "🎨 اختيار اللون";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // grpCarType
            // 
            this.grpCarType.Controls.Add(this.rbSedan);
            this.grpCarType.Controls.Add(this.rbSUV);
            this.grpCarType.Controls.Add(this.rbTruck);
            this.grpCarType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCarType.Location = new System.Drawing.Point(10, 435);
            this.grpCarType.Name = "grpCarType";
            this.grpCarType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCarType.Size = new System.Drawing.Size(300, 80);
            this.grpCarType.TabIndex = 16;
            this.grpCarType.TabStop = false;
            this.grpCarType.Text = "نوع السيارة";
            // 
            // rbSedan
            // 
            this.rbSedan.Checked = true;
            this.rbSedan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbSedan.Location = new System.Drawing.Point(10, 22);
            this.rbSedan.Name = "rbSedan";
            this.rbSedan.Size = new System.Drawing.Size(80, 27);
            this.rbSedan.TabIndex = 0;
            this.rbSedan.TabStop = true;
            this.rbSedan.Text = "سيدان";
            // 
            // rbSUV
            // 
            this.rbSUV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbSUV.Location = new System.Drawing.Point(96, 22);
            this.rbSUV.Name = "rbSUV";
            this.rbSUV.Size = new System.Drawing.Size(90, 37);
            this.rbSUV.TabIndex = 1;
            this.rbSUV.Text = "دفع رباعي";
            // 
            // rbTruck
            // 
            this.rbTruck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTruck.Location = new System.Drawing.Point(205, 22);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(75, 37);
            this.rbTruck.TabIndex = 2;
            this.rbTruck.Text = "شاحنة";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lblPic);
            this.panelRight.Controls.Add(this.picCar);
            this.panelRight.Controls.Add(this.btnBrowse);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.btnUpdate);
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Controls.Add(this.btnClear);
            this.panelRight.Location = new System.Drawing.Point(332, 55);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Size = new System.Drawing.Size(230, 520);
            this.panelRight.TabIndex = 2;
            // 
            // lblPic
            // 
            this.lblPic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPic.Location = new System.Drawing.Point(10, 15);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(210, 22);
            this.lblPic.TabIndex = 0;
            this.lblPic.Text = "صورة السيارة";
            this.lblPic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.picCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCar.Location = new System.Drawing.Point(10, 38);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(210, 150);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 1;
            this.picCar.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(10, 200);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(210, 35);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "📂 استعراض الصورة";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(10, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "✏ تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "🗑 حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(10, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "🗙 مسح";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCars.ColumnHeadersHeight = 34;
            this.dgvCars.ContextMenuStrip = this.contextMenuCars;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCars.Location = new System.Drawing.Point(0, 578);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 62;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1120, 161);
            this.dgvCars.TabIndex = 3;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // contextMenuCars
            // 
            this.contextMenuCars.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuCars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.deleteMenuItem,
            this.viewDetailsMenuItem});
            this.contextMenuCars.Name = "contextMenuCars";
            this.contextMenuCars.Size = new System.Drawing.Size(228, 100);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(227, 32);
            this.editMenuItem.Text = "✏ تعديل";
            this.editMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(227, 32);
            this.deleteMenuItem.Text = "🗑 حذف";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteContextToolStripMenuItem_Click);
            // 
            // viewDetailsMenuItem
            // 
            this.viewDetailsMenuItem.Name = "viewDetailsMenuItem";
            this.viewDetailsMenuItem.Size = new System.Drawing.Size(227, 32);
            this.viewDetailsMenuItem.Text = "👁 عرض التفاصيل";
            this.viewDetailsMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblGridTitle.Location = new System.Drawing.Point(870, 521);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(200, 54);
            this.lblGridTitle.TabIndex = 4;
            this.lblGridTitle.Text = "📋 جميع السيارات";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1120, 920);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "CarsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - إدارة السيارات";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.grpCarType.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.contextMenuCars.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorValue;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox grpCarType;
        private System.Windows.Forms.RadioButton rbSedan;
        private System.Windows.Forms.RadioButton rbSUV;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.ContextMenuStrip contextMenuCars;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsMenuItem;
        private System.Windows.Forms.Label lblGridTitle;
    }
}
