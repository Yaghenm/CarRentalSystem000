// ============================================================
// Payment.cs — كلاس المدفوعات
// يسجل كل عملية دفع مرتبطة بعملية تأجير
// ============================================================

using System;

namespace CarRentalSystem.Models
{
    public class Payment
    {
        // ---- الخصائص ----

        // رقم الدفعة الفريد
        public int PaymentID { get; set; }

        // رقم عملية التأجير المرتبطة
        public int RentalID { get; set; }

        // اسم العميل
        public string CustomerName { get; set; }

        // المبلغ المدفوع
        public decimal Amount { get; set; }

        // طريقة الدفع: Cash أو Card
        public string PaymentMethod { get; set; }

        // تاريخ الدفع
        public DateTime PaymentDate { get; set; }

        // هل تم الدفع؟
        public bool IsPaid { get; set; }

        // هل تم طباعة الفاتورة؟
        public bool IsPrinted { get; set; }

        // تفاصيل الفاتورة (نص كامل)
        public string InvoiceDetails { get; set; }

        // ---- Constructor ----
        public Payment()
        {
            PaymentDate = DateTime.Today;
            PaymentMethod = "Cash";
            IsPaid = false;
            IsPrinted = false;
            InvoiceDetails = "";
        }

        // ---- دالة ToString ----
        public override string ToString()
        {
            return $"Payment #{PaymentID} - {CustomerName} - {Amount:C}";
        }
    }
}
