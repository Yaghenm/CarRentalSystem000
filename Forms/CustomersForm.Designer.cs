// ============================================================
// CustomersForm.Designer.cs — تصميم إدارة العملاء (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class CustomersForm
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblLicenseDate = new System.Windows.Forms.Label();
            this.dtpLicenseDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.contextMenuCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.contextMenuCustomers.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(950, 55);
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
            this.lblTitle.Text = "👥 إدارة العملاء";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblName);
            this.panelForm.Controls.Add(this.txtName);
            this.panelForm.Controls.Add(this.lblPhone);
            this.panelForm.Controls.Add(this.txtPhone);
            this.panelForm.Controls.Add(this.lblLicense);
            this.panelForm.Controls.Add(this.txtLicense);
            this.panelForm.Controls.Add(this.grpGender);
            this.panelForm.Controls.Add(this.lblLicenseDate);
            this.panelForm.Controls.Add(this.dtpLicenseDate);
            this.panelForm.Controls.Add(this.lblAddress);
            this.panelForm.Controls.Add(this.rtbAddress);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Location = new System.Drawing.Point(0, 55);
            this.panelForm.Name = "panelForm";
            this.panelForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForm.Size = new System.Drawing.Size(350, 600);
            this.panelForm.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblName.Location = new System.Drawing.Point(15, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(320, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "الاسم الكامل:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(15, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 34);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPhone.Location = new System.Drawing.Point(15, 85);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(320, 22);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "رقم الهاتف:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(15, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(320, 34);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLicense.Location = new System.Drawing.Point(15, 150);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(320, 22);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "رقم الرخصة:";
            this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLicense
            // 
            this.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLicense.Location = new System.Drawing.Point(15, 173);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(320, 34);
            this.txtLicense.TabIndex = 5;
            this.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbMale);
            this.grpGender.Controls.Add(this.rbFemale);
            this.grpGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGender.Location = new System.Drawing.Point(15, 215);
            this.grpGender.Name = "grpGender";
            this.grpGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpGender.Size = new System.Drawing.Size(320, 60);
            this.grpGender.TabIndex = 6;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "الجنس";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMale.Location = new System.Drawing.Point(210, 25);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(80, 22);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ذكر";
            // 
            // rbFemale
            // 
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbFemale.Location = new System.Drawing.Point(80, 25);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "أنثى";
            // 
            // lblLicenseDate
            // 
            this.lblLicenseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLicenseDate.Location = new System.Drawing.Point(15, 280);
            this.lblLicenseDate.Name = "lblLicenseDate";
            this.lblLicenseDate.Size = new System.Drawing.Size(320, 22);
            this.lblLicenseDate.TabIndex = 11;
            this.lblLicenseDate.Text = "تاريخ الرخصة:";
            this.lblLicenseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpLicenseDate
            // 
            this.dtpLicenseDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpLicenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicenseDate.Location = new System.Drawing.Point(15, 303);
            this.dtpLicenseDate.Name = "dtpLicenseDate";
            this.dtpLicenseDate.Size = new System.Drawing.Size(320, 34);
            this.dtpLicenseDate.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddress.Location = new System.Drawing.Point(15, 333);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(320, 22);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "العنوان:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbAddress
            // 
            this.rtbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbAddress.Location = new System.Drawing.Point(15, 356);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(320, 50);
            this.rtbAddress.TabIndex = 14;
            this.rtbAddress.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "➕ إضافة عميل";
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
            this.btnUpdate.Location = new System.Drawing.Point(180, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 45);
            this.btnUpdate.TabIndex = 8;
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
            this.btnDelete.Location = new System.Drawing.Point(180, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 45);
            this.btnDelete.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(15, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "🗙 مسح الكل";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 34;
            this.dgvCustomers.ContextMenuStrip = this.contextMenuCustomers;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCustomers.Location = new System.Drawing.Point(360, 65);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(580, 580);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // contextMenuCustomers
            // 
            this.contextMenuCustomers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomerMenuItem,
            this.deleteCustomerMenuItem,
            this.viewCustomerMenuItem});
            this.contextMenuCustomers.Name = "contextMenuCustomers";
            this.contextMenuCustomers.Size = new System.Drawing.Size(228, 100);
            // 
            // editCustomerMenuItem
            // 
            this.editCustomerMenuItem.Name = "editCustomerMenuItem";
            this.editCustomerMenuItem.Size = new System.Drawing.Size(227, 32);
            this.editCustomerMenuItem.Text = "✏ تعديل";
            this.editCustomerMenuItem.Click += new System.EventHandler(this.editCustomerMenuItem_Click);
            // 
            // deleteCustomerMenuItem
            // 
            this.deleteCustomerMenuItem.Name = "deleteCustomerMenuItem";
            this.deleteCustomerMenuItem.Size = new System.Drawing.Size(227, 32);
            this.deleteCustomerMenuItem.Text = "🗑 حذف";
            this.deleteCustomerMenuItem.Click += new System.EventHandler(this.deleteCustomerMenuItem_Click);
            // 
            // viewCustomerMenuItem
            // 
            this.viewCustomerMenuItem.Name = "viewCustomerMenuItem";
            this.viewCustomerMenuItem.Size = new System.Drawing.Size(227, 32);
            this.viewCustomerMenuItem.Text = "👁 عرض التفاصيل";
            this.viewCustomerMenuItem.Click += new System.EventHandler(this.viewCustomerMenuItem_Click);
            // 
            // CustomersForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 660);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Name = "CustomersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - العملاء";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.grpGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.contextMenuCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblLicenseDate;
        private System.Windows.Forms.DateTimePicker dtpLicenseDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ContextMenuStrip contextMenuCustomers;
        private System.Windows.Forms.ToolStripMenuItem editCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerMenuItem;
    }
}
