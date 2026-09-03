// ============================================================
// User.cs — كلاس المستخدم
// بيانات تسجيل الدخول
// ============================================================

namespace CarRentalSystem.Models
{
    public class User
    {
        // اسم المستخدم
        public string Username { get; set; }

        // كلمة المرور
        public string Password { get; set; }

        // الدور (Admin, Staff)
        public string Role { get; set; }

        // ---- Constructor ----
        public User(string username, string password, string role = "Admin")
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
