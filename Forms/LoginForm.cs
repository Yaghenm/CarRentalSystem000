// ============================================================
// LoginForm.cs — واجهة تسجيل الدخول (بالعربية)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd، d MMMM yyyy");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "يرجى إدخال اسم المستخدم وكلمة المرور!",
                    "بيانات ناقصة",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (username == "admin" && password == "1234")
            {
                DataStore.CurrentUser = username;

                MessageBox.Show(
                    $"مرحباً بك، {username}!\nتم تسجيل الدخول بنجاح.",
                    "تسجيل الدخول ناجح",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "اسم المستخدم أو كلمة المرور غير صحيحة!\nيرجى المحاولة مرة أخرى.",
                    "فشل تسجيل الدخول",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "هل تريد الخروج من النظام؟",
                "تأكيد الخروج",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
