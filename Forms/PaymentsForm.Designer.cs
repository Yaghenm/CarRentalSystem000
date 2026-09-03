// ============================================================
// PaymentsForm.Designer.cs — تصميم المدفوعات (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class PaymentsForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblRentalStatus = new System.Windows.Forms.Label();
            this.txtRentalStatus = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.chkPrintInvoice = new System.Windows.Forms.CheckBox();
            this.lblFinalTotalLabel = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.rtbInvoice = new System.Windows.Forms.RichTextBox();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.grpPaymentMethod.SuspendLayout();
            this.panelInvoice.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(993, 55);
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
            this.lblTitle.Text = "💳 الدفع والفواتير";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblRental);
            this.panelForm.Controls.Add(this.cmbRental);
            this.panelForm.Controls.Add(this.lblCustomerName);
            this.panelForm.Controls.Add(this.txtCustomerName);
            this.panelForm.Controls.Add(this.lblRentalStatus);
            this.panelForm.Controls.Add(this.txtRentalStatus);
            this.panelForm.Controls.Add(this.lblAmount);
            this.panelForm.Controls.Add(this.txtAmount);
            this.panelForm.Controls.Add(this.grpPaymentMethod);
            this.panelForm.Controls.Add(this.chkIsPaid);
            this.panelForm.Controls.Add(this.chkPrintInvoice);
            this.panelForm.Controls.Add(this.lblFinalTotalLabel);
            this.panelForm.Controls.Add(this.lblFinalTotal);
            this.panelForm.Controls.Add(this.btnCalculate);
            this.panelForm.Controls.Add(this.btnPay);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Location = new System.Drawing.Point(0, 55);
            this.panelForm.Name = "panelForm";
            this.panelForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForm.Size = new System.Drawing.Size(420, 520);
            this.panelForm.TabIndex = 1;
            // 
            // lblRental
            // 
            this.lblRental.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRental.Location = new System.Drawing.Point(10, 15);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(390, 22);
            this.lblRental.TabIndex = 0;
            this.lblRental.Text = "اختر عملية التأجير (بالرقم أو اسم العميل):";
            this.lblRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRental
            // 
            this.cmbRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRental.Location = new System.Drawing.Point(10, 38);
            this.cmbRental.Name = "cmbRental";
            this.cmbRental.Size = new System.Drawing.Size(390, 36);
            this.cmbRental.TabIndex = 1;
            this.cmbRental.SelectedIndexChanged += new System.EventHandler(this.cmbRental_SelectedIndexChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCustomerName.Location = new System.Drawing.Point(10, 75);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(390, 22);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "اسم العميل:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(10, 98);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(390, 34);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRentalStatus
            // 
            this.lblRentalStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRentalStatus.Location = new System.Drawing.Point(10, 135);
            this.lblRentalStatus.Name = "lblRentalStatus";
            this.lblRentalStatus.Size = new System.Drawing.Size(390, 22);
            this.lblRentalStatus.TabIndex = 4;
            this.lblRentalStatus.Text = "حالة التأجير:";
            this.lblRentalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRentalStatus
            // 
            this.txtRentalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtRentalStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRentalStatus.Location = new System.Drawing.Point(10, 158);
            this.txtRentalStatus.Name = "txtRentalStatus";
            this.txtRentalStatus.ReadOnly = true;
            this.txtRentalStatus.Size = new System.Drawing.Size(390, 34);
            this.txtRentalStatus.TabIndex = 5;
            this.txtRentalStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAmount.Location = new System.Drawing.Point(10, 195);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(390, 22);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "المبلغ المطلوب (يشمل الغرامات إن وجدت):";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount.Location = new System.Drawing.Point(10, 218);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(390, 34);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.rbCash);
            this.grpPaymentMethod.Controls.Add(this.rbCard);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPaymentMethod.Location = new System.Drawing.Point(10, 255);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPaymentMethod.Size = new System.Drawing.Size(390, 55);
            this.grpPaymentMethod.TabIndex = 8;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "طريقة الدفع";
            // 
            // rbCash
            // 
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCash.Location = new System.Drawing.Point(290, 22);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(80, 22);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "💵 نقدي";
            // 
            // rbCard
            // 
            this.rbCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCard.Location = new System.Drawing.Point(130, 22);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(140, 22);
            this.rbCard.TabIndex = 1;
            this.rbCard.Text = "💳 بطاقة ائتمان";
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsPaid.Checked = true;
            this.chkIsPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkIsPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.chkIsPaid.Location = new System.Drawing.Point(10, 320);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(390, 25);
            this.chkIsPaid.TabIndex = 9;
            this.chkIsPaid.Text = "تم استلام المبلغ بالكامل ✓";
            // 
            // chkPrintInvoice
            // 
            this.chkPrintInvoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPrintInvoice.Checked = true;
            this.chkPrintInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPrintInvoice.Location = new System.Drawing.Point(10, 350);
            this.chkPrintInvoice.Name = "chkPrintInvoice";
            this.chkPrintInvoice.Size = new System.Drawing.Size(390, 25);
            this.chkPrintInvoice.TabIndex = 10;
            this.chkPrintInvoice.Text = "📄 توليد وعرض الفاتورة بعد الدفع";
            // 
            // lblFinalTotalLabel
            // 
            this.lblFinalTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFinalTotalLabel.Location = new System.Drawing.Point(10, 385);
            this.lblFinalTotalLabel.Name = "lblFinalTotalLabel";
            this.lblFinalTotalLabel.Size = new System.Drawing.Size(120, 22);
            this.lblFinalTotalLabel.TabIndex = 11;
            this.lblFinalTotalLabel.Text = "الإجمالي النهائي:";
            this.lblFinalTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblFinalTotal.Location = new System.Drawing.Point(140, 380);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(260, 35);
            this.lblFinalTotal.TabIndex = 12;
            this.lblFinalTotal.Text = "0.00 ريال";
            this.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(10, 425);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 40);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "🔄 تحديث المبلغ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(205, 425);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(195, 40);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "✅ تأكيد الدفع";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(10, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(390, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "🗙 مسح الكل";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelInvoice
            // 
            this.panelInvoice.BackColor = System.Drawing.Color.White;
            this.panelInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInvoice.Controls.Add(this.lblInvoiceTitle);
            this.panelInvoice.Controls.Add(this.rtbInvoice);
            this.panelInvoice.Location = new System.Drawing.Point(430, 55);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelInvoice.Size = new System.Drawing.Size(430, 520);
            this.panelInvoice.TabIndex = 2;
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTitle.Location = new System.Drawing.Point(10, 10);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(410, 22);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "📄 الفاتورة";
            this.lblInvoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbInvoice
            // 
            this.rtbInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rtbInvoice.Font = new System.Drawing.Font("Consolas", 11F);
            this.rtbInvoice.Location = new System.Drawing.Point(10, 40);
            this.rtbInvoice.Name = "rtbInvoice";
            this.rtbInvoice.ReadOnly = true;
            this.rtbInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbInvoice.Size = new System.Drawing.Size(410, 470);
            this.rtbInvoice.TabIndex = 1;
            this.rtbInvoice.Text = "";
            // 
            // PaymentsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(993, 620);
            this.Controls.Add(this.panelInvoice);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Name = "PaymentsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - المدفوعات";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.grpPaymentMethod.ResumeLayout(false);
            this.panelInvoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.ComboBox cmbRental;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblRentalStatus;
        private System.Windows.Forms.TextBox txtRentalStatus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.CheckBox chkIsPaid;
        private System.Windows.Forms.CheckBox chkPrintInvoice;
        private System.Windows.Forms.Label lblFinalTotalLabel;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.RichTextBox rtbInvoice;
    }
}
