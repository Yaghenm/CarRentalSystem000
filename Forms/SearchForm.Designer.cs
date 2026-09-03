// SearchForm.Designer.cs — عربي + RTL
namespace CarRentalSystem.Forms
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel(); this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label(); this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button(); this.btnClear = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel(); this.tvCategories = new System.Windows.Forms.TreeView(); this.lblCatTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel(); this.lstFastResults = new System.Windows.Forms.ListBox(); this.lblFastResultsTitle = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView(); this.panelBottomInfo = new System.Windows.Forms.Panel(); this.lblResultCount = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout(); this.panelLeft.SuspendLayout(); this.panelRight.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit(); this.panelBottomInfo.SuspendLayout(); this.SuspendLayout();

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(26, 54, 93); this.panelTop.Dock = System.Windows.Forms.DockStyle.Top; this.panelTop.Height = 55; this.panelTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            var lT = new System.Windows.Forms.Label(); lT.Text = "🔍 البحث الشامل"; lT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); lT.ForeColor = System.Drawing.Color.White; lT.Location = new System.Drawing.Point(15, 12); lT.Size = new System.Drawing.Size(400, 35); lT.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.panelTop.Controls.Add(lT);

            this.panelSearch.BackColor = System.Drawing.Color.White; this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top; this.panelSearch.Height = 80; this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Text = "ابحث عن:"; this.lblSearch.Location = new System.Drawing.Point(20, 25); this.lblSearch.Size = new System.Drawing.Size(80, 25); this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSearch.Location = new System.Drawing.Point(110, 25); this.txtSearch.Size = new System.Drawing.Size(350, 30); this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbSearchType.Location = new System.Drawing.Point(480, 25); this.cmbSearchType.Size = new System.Drawing.Size(180, 30); this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 11F); this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnSearch.Text = "🔍 بحث"; this.btnSearch.Location = new System.Drawing.Point(680, 24); this.btnSearch.Size = new System.Drawing.Size(120, 32); this.btnSearch.BackColor = System.Drawing.Color.FromArgb(26, 54, 93); this.btnSearch.ForeColor = System.Drawing.Color.White; this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSearch.FlatAppearance.BorderSize = 0; this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSearch.Click += new System.EventHandler(btnSearch_Click);
            this.btnClear.Text = "🗙 تفريغ"; this.btnClear.Location = new System.Drawing.Point(810, 24); this.btnClear.Size = new System.Drawing.Size(120, 32); this.btnClear.BackColor = System.Drawing.Color.FromArgb(96, 125, 139); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClear.FlatAppearance.BorderSize = 0; this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand; this.btnClear.Click += new System.EventHandler(btnClear_Click);
            this.panelSearch.Controls.AddRange(new System.Windows.Forms.Control[] { lblSearch, txtSearch, cmbSearchType, btnSearch, btnClear });

            this.panelLeft.BackColor = System.Drawing.Color.White; this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right; this.panelLeft.Width = 250; this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelLeft.Padding = new System.Windows.Forms.Padding(10); this.panelLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCatTitle.Text = "📂 التصنيفات"; this.lblCatTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblCatTitle.Height = 30; this.lblCatTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblCatTitle.ForeColor = System.Drawing.Color.FromArgb(26, 54, 93); this.lblCatTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tvCategories.Dock = System.Windows.Forms.DockStyle.Fill; this.tvCategories.Font = new System.Drawing.Font("Segoe UI", 10F); this.tvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None; this.tvCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.tvCategories.RightToLeftLayout = true; this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(tvCategories_AfterSelect);
            this.panelLeft.Controls.Add(this.tvCategories); this.panelLeft.Controls.Add(this.lblCatTitle);

            this.panelRight.BackColor = System.Drawing.Color.White; this.panelRight.Dock = System.Windows.Forms.DockStyle.Left; this.panelRight.Width = 250; this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelRight.Padding = new System.Windows.Forms.Padding(10); this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFastResultsTitle.Text = "⚡ نتائج سريعة"; this.lblFastResultsTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblFastResultsTitle.Height = 30; this.lblFastResultsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblFastResultsTitle.ForeColor = System.Drawing.Color.FromArgb(26, 54, 93); this.lblFastResultsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lstFastResults.Dock = System.Windows.Forms.DockStyle.Fill; this.lstFastResults.Font = new System.Drawing.Font("Segoe UI", 10F); this.lstFastResults.BorderStyle = System.Windows.Forms.BorderStyle.None; this.lstFastResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Controls.Add(this.lstFastResults); this.panelRight.Controls.Add(this.lblFastResultsTitle);

            this.panelBottomInfo.BackColor = System.Drawing.Color.FromArgb(240, 244, 250); this.panelBottomInfo.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelBottomInfo.Height = 40; this.panelBottomInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultCount.Text = "لم يتم العثور على نتائج"; this.lblResultCount.Dock = System.Windows.Forms.DockStyle.Fill; this.lblResultCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblResultCount.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60); this.lblResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblResultCount.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelBottomInfo.Controls.Add(this.lblResultCount);

            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvResults.AllowUserToAddRows = false; this.dgvResults.ReadOnly = true; this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252); this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvResults.RowHeadersVisible = false; this.dgvResults.Font = new System.Drawing.Font("Segoe UI", 10F); this.dgvResults.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 54, 93); this.dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; this.dgvResults.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.dgvResults.EnableHeadersVisualStyles = false; this.dgvResults.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255); this.dgvResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            this.Text = "نظام تأجير السيارات - البحث"; this.Size = new System.Drawing.Size(1000, 600); this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.FromArgb(240, 244, 250); this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.RightToLeftLayout = true;
            this.Controls.Add(this.dgvResults); this.Controls.Add(this.panelLeft); this.Controls.Add(this.panelRight); this.Controls.Add(this.panelBottomInfo); this.Controls.Add(this.panelSearch); this.Controls.Add(this.panelTop);
            this.Load += new System.EventHandler(SearchForm_Load);

            this.panelSearch.ResumeLayout(false); this.panelSearch.PerformLayout(); this.panelLeft.ResumeLayout(false); this.panelRight.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit(); this.panelBottomInfo.ResumeLayout(false); this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop, panelSearch, panelLeft, panelRight, panelBottomInfo;
        private System.Windows.Forms.Label lblSearch, lblCatTitle, lblFastResultsTitle, lblResultCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnSearch, btnClear;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.ListBox lstFastResults;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}
