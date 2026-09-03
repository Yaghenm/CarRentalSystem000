// ============================================================
// Car.cs — بيانات حالات السيارة بالعربية
// ============================================================
using System;

namespace CarRentalSystem.Models
{
    public class Car
    {
        public int     CarID       { get; set; }
        public string  Brand       { get; set; }
        public string  Model       { get; set; }
        public int     Year        { get; set; }
        public string  Color       { get; set; }
        public string  PlateNumber { get; set; }
        public decimal DailyPrice  { get; set; }
        // الحالات: متاحة / مؤجرة / صيانة
        public string  Status      { get; set; }
        // الأنواع: سيدان / دفع رباعي / شاحنة
        public string  CarType     { get; set; }
        public string  ImagePath   { get; set; }

        public Car()
        {
            Status    = "متاحة";
            CarType   = "سيدان";
            Color     = "أبيض";
            ImagePath = "";
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {PlateNumber}";
        }
    }
}
