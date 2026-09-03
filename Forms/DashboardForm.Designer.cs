// ============================================================
// DashboardForm.Designer.cs — تصميم الواجهة الرئيسية (عربي + RTL)
// ============================================================

namespace CarRentalSystem.Forms
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCars = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturns = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCars = new System.Windows.Forms.ToolStripButton();
            this.tsbCustomers = new System.Windows.Forms.ToolStripButton();
            this.tsbRentals = new System.Windows.Forms.ToolStripButton();
            this.tslUser = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblIcon1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblIcon2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblIcon3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblRentedCars = new System.Windows.Forms.Label();
            this.panelCard4 = new System.Windows.Forms.Panel();
            this.lblIcon4 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.panelCard5 = new System.Windows.Forms.Panel();
            this.lblIcon5 = new System.Windows.Forms.Label();
            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblActiveRentals = new System.Windows.Forms.Label();
            this.progressAvailability = new System.Windows.Forms.ProgressBar();
            this.lblProgressLabel = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelCard4.SuspendLayout();
            this.panelCard5.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuCars,
            this.menuCustomers,
            this.menuRentals,
            this.menuReturns,
            this.menuPayments,
            this.menuSearch,
            this.menuReports,
            this.menuSettings,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.ForeColor = System.Drawing.Color.White;
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(124, 32);
            this.menuHome.Text = "🏠 الرئيسية";
            this.menuHome.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // menuCars
            // 
            this.menuCars.ForeColor = System.Drawing.Color.White;
            this.menuCars.Name = "menuCars";
            this.menuCars.Size = new System.Drawing.Size(130, 32);
            this.menuCars.Text = "🚗 السيارات";
            this.menuCars.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
            // 
            // menuCustomers
            // 
            this.menuCustomers.ForeColor = System.Drawing.Color.White;
            this.menuCustomers.Name = "menuCustomers";
            this.menuCustomers.Size = new System.Drawing.Size(116, 32);
            this.menuCustomers.Text = "👥 العملاء";
            this.menuCustomers.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // menuRentals
            // 
            this.menuRentals.ForeColor = System.Drawing.Color.White;
            this.menuRentals.Name = "menuRentals";
            this.menuRentals.Size = new System.Drawing.Size(107, 32);
            this.menuRentals.Text = "📋 التأجير";
            this.menuRentals.Click += new System.EventHandler(this.rentalsToolStripMenuItem_Click);
            // 
            // menuReturns
            // 
            this.menuReturns.ForeColor = System.Drawing.Color.White;
            this.menuReturns.Name = "menuReturns";
            this.menuReturns.Size = new System.Drawing.Size(112, 32);
            this.menuReturns.Text = "🔄 الإرجاع";
            this.menuReturns.Click += new System.EventHandler(this.returnsToolStripMenuItem_Click);
            // 
            // menuPayments
            // 
            this.menuPayments.ForeColor = System.Drawing.Color.White;
            this.menuPayments.Name = "menuPayments";
            this.menuPayments.Size = new System.Drawing.Size(149, 32);
            this.menuPayments.Text = "💳 المدفوعات";
            this.menuPayments.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // menuSearch
            // 
            this.menuSearch.ForeColor = System.Drawing.Color.White;
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(109, 32);
            this.menuSearch.Text = "🔍 البحث";
            this.menuSearch.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // menuReports
            // 
            this.menuReports.ForeColor = System.Drawing.Color.White;
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(118, 32);
            this.menuReports.Text = "📊 التقارير";
            this.menuReports.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.ForeColor = System.Drawing.Color.White;
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(137, 32);
            this.menuSettings.Text = "⚙ الإعدادات";
            this.menuSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // menuExit
            // 
            this.menuExit.ForeColor = System.Drawing.Color.White;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(102, 32);
            this.menuExit.Text = "❌ خروج";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1200, 18);
            this.toolStripContainer1.ContentPanel.Visible = false;
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 36);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1200, 52);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCars,
            this.tsbCustomers,
            this.tsbRentals,
            this.tslUser,
            this.tstSearch,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1200, 34);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbCars
            // 
            this.tsbCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCars.Name = "tsbCars";
            this.tsbCars.Size = new System.Drawing.Size(111, 29);
            this.tsbCars.Text = "🚗 السيارات";
            this.tsbCars.Click += new System.EventHandler(this.tsbCars_Click);
            // 
            // tsbCustomers
            // 
            this.tsbCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCustomers.Name = "tsbCustomers";
            this.tsbCustomers.Size = new System.Drawing.Size(98, 29);
            this.tsbCustomers.Text = "👥 العملاء";
            this.tsbCustomers.Click += new System.EventHandler(this.tsbCustomers_Click);
            // 
            // tsbRentals
            // 
            this.tsbRentals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRentals.Name = "tsbRentals";
            this.tsbRentals.Size = new System.Drawing.Size(89, 29);
            this.tsbRentals.Text = "📋 التأجير";
            this.tsbRentals.Click += new System.EventHandler(this.tsbRentals_Click);
            // 
            // tslUser
            // 
            this.tslUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(86, 29);
            this.tslUser.Text = "المستخدم";
            // 
            // tstSearch
            // 
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(150, 34);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(85, 29);
            this.tsbExit.Text = "❌ خروج";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTime,
            this.sslDate,
            this.sslStatus,
            this.sslUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1200, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslTime
            // 
            this.sslTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sslTime.ForeColor = System.Drawing.Color.Yellow;
            this.sslTime.Name = "sslTime";
            this.sslTime.Size = new System.Drawing.Size(64, 25);
            this.sslTime.Text = "--:--:--";
            // 
            // sslDate
            // 
            this.sslDate.ForeColor = System.Drawing.Color.White;
            this.sslDate.Name = "sslDate";
            this.sslDate.Size = new System.Drawing.Size(82, 25);
            this.sslDate.Text = "--/--/----";
            // 
            // sslStatus
            // 
            this.sslStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(238)))), ((int)(((byte)(144)))));
            this.sslStatus.Name = "sslStatus";
            this.sslStatus.Size = new System.Drawing.Size(221, 25);
            this.sslStatus.Text = "النظام يعمل بشكل صحيح ✓";
            // 
            // sslUser
            // 
            this.sslUser.ForeColor = System.Drawing.Color.White;
            this.sslUser.Name = "sslUser";
            this.sslUser.Size = new System.Drawing.Size(145, 25);
            this.sslUser.Text = "المستخدم: admin";
            // 
            // timerDash
            // 
            this.timerDash.Interval = 1000;
            this.timerDash.Tick += new System.EventHandler(this.timerDash_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panelCard1);
            this.panelMain.Controls.Add(this.panelCard2);
            this.panelMain.Controls.Add(this.panelCard3);
            this.panelMain.Controls.Add(this.panelCard4);
            this.panelMain.Controls.Add(this.panelCard5);
            this.panelMain.Controls.Add(this.progressAvailability);
            this.panelMain.Controls.Add(this.lblProgressLabel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 188);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelMain.Size = new System.Drawing.Size(1200, 480);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panelCard1.Controls.Add(this.lblIcon1);
            this.panelCard1.Controls.Add(this.lblTitle1);
            this.panelCard1.Controls.Add(this.lblTotalCars);
            this.panelCard1.Location = new System.Drawing.Point(20, 10);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCard1.Size = new System.Drawing.Size(170, 130);
            this.panelCard1.TabIndex = 0;
            // 
            // lblIcon1
            // 
            this.lblIcon1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblIcon1.ForeColor = System.Drawing.Color.White;
            this.lblIcon1.Location = new System.Drawing.Point(120, 10);
            this.lblIcon1.Name = "lblIcon1";
            this.lblIcon1.Size = new System.Drawing.Size(45, 50);
            this.lblIcon1.TabIndex = 0;
            this.lblIcon1.Text = "🚗";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblTitle1.Location = new System.Drawing.Point(5, 15);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(110, 20);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "إجمالي السيارات";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCars
            // 
            this.lblTotalCars.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalCars.ForeColor = System.Drawing.Color.White;
            this.lblTotalCars.Location = new System.Drawing.Point(5, 38);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(155, 60);
            this.lblTotalCars.TabIndex = 2;
            this.lblTotalCars.Text = "0";
            this.lblTotalCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.panelCard2.Controls.Add(this.lblIcon2);
            this.panelCard2.Controls.Add(this.lblTitle2);
            this.panelCard2.Controls.Add(this.lblAvailableCars);
            this.panelCard2.Location = new System.Drawing.Point(220, 10);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCard2.Size = new System.Drawing.Size(170, 130);
            this.panelCard2.TabIndex = 1;
            // 
            // lblIcon2
            // 
            this.lblIcon2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblIcon2.ForeColor = System.Drawing.Color.White;
            this.lblIcon2.Location = new System.Drawing.Point(120, 10);
            this.lblIcon2.Name = "lblIcon2";
            this.lblIcon2.Size = new System.Drawing.Size(45, 50);
            this.lblIcon2.TabIndex = 0;
            this.lblIcon2.Text = "✅";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblTitle2.Location = new System.Drawing.Point(5, 15);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(110, 20);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "متاحة";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCars.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCars.Location = new System.Drawing.Point(5, 38);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(155, 60);
            this.lblAvailableCars.TabIndex = 2;
            this.lblAvailableCars.Text = "0";
            this.lblAvailableCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.panelCard3.Controls.Add(this.lblIcon3);
            this.panelCard3.Controls.Add(this.lblTitle3);
            this.panelCard3.Controls.Add(this.lblRentedCars);
            this.panelCard3.Location = new System.Drawing.Point(420, 10);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCard3.Size = new System.Drawing.Size(170, 130);
            this.panelCard3.TabIndex = 2;
            // 
            // lblIcon3
            // 
            this.lblIcon3.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblIcon3.ForeColor = System.Drawing.Color.White;
            this.lblIcon3.Location = new System.Drawing.Point(120, 10);
            this.lblIcon3.Name = "lblIcon3";
            this.lblIcon3.Size = new System.Drawing.Size(45, 50);
            this.lblIcon3.TabIndex = 0;
            this.lblIcon3.Text = "🔑";
            // 
            // lblTitle3
            // 
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblTitle3.Location = new System.Drawing.Point(5, 15);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(110, 20);
            this.lblTitle3.TabIndex = 1;
            this.lblTitle3.Text = "مؤجرة";
            this.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRentedCars
            // 
            this.lblRentedCars.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRentedCars.ForeColor = System.Drawing.Color.White;
            this.lblRentedCars.Location = new System.Drawing.Point(5, 38);
            this.lblRentedCars.Name = "lblRentedCars";
            this.lblRentedCars.Size = new System.Drawing.Size(155, 60);
            this.lblRentedCars.TabIndex = 2;
            this.lblRentedCars.Text = "0";
            this.lblRentedCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCard4
            // 
            this.panelCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelCard4.Controls.Add(this.lblIcon4);
            this.panelCard4.Controls.Add(this.lblTitle4);
            this.panelCard4.Controls.Add(this.lblTotalCustomers);
            this.panelCard4.Location = new System.Drawing.Point(620, 10);
            this.panelCard4.Name = "panelCard4";
            this.panelCard4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCard4.Size = new System.Drawing.Size(170, 130);
            this.panelCard4.TabIndex = 3;
            // 
            // lblIcon4
            // 
            this.lblIcon4.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblIcon4.ForeColor = System.Drawing.Color.White;
            this.lblIcon4.Location = new System.Drawing.Point(120, 10);
            this.lblIcon4.Name = "lblIcon4";
            this.lblIcon4.Size = new System.Drawing.Size(45, 50);
            this.lblIcon4.TabIndex = 0;
            this.lblIcon4.Text = "👥";
            // 
            // lblTitle4
            // 
            this.lblTitle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblTitle4.Location = new System.Drawing.Point(5, 15);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(110, 20);
            this.lblTitle4.TabIndex = 1;
            this.lblTitle4.Text = "العملاء";
            this.lblTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.lblTotalCustomers.Location = new System.Drawing.Point(5, 38);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(155, 60);
            this.lblTotalCustomers.TabIndex = 2;
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCard5
            // 
            this.panelCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.panelCard5.Controls.Add(this.lblIcon5);
            this.panelCard5.Controls.Add(this.lblTitle5);
            this.panelCard5.Controls.Add(this.lblActiveRentals);
            this.panelCard5.Location = new System.Drawing.Point(820, 10);
            this.panelCard5.Name = "panelCard5";
            this.panelCard5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelCard5.Size = new System.Drawing.Size(170, 130);
            this.panelCard5.TabIndex = 4;
            // 
            // lblIcon5
            // 
            this.lblIcon5.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblIcon5.ForeColor = System.Drawing.Color.White;
            this.lblIcon5.Location = new System.Drawing.Point(120, 10);
            this.lblIcon5.Name = "lblIcon5";
            this.lblIcon5.Size = new System.Drawing.Size(45, 50);
            this.lblIcon5.TabIndex = 0;
            this.lblIcon5.Text = "📋";
            // 
            // lblTitle5
            // 
            this.lblTitle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblTitle5.Location = new System.Drawing.Point(5, 15);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(110, 20);
            this.lblTitle5.TabIndex = 1;
            this.lblTitle5.Text = "تأجيرات نشطة";
            this.lblTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActiveRentals
            // 
            this.lblActiveRentals.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActiveRentals.ForeColor = System.Drawing.Color.White;
            this.lblActiveRentals.Location = new System.Drawing.Point(5, 38);
            this.lblActiveRentals.Name = "lblActiveRentals";
            this.lblActiveRentals.Size = new System.Drawing.Size(155, 60);
            this.lblActiveRentals.TabIndex = 2;
            this.lblActiveRentals.Text = "0";
            this.lblActiveRentals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressAvailability
            // 
            this.progressAvailability.Location = new System.Drawing.Point(20, 180);
            this.progressAvailability.Name = "progressAvailability";
            this.progressAvailability.Size = new System.Drawing.Size(980, 25);
            this.progressAvailability.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressAvailability.TabIndex = 5;
            // 
            // lblProgressLabel
            // 
            this.lblProgressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblProgressLabel.Location = new System.Drawing.Point(20, 155);
            this.lblProgressLabel.Name = "lblProgressLabel";
            this.lblProgressLabel.Size = new System.Drawing.Size(400, 25);
            this.lblProgressLabel.TabIndex = 6;
            this.lblProgressLabel.Text = "السيارات المتاحة: 0%";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.panelHeader.Controls.Add(this.picWelcome);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblHeaderSub);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 88);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelHeader.Size = new System.Drawing.Size(1200, 100);
            this.panelHeader.TabIndex = 2;
            // 
            // picWelcome
            // 
            this.picWelcome.BackColor = System.Drawing.Color.Transparent;
            this.picWelcome.Location = new System.Drawing.Point(20, 10);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(140, 80);
            this.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWelcome.TabIndex = 0;
            this.picWelcome.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(180, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(800, 50);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "🚗 نظام إدارة وتأجير السيارات";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(180, 62);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(800, 30);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "مرحباً بك في لوحة التحكم الرئيسية";
            this.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام تأجير السيارات - الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCard1.ResumeLayout(false);
            this.panelCard2.ResumeLayout(false);
            this.panelCard3.ResumeLayout(false);
            this.panelCard4.ResumeLayout(false);
            this.panelCard5.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCars;
        private System.Windows.Forms.ToolStripButton tsbCustomers;
        private System.Windows.Forms.ToolStripButton tsbRentals;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripLabel tslUser;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslUser;
        private System.Windows.Forms.ToolStripStatusLabel sslStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslDate;
        private System.Windows.Forms.ToolStripStatusLabel sslTime;
        private System.Windows.Forms.Timer timerDash;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.ProgressBar progressAvailability;
        private System.Windows.Forms.Label lblProgressLabel;
        private System.Windows.Forms.Panel panelCard1, panelCard2, panelCard3, panelCard4, panelCard5;
        private System.Windows.Forms.Label lblIcon1, lblTitle1;
        private System.Windows.Forms.Label lblIcon2, lblTitle2;
        private System.Windows.Forms.Label lblIcon3, lblTitle3;
        private System.Windows.Forms.Label lblIcon4, lblTitle4;
        private System.Windows.Forms.Label lblIcon5, lblTitle5;
        private System.Windows.Forms.Label lblTotalCars, lblAvailableCars, lblRentedCars, lblTotalCustomers, lblActiveRentals;
        private System.Windows.Forms.ToolStripMenuItem menuHome, menuCars, menuCustomers, menuRentals, menuReturns, menuPayments, menuSearch, menuReports, menuSettings, menuExit;
    }
}
