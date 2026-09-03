// ============================================================
// ReturnForm.Designer.cs — تصميم الإرجاع (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class ReturnForm
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
            this.lblRental = new System.Windows.Forms.Label();
            this.cmbRental = new System.Windows.Forms.ComboBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.txtCarInfo = new System.Windows.Forms.TextBox();
            this.lblExpected = new System.Windows.Forms.Label();
            this.txtExpectedReturn = new System.Windows.Forms.TextBox();
            this.lblActualReturn = new System.Windows.Forms.Label();
            this.dtpActualReturn = new System.Windows.Forms.DateTimePicker();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.nudLateDays = new System.Windows.Forms.NumericUpDown();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblFineValue = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.trackBarCondition = new System.Windows.Forms.TrackBar();
            this.lblConditionValue = new System.Windows.Forms.Label();
            this.progressCondition = new System.Windows.Forms.ProgressBar();
            this.grpCarState = new System.Windows.Forms.GroupBox();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.lblReturnNotes = new System.Windows.Forms.Label();
            this.rtbReturnNotes = new System.Windows.Forms.RichTextBox();
            this.btnCalculateFine = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLateDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCondition)).BeginInit();
            this.grpCarState.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(696, 55);
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
            this.lblTitle.Text = "🔄 إرجاع السيارات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblRental);
            this.panelForm.Controls.Add(this.cmbRental);
            this.panelForm.Controls.Add(this.lblCustomerInfo);
            this.panelForm.Controls.Add(this.txtCustomerInfo);
            this.panelForm.Controls.Add(this.lblCarInfo);
            this.panelForm.Controls.Add(this.txtCarInfo);
            this.panelForm.Controls.Add(this.lblExpected);
            this.panelForm.Controls.Add(this.txtExpectedReturn);
            this.panelForm.Controls.Add(this.lblActualReturn);
            this.panelForm.Controls.Add(this.dtpActualReturn);
            this.panelForm.Controls.Add(this.lblLateDays);
            this.panelForm.Controls.Add(this.nudLateDays);
            this.panelForm.Controls.Add(this.lblFine);
            this.panelForm.Controls.Add(this.lblFineValue);
            this.panelForm.Controls.Add(this.lblTotalLabel);
            this.panelForm.Controls.Add(this.lblTotalPaid);
            this.panelForm.Controls.Add(this.lblCondition);
            this.panelForm.Controls.Add(this.trackBarCondition);
            this.panelForm.Controls.Add(this.lblConditionValue);
            this.panelForm.Controls.Add(this.progressCondition);
            this.panelForm.Controls.Add(this.grpCarState);
            this.panelForm.Controls.Add(this.lblReturnNotes);
            this.panelForm.Controls.Add(this.rtbReturnNotes);
            this.panelForm.Controls.Add(this.btnCalculateFine);
            this.panelForm.Controls.Add(this.btnReturn);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Location = new System.Drawing.Point(0, 55);
            this.panelForm.Name = "panelForm";
            this.panelForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForm.Size = new System.Drawing.Size(500, 680);
            this.panelForm.TabIndex = 1;
            // 
            // lblRental
            // 
            this.lblRental.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRental.Location = new System.Drawing.Point(10, 15);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(460, 22);
            this.lblRental.TabIndex = 0;
            this.lblRental.Text = "اختر عملية التأجير النشطة:";
            this.lblRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRental
            // 
            this.cmbRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRental.Location = new System.Drawing.Point(10, 38);
            this.cmbRental.Name = "cmbRental";
            this.cmbRental.Size = new System.Drawing.Size(460, 36);
            this.cmbRental.TabIndex = 1;
            this.cmbRental.SelectedIndexChanged += new System.EventHandler(this.cmbRental_SelectedIndexChanged);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCustomerInfo.Location = new System.Drawing.Point(10, 75);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(460, 22);
            this.lblCustomerInfo.TabIndex = 2;
            this.lblCustomerInfo.Text = "العميل:";
            this.lblCustomerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerInfo.Location = new System.Drawing.Point(10, 98);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.ReadOnly = true;
            this.txtCustomerInfo.Size = new System.Drawing.Size(460, 34);
            this.txtCustomerInfo.TabIndex = 3;
            this.txtCustomerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCarInfo.Location = new System.Drawing.Point(10, 135);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(460, 22);
            this.lblCarInfo.TabIndex = 4;
            this.lblCarInfo.Text = "السيارة:";
            this.lblCarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCarInfo
            // 
            this.txtCarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtCarInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCarInfo.Location = new System.Drawing.Point(10, 158);
            this.txtCarInfo.Name = "txtCarInfo";
            this.txtCarInfo.ReadOnly = true;
            this.txtCarInfo.Size = new System.Drawing.Size(460, 34);
            this.txtCarInfo.TabIndex = 5;
            this.txtCarInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExpected
            // 
            this.lblExpected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblExpected.Location = new System.Drawing.Point(10, 195);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(200, 22);
            this.lblExpected.TabIndex = 6;
            this.lblExpected.Text = "تاريخ الإرجاع المتوقع:";
            this.lblExpected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExpectedReturn
            // 
            this.txtExpectedReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtExpectedReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpectedReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExpectedReturn.Location = new System.Drawing.Point(10, 218);
            this.txtExpectedReturn.Name = "txtExpectedReturn";
            this.txtExpectedReturn.ReadOnly = true;
            this.txtExpectedReturn.Size = new System.Drawing.Size(200, 34);
            this.txtExpectedReturn.TabIndex = 7;
            this.txtExpectedReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblActualReturn
            // 
            this.lblActualReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActualReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblActualReturn.Location = new System.Drawing.Point(220, 195);
            this.lblActualReturn.Name = "lblActualReturn";
            this.lblActualReturn.Size = new System.Drawing.Size(250, 22);
            this.lblActualReturn.TabIndex = 8;
            this.lblActualReturn.Text = "تاريخ الإرجاع الفعلي:";
            this.lblActualReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpActualReturn
            // 
            this.dtpActualReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpActualReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActualReturn.Location = new System.Drawing.Point(220, 218);
            this.dtpActualReturn.Name = "dtpActualReturn";
            this.dtpActualReturn.Size = new System.Drawing.Size(250, 34);
            this.dtpActualReturn.TabIndex = 9;
            // 
            // lblLateDays
            // 
            this.lblLateDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLateDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLateDays.Location = new System.Drawing.Point(10, 255);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(100, 22);
            this.lblLateDays.TabIndex = 10;
            this.lblLateDays.Text = "أيام التأخير:";
            this.lblLateDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudLateDays
            // 
            this.nudLateDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudLateDays.Location = new System.Drawing.Point(10, 278);
            this.nudLateDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudLateDays.Name = "nudLateDays";
            this.nudLateDays.ReadOnly = true;
            this.nudLateDays.Size = new System.Drawing.Size(100, 34);
            this.nudLateDays.TabIndex = 11;
            // 
            // lblFine
            // 
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFine.Location = new System.Drawing.Point(130, 255);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(120, 22);
            this.lblFine.TabIndex = 12;
            this.lblFine.Text = "غرامة التأخير:";
            this.lblFine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFineValue
            // 
            this.lblFineValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFineValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblFineValue.Location = new System.Drawing.Point(130, 278);
            this.lblFineValue.Name = "lblFineValue";
            this.lblFineValue.Size = new System.Drawing.Size(160, 28);
            this.lblFineValue.TabIndex = 13;
            this.lblFineValue.Text = "0.00 ريال";
            this.lblFineValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(300, 255);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(100, 22);
            this.lblTotalLabel.TabIndex = 14;
            this.lblTotalLabel.Text = "إجمالي التأجير:";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTotalPaid.Location = new System.Drawing.Point(300, 278);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(150, 28);
            this.lblTotalPaid.TabIndex = 15;
            this.lblTotalPaid.Text = "0.00 ريال";
            this.lblTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCondition
            // 
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCondition.Location = new System.Drawing.Point(10, 318);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(460, 22);
            this.lblCondition.TabIndex = 16;
            this.lblCondition.Text = "تقييم حالة السيارة (1=تالفة, 10=ممتازة):";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarCondition
            // 
            this.trackBarCondition.LargeChange = 1;
            this.trackBarCondition.Location = new System.Drawing.Point(10, 340);
            this.trackBarCondition.Minimum = 1;
            this.trackBarCondition.Name = "trackBarCondition";
            this.trackBarCondition.Size = new System.Drawing.Size(460, 69);
            this.trackBarCondition.TabIndex = 17;
            this.trackBarCondition.Value = 10;
            this.trackBarCondition.Scroll += new System.EventHandler(this.trackBarCondition_Scroll);
            // 
            // lblConditionValue
            // 
            this.lblConditionValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConditionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.lblConditionValue.Location = new System.Drawing.Point(10, 388);
            this.lblConditionValue.Name = "lblConditionValue";
            this.lblConditionValue.Size = new System.Drawing.Size(300, 22);
            this.lblConditionValue.TabIndex = 18;
            this.lblConditionValue.Text = "تقييم الحالة: 10/10";
            this.lblConditionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressCondition
            // 
            this.progressCondition.Location = new System.Drawing.Point(10, 415);
            this.progressCondition.Name = "progressCondition";
            this.progressCondition.Size = new System.Drawing.Size(460, 20);
            this.progressCondition.TabIndex = 19;
            this.progressCondition.Value = 100;
            // 
            // grpCarState
            // 
            this.grpCarState.Controls.Add(this.rbGood);
            this.grpCarState.Controls.Add(this.rbDamaged);
            this.grpCarState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCarState.Location = new System.Drawing.Point(10, 445);
            this.grpCarState.Name = "grpCarState";
            this.grpCarState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCarState.Size = new System.Drawing.Size(460, 55);
            this.grpCarState.TabIndex = 20;
            this.grpCarState.TabStop = false;
            this.grpCarState.Text = "حالة السيارة بعد الإرجاع";
            // 
            // rbGood
            // 
            this.rbGood.Checked = true;
            this.rbGood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbGood.Location = new System.Drawing.Point(340, 22);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(100, 22);
            this.rbGood.TabIndex = 0;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "✅ جيدة";
            // 
            // rbDamaged
            // 
            this.rbDamaged.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbDamaged.Location = new System.Drawing.Point(150, 22);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(150, 22);
            this.rbDamaged.TabIndex = 1;
            this.rbDamaged.Text = "⚠ تالفة / تحتاج صيانة";
            // 
            // lblReturnNotes
            // 
            this.lblReturnNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblReturnNotes.Location = new System.Drawing.Point(10, 508);
            this.lblReturnNotes.Name = "lblReturnNotes";
            this.lblReturnNotes.Size = new System.Drawing.Size(460, 22);
            this.lblReturnNotes.TabIndex = 21;
            this.lblReturnNotes.Text = "ملاحظات الإرجاع:";
            this.lblReturnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbReturnNotes
            // 
            this.rtbReturnNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReturnNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbReturnNotes.Location = new System.Drawing.Point(10, 530);
            this.rtbReturnNotes.Name = "rtbReturnNotes";
            this.rtbReturnNotes.Size = new System.Drawing.Size(460, 70);
            this.rtbReturnNotes.TabIndex = 22;
            this.rtbReturnNotes.Text = "";
            // 
            // btnCalculateFine
            // 
            this.btnCalculateFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btnCalculateFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateFine.FlatAppearance.BorderSize = 0;
            this.btnCalculateFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateFine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculateFine.ForeColor = System.Drawing.Color.White;
            this.btnCalculateFine.Location = new System.Drawing.Point(10, 615);
            this.btnCalculateFine.Name = "btnCalculateFine";
            this.btnCalculateFine.Size = new System.Drawing.Size(145, 40);
            this.btnCalculateFine.TabIndex = 23;
            this.btnCalculateFine.Text = "🔢 حساب الغرامة";
            this.btnCalculateFine.UseVisualStyleBackColor = false;
            this.btnCalculateFine.Click += new System.EventHandler(this.btnCalculateFine_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(165, 615);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 40);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "✅ إرجاع السيارة";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(320, 615);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 40);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "🗙 مسح";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ReturnForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(696, 800);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Name = "ReturnForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - الإرجاع";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLateDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCondition)).EndInit();
            this.grpCarState.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.ComboBox cmbRental;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.TextBox txtCarInfo;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.TextBox txtExpectedReturn;
        private System.Windows.Forms.Label lblActualReturn;
        private System.Windows.Forms.DateTimePicker dtpActualReturn;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.NumericUpDown nudLateDays;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblFineValue;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TrackBar trackBarCondition;
        private System.Windows.Forms.Label lblConditionValue;
        private System.Windows.Forms.ProgressBar progressCondition;
        private System.Windows.Forms.GroupBox grpCarState;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Label lblReturnNotes;
        private System.Windows.Forms.RichTextBox rtbReturnNotes;
        private System.Windows.Forms.Button btnCalculateFine;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
    }
}
