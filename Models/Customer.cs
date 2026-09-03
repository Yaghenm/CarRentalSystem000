// ============================================================
// Customer.cs — بيانات العميل
// ============================================================
using System;

namespace CarRentalSystem.Models
{
    public class Customer
    {
        public int      CustomerID    { get; set; }
        public string   Name          { get; set; }
        public string   Phone         { get; set; }
        public string   Address       { get; set; }
        public string   LicenseNumber { get; set; }
        // الجنس: ذكر / أنثى
        public string   Gender        { get; set; }
        public DateTime LicenseDate   { get; set; }
        public string   Notes         { get; set; }

        public Customer()
        {
            Gender      = "ذكر";
            LicenseDate = DateTime.Today;
            Notes       = "";
        }

        public override string ToString()
        {
            return $"{CustomerID} - {Name} ({Phone})";
        }
    }
}
