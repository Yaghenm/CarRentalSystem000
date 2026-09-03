// ============================================================
// Rental.cs — كلاس عملية التأجير
// يسجل كل عملية تأجير سيارة لعميل
// ============================================================

using System;

namespace CarRentalSystem.Models
{
    public class Rental
    {
        // ---- الخصائص ----

        // رقم عملية التأجير الفريد
        public int RentalID { get; set; }

        // رقم العميل المرتبط بالتأجير
        public int CustomerID { get; set; }

        // اسم العميل (لتسهيل العرض)
        public string CustomerName { get; set; }

        // رقم السيارة المرتبطة بالتأجير
        public int CarID { get; set; }

        // معلومات السيارة (لتسهيل العرض)
        public string CarInfo { get; set; }

        // تاريخ بداية التأجير
        public DateTime RentalDate { get; set; }

        // تاريخ الإرجاع المتوقع
        public DateTime ReturnDate { get; set; }

        // عدد أيام التأجير
        public int NumberOfDays { get; set; }

        // السعر اليومي
        public decimal DailyPrice { get; set; }

        // الإجمالي = السعر اليومي × عدد الأيام
        public decimal TotalPrice { get; set; }

        // ملاحظات
        public string Notes { get; set; }

        // حالة التأجير: Active أو Returned
        public string Status { get; set; }

        // تاريخ الإرجاع الفعلي (عند إرجاع السيارة)
        public DateTime ActualReturnDate { get; set; }

        // غرامة التأخير
        public decimal LateFine { get; set; }

        // ---- Constructor ----
        public Rental()
        {
            RentalDate = DateTime.Today;
            ReturnDate = DateTime.Today.AddDays(1);
            Status = "نشط";
            Notes = "";
            LateFine = 0;
        }

        // ---- دالة ToString ----
        public override string ToString()
        {
            return $"Rental #{RentalID} - {CustomerName} - {CarInfo}";
        }
    }
}
