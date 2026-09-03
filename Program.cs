// ============================================================
// Program.cs — نقطة بداية البرنامج
// ============================================================

using System;
using System.Windows.Forms;

namespace CarRentalSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // إعدادات التطبيق
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // تحميل البيانات التجريبية
            DataStore.LoadSampleData();

            // بدء التطبيق بواجهة تسجيل الدخول
            Application.Run(new Forms.LoginForm());
        }
    }
}
