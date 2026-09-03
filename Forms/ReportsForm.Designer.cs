// ============================================================
// ReportsForm.Designer.cs — تصميم التقارير (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class ReportsForm
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
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblStatTotalCarsTitle = new System.Windows.Forms.Label();
            this.lblStatTotalCars = new System.Windows.Forms.Label();
            this.lblStatAvailableTitle = new System.Windows.Forms.Label();
            this.lblStatAvailable = new System.Windows.Forms.Label();
            this.lblStatRentedTitle = new System.Windows.Forms.Label();
            this.lblStatRented = new System.Windows.Forms.Label();
            this.lblStatMaintenanceTitle = new System.Windows.Forms.Label();
            this.lblStatMaintenance = new System.Windows.Forms.Label();
            this.lblStatCustomersTitle = new System.Windows.Forms.Label();
            this.lblStatCustomers = new System.Windows.Forms.Label();
            this.lblStatRentalsTitle = new System.Windows.Forms.Label();
            this.lblStatRentals = new System.Windows.Forms.Label();
            this.lblStatActiveRentalsTitle = new System.Windows.Forms.Label();
            this.lblStatActiveRentals = new System.Windows.Forms.Label();
            this.lblStatRevenueTitle = new System.Windows.Forms.Label();
            this.lblStatRevenue = new System.Windows.Forms.Label();
            this.lblProgAvailable = new System.Windows.Forms.Label();
            this.progAvailable = new System.Windows.Forms.ProgressBar();
            this.lblProgRented = new System.Windows.Forms.Label();
            this.progRented = new System.Windows.Forms.ProgressBar();
            this.lblProgMaintenance = new System.Windows.Forms.Label();
            this.progMaintenance = new System.Windows.Forms.ProgressBar();
            this.panelReportControls = new System.Windows.Forms.Panel();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.rbCarsReport = new System.Windows.Forms.RadioButton();
            this.rbCustomersReport = new System.Windows.Forms.RadioButton();
            this.rbRentalsReport = new System.Windows.Forms.RadioButton();
            this.rbPaymentsReport = new System.Windows.Forms.RadioButton();
            this.lblLimitTitle = new System.Windows.Forms.Label();
            this.trackBarLimit = new System.Windows.Forms.TrackBar();
            this.lblLimitValue = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.panelReportView = new System.Windows.Forms.Panel();
            this.rtbReportText = new System.Windows.Forms.RichTextBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblReportInfo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelReportControls.SuspendLayout();
            this.grpReportType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLimit)).BeginInit();
            this.panelReportView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panelBottom.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "📊 التقارير والإحصائيات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.Controls.Add(this.lblStatTotalCarsTitle);
            this.panelSummary.Controls.Add(this.lblStatTotalCars);
            this.panelSummary.Controls.Add(this.lblStatAvailableTitle);
            this.panelSummary.Controls.Add(this.lblStatAvailable);
            this.panelSummary.Controls.Add(this.lblStatRentedTitle);
            this.panelSummary.Controls.Add(this.lblStatRented);
            this.panelSummary.Controls.Add(this.lblStatMaintenanceTitle);
            this.panelSummary.Controls.Add(this.lblStatMaintenance);
            this.panelSummary.Controls.Add(this.lblStatCustomersTitle);
            this.panelSummary.Controls.Add(this.lblStatCustomers);
            this.panelSummary.Controls.Add(this.lblStatRentalsTitle);
            this.panelSummary.Controls.Add(this.lblStatRentals);
            this.panelSummary.Controls.Add(this.lblStatActiveRentalsTitle);
            this.panelSummary.Controls.Add(this.lblStatActiveRentals);
            this.panelSummary.Controls.Add(this.lblStatRevenueTitle);
            this.panelSummary.Controls.Add(this.lblStatRevenue);
            this.panelSummary.Controls.Add(this.lblProgAvailable);
            this.panelSummary.Controls.Add(this.progAvailable);
            this.panelSummary.Controls.Add(this.lblProgRented);
            this.panelSummary.Controls.Add(this.progRented);
            this.panelSummary.Controls.Add(this.lblProgMaintenance);
            this.panelSummary.Controls.Add(this.progMaintenance);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Location = new System.Drawing.Point(0, 60);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelSummary.Size = new System.Drawing.Size(1200, 160);
            this.panelSummary.TabIndex = 1;
            // 
            // lblStatTotalCarsTitle
            // 
            this.lblStatTotalCarsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalCarsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTotalCarsTitle.Location = new System.Drawing.Point(900, 20);
            this.lblStatTotalCarsTitle.Name = "lblStatTotalCarsTitle";
            this.lblStatTotalCarsTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatTotalCarsTitle.TabIndex = 2;
            this.lblStatTotalCarsTitle.Text = "إجمالي السيارات:";
            this.lblStatTotalCarsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatTotalCars
            // 
            this.lblStatTotalCars.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatTotalCars.Location = new System.Drawing.Point(900, 45);
            this.lblStatTotalCars.Name = "lblStatTotalCars";
            this.lblStatTotalCars.Size = new System.Drawing.Size(150, 35);
            this.lblStatTotalCars.TabIndex = 3;
            this.lblStatTotalCars.Text = "0";
            this.lblStatTotalCars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatAvailableTitle
            // 
            this.lblStatAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatAvailableTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatAvailableTitle.Location = new System.Drawing.Point(700, 20);
            this.lblStatAvailableTitle.Name = "lblStatAvailableTitle";
            this.lblStatAvailableTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatAvailableTitle.TabIndex = 4;
            this.lblStatAvailableTitle.Text = "متاحة:";
            this.lblStatAvailableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatAvailable
            // 
            this.lblStatAvailable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatAvailable.Location = new System.Drawing.Point(700, 45);
            this.lblStatAvailable.Name = "lblStatAvailable";
            this.lblStatAvailable.Size = new System.Drawing.Size(150, 35);
            this.lblStatAvailable.TabIndex = 5;
            this.lblStatAvailable.Text = "0";
            this.lblStatAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRentedTitle
            // 
            this.lblStatRentedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatRentedTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatRentedTitle.Location = new System.Drawing.Point(500, 20);
            this.lblStatRentedTitle.Name = "lblStatRentedTitle";
            this.lblStatRentedTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatRentedTitle.TabIndex = 6;
            this.lblStatRentedTitle.Text = "مؤجرة:";
            this.lblStatRentedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRented
            // 
            this.lblStatRented.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatRented.Location = new System.Drawing.Point(500, 45);
            this.lblStatRented.Name = "lblStatRented";
            this.lblStatRented.Size = new System.Drawing.Size(150, 35);
            this.lblStatRented.TabIndex = 7;
            this.lblStatRented.Text = "0";
            this.lblStatRented.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatMaintenanceTitle
            // 
            this.lblStatMaintenanceTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatMaintenanceTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatMaintenanceTitle.Location = new System.Drawing.Point(300, 20);
            this.lblStatMaintenanceTitle.Name = "lblStatMaintenanceTitle";
            this.lblStatMaintenanceTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatMaintenanceTitle.TabIndex = 8;
            this.lblStatMaintenanceTitle.Text = "صيانة:";
            this.lblStatMaintenanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatMaintenance
            // 
            this.lblStatMaintenance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatMaintenance.Location = new System.Drawing.Point(300, 45);
            this.lblStatMaintenance.Name = "lblStatMaintenance";
            this.lblStatMaintenance.Size = new System.Drawing.Size(150, 35);
            this.lblStatMaintenance.TabIndex = 9;
            this.lblStatMaintenance.Text = "0";
            this.lblStatMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatCustomersTitle
            // 
            this.lblStatCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatCustomersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatCustomersTitle.Location = new System.Drawing.Point(900, 90);
            this.lblStatCustomersTitle.Name = "lblStatCustomersTitle";
            this.lblStatCustomersTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatCustomersTitle.TabIndex = 10;
            this.lblStatCustomersTitle.Text = "إجمالي العملاء:";
            this.lblStatCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatCustomers
            // 
            this.lblStatCustomers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatCustomers.Location = new System.Drawing.Point(900, 115);
            this.lblStatCustomers.Name = "lblStatCustomers";
            this.lblStatCustomers.Size = new System.Drawing.Size(150, 35);
            this.lblStatCustomers.TabIndex = 11;
            this.lblStatCustomers.Text = "0";
            this.lblStatCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRentalsTitle
            // 
            this.lblStatRentalsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatRentalsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatRentalsTitle.Location = new System.Drawing.Point(700, 90);
            this.lblStatRentalsTitle.Name = "lblStatRentalsTitle";
            this.lblStatRentalsTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatRentalsTitle.TabIndex = 12;
            this.lblStatRentalsTitle.Text = "إجمالي التأجير:";
            this.lblStatRentalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRentals
            // 
            this.lblStatRentals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatRentals.Location = new System.Drawing.Point(700, 115);
            this.lblStatRentals.Name = "lblStatRentals";
            this.lblStatRentals.Size = new System.Drawing.Size(150, 35);
            this.lblStatRentals.TabIndex = 13;
            this.lblStatRentals.Text = "0";
            this.lblStatRentals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatActiveRentalsTitle
            // 
            this.lblStatActiveRentalsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatActiveRentalsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatActiveRentalsTitle.Location = new System.Drawing.Point(500, 90);
            this.lblStatActiveRentalsTitle.Name = "lblStatActiveRentalsTitle";
            this.lblStatActiveRentalsTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatActiveRentalsTitle.TabIndex = 14;
            this.lblStatActiveRentalsTitle.Text = "تأجير نشط:";
            this.lblStatActiveRentalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatActiveRentals
            // 
            this.lblStatActiveRentals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatActiveRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatActiveRentals.Location = new System.Drawing.Point(500, 115);
            this.lblStatActiveRentals.Name = "lblStatActiveRentals";
            this.lblStatActiveRentals.Size = new System.Drawing.Size(150, 35);
            this.lblStatActiveRentals.TabIndex = 15;
            this.lblStatActiveRentals.Text = "0";
            this.lblStatActiveRentals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRevenueTitle
            // 
            this.lblStatRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatRevenueTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatRevenueTitle.Location = new System.Drawing.Point(300, 90);
            this.lblStatRevenueTitle.Name = "lblStatRevenueTitle";
            this.lblStatRevenueTitle.Size = new System.Drawing.Size(150, 25);
            this.lblStatRevenueTitle.TabIndex = 16;
            this.lblStatRevenueTitle.Text = "إجمالي الإيرادات:";
            this.lblStatRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatRevenue
            // 
            this.lblStatRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblStatRevenue.Location = new System.Drawing.Point(300, 115);
            this.lblStatRevenue.Name = "lblStatRevenue";
            this.lblStatRevenue.Size = new System.Drawing.Size(150, 35);
            this.lblStatRevenue.TabIndex = 17;
            this.lblStatRevenue.Text = "0";
            this.lblStatRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProgAvailable
            // 
            this.lblProgAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProgAvailable.Location = new System.Drawing.Point(180, 30);
            this.lblProgAvailable.Name = "lblProgAvailable";
            this.lblProgAvailable.Size = new System.Drawing.Size(60, 20);
            this.lblProgAvailable.TabIndex = 18;
            this.lblProgAvailable.Text = "متاحة";
            this.lblProgAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progAvailable
            // 
            this.progAvailable.ForeColor = System.Drawing.Color.Green;
            this.progAvailable.Location = new System.Drawing.Point(50, 30);
            this.progAvailable.Name = "progAvailable";
            this.progAvailable.Size = new System.Drawing.Size(120, 20);
            this.progAvailable.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progAvailable.TabIndex = 19;
            // 
            // lblProgRented
            // 
            this.lblProgRented.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProgRented.Location = new System.Drawing.Point(180, 75);
            this.lblProgRented.Name = "lblProgRented";
            this.lblProgRented.Size = new System.Drawing.Size(60, 20);
            this.lblProgRented.TabIndex = 20;
            this.lblProgRented.Text = "مؤجرة";
            this.lblProgRented.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progRented
            // 
            this.progRented.ForeColor = System.Drawing.Color.Orange;
            this.progRented.Location = new System.Drawing.Point(50, 75);
            this.progRented.Name = "progRented";
            this.progRented.Size = new System.Drawing.Size(120, 20);
            this.progRented.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progRented.TabIndex = 21;
            // 
            // lblProgMaintenance
            // 
            this.lblProgMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProgMaintenance.Location = new System.Drawing.Point(180, 120);
            this.lblProgMaintenance.Name = "lblProgMaintenance";
            this.lblProgMaintenance.Size = new System.Drawing.Size(60, 20);
            this.lblProgMaintenance.TabIndex = 22;
            this.lblProgMaintenance.Text = "صيانة";
            this.lblProgMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progMaintenance
            // 
            this.progMaintenance.ForeColor = System.Drawing.Color.Red;
            this.progMaintenance.Location = new System.Drawing.Point(50, 120);
            this.progMaintenance.Name = "progMaintenance";
            this.progMaintenance.Size = new System.Drawing.Size(120, 20);
            this.progMaintenance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progMaintenance.TabIndex = 23;
            // 
            // panelReportControls
            // 
            this.panelReportControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelReportControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReportControls.Controls.Add(this.grpReportType);
            this.panelReportControls.Controls.Add(this.lblLimitTitle);
            this.panelReportControls.Controls.Add(this.trackBarLimit);
            this.panelReportControls.Controls.Add(this.lblLimitValue);
            this.panelReportControls.Controls.Add(this.btnGenerateReport);
            this.panelReportControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReportControls.Location = new System.Drawing.Point(920, 220);
            this.panelReportControls.Name = "panelReportControls";
            this.panelReportControls.Padding = new System.Windows.Forms.Padding(15);
            this.panelReportControls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelReportControls.Size = new System.Drawing.Size(280, 490);
            this.panelReportControls.TabIndex = 2;
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.rbCarsReport);
            this.grpReportType.Controls.Add(this.rbCustomersReport);
            this.grpReportType.Controls.Add(this.rbRentalsReport);
            this.grpReportType.Controls.Add(this.rbPaymentsReport);
            this.grpReportType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReportType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpReportType.Location = new System.Drawing.Point(15, 15);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpReportType.Size = new System.Drawing.Size(248, 180);
            this.grpReportType.TabIndex = 0;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "نوع التقرير";
            // 
            // rbCarsReport
            // 
            this.rbCarsReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCarsReport.Location = new System.Drawing.Point(20, 30);
            this.rbCarsReport.Name = "rbCarsReport";
            this.rbCarsReport.Size = new System.Drawing.Size(230, 30);
            this.rbCarsReport.TabIndex = 0;
            this.rbCarsReport.Text = "🚗 تقرير السيارات";
            // 
            // rbCustomersReport
            // 
            this.rbCustomersReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCustomersReport.Location = new System.Drawing.Point(20, 65);
            this.rbCustomersReport.Name = "rbCustomersReport";
            this.rbCustomersReport.Size = new System.Drawing.Size(230, 30);
            this.rbCustomersReport.TabIndex = 1;
            this.rbCustomersReport.Text = "👥 تقرير العملاء";
            // 
            // rbRentalsReport
            // 
            this.rbRentalsReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbRentalsReport.Location = new System.Drawing.Point(20, 100);
            this.rbRentalsReport.Name = "rbRentalsReport";
            this.rbRentalsReport.Size = new System.Drawing.Size(230, 30);
            this.rbRentalsReport.TabIndex = 2;
            this.rbRentalsReport.Text = "📋 تقرير التأجير";
            // 
            // rbPaymentsReport
            // 
            this.rbPaymentsReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbPaymentsReport.Location = new System.Drawing.Point(20, 135);
            this.rbPaymentsReport.Name = "rbPaymentsReport";
            this.rbPaymentsReport.Size = new System.Drawing.Size(230, 30);
            this.rbPaymentsReport.TabIndex = 3;
            this.rbPaymentsReport.Text = "💳 تقرير المدفوعات";
            // 
            // lblLimitTitle
            // 
            this.lblLimitTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLimitTitle.Location = new System.Drawing.Point(15, 200);
            this.lblLimitTitle.Name = "lblLimitTitle";
            this.lblLimitTitle.Size = new System.Drawing.Size(250, 25);
            this.lblLimitTitle.TabIndex = 1;
            this.lblLimitTitle.Text = "عدد السجلات الأقصى:";
            this.lblLimitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarLimit
            // 
            this.trackBarLimit.Location = new System.Drawing.Point(15, 230);
            this.trackBarLimit.Maximum = 100;
            this.trackBarLimit.Minimum = 10;
            this.trackBarLimit.Name = "trackBarLimit";
            this.trackBarLimit.Size = new System.Drawing.Size(250, 45);
            this.trackBarLimit.TabIndex = 2;
            this.trackBarLimit.TickFrequency = 10;
            this.trackBarLimit.Value = 50;
            this.trackBarLimit.Scroll += new System.EventHandler(this.trackBarLimit_Scroll);
            // 
            // lblLimitValue
            // 
            this.lblLimitValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLimitValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.lblLimitValue.Location = new System.Drawing.Point(15, 275);
            this.lblLimitValue.Name = "lblLimitValue";
            this.lblLimitValue.Size = new System.Drawing.Size(250, 25);
            this.lblLimitValue.TabIndex = 3;
            this.lblLimitValue.Text = "الحد: 50";
            this.lblLimitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(15, 320);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(250, 50);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "📄 توليد التقرير";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // panelReportView
            // 
            this.panelReportView.BackColor = System.Drawing.Color.White;
            this.panelReportView.Controls.Add(this.dgvReport);
            this.panelReportView.Controls.Add(this.rtbReportText);
            this.panelReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportView.Location = new System.Drawing.Point(0, 220);
            this.panelReportView.Name = "panelReportView";
            this.panelReportView.Padding = new System.Windows.Forms.Padding(10);
            this.panelReportView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelReportView.Size = new System.Drawing.Size(920, 490);
            this.panelReportView.TabIndex = 3;
            // 
            // rtbReportText
            // 
            this.rtbReportText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rtbReportText.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbReportText.Font = new System.Drawing.Font("Consolas", 11F);
            this.rtbReportText.Location = new System.Drawing.Point(10, 10);
            this.rtbReportText.Name = "rtbReportText";
            this.rtbReportText.ReadOnly = true;
            this.rtbReportText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbReportText.Size = new System.Drawing.Size(900, 150);
            this.rtbReportText.TabIndex = 0;
            this.rtbReportText.Text = "";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvReport.Location = new System.Drawing.Point(10, 160);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(900, 320);
            this.dgvReport.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.panelBottom.Controls.Add(this.lblReportInfo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 710);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelBottom.Size = new System.Drawing.Size(1200, 40);
            this.panelBottom.TabIndex = 4;
            // 
            // lblReportInfo
            // 
            this.lblReportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblReportInfo.Location = new System.Drawing.Point(0, 0);
            this.lblReportInfo.Name = "lblReportInfo";
            this.lblReportInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblReportInfo.Size = new System.Drawing.Size(1200, 40);
            this.lblReportInfo.TabIndex = 0;
            this.lblReportInfo.Text = "اختر التقرير واضغط توليد";
            this.lblReportInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelReportView);
            this.Controls.Add(this.panelReportControls);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelTop);
            this.Name = "ReportsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - التقارير والإحصائيات";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.panelReportControls.ResumeLayout(false);
            this.grpReportType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLimit)).EndInit();
            this.panelReportView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblStatTotalCarsTitle;
        private System.Windows.Forms.Label lblStatTotalCars;
        private System.Windows.Forms.Label lblStatAvailableTitle;
        private System.Windows.Forms.Label lblStatAvailable;
        private System.Windows.Forms.Label lblStatRentedTitle;
        private System.Windows.Forms.Label lblStatRented;
        private System.Windows.Forms.Label lblStatMaintenanceTitle;
        private System.Windows.Forms.Label lblStatMaintenance;
        private System.Windows.Forms.Label lblStatCustomersTitle;
        private System.Windows.Forms.Label lblStatCustomers;
        private System.Windows.Forms.Label lblStatRentalsTitle;
        private System.Windows.Forms.Label lblStatRentals;
        private System.Windows.Forms.Label lblStatActiveRentalsTitle;
        private System.Windows.Forms.Label lblStatActiveRentals;
        private System.Windows.Forms.Label lblStatRevenueTitle;
        private System.Windows.Forms.Label lblStatRevenue;
        private System.Windows.Forms.Label lblProgAvailable;
        private System.Windows.Forms.ProgressBar progAvailable;
        private System.Windows.Forms.Label lblProgRented;
        private System.Windows.Forms.ProgressBar progRented;
        private System.Windows.Forms.Label lblProgMaintenance;
        private System.Windows.Forms.ProgressBar progMaintenance;
        private System.Windows.Forms.Panel panelReportControls;
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton rbCarsReport;
        private System.Windows.Forms.RadioButton rbCustomersReport;
        private System.Windows.Forms.RadioButton rbRentalsReport;
        private System.Windows.Forms.RadioButton rbPaymentsReport;
        private System.Windows.Forms.Label lblLimitTitle;
        private System.Windows.Forms.TrackBar trackBarLimit;
        private System.Windows.Forms.Label lblLimitValue;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel panelReportView;
        private System.Windows.Forms.RichTextBox rtbReportText;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblReportInfo;
    }
}
