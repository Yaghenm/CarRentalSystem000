// ============================================================
// DataStore.cs — المخزن المشترك للبيانات (بيانات تجريبية عربية)
// ============================================================

using System.Collections.Generic;
using CarRentalSystem.Models;

namespace CarRentalSystem
{
    public static class DataStore
    {
        public static List<Car>      Cars      = new List<Car>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Rental>   Rentals   = new List<Rental>();
        public static List<Payment>  Payments  = new List<Payment>();

        public static string CurrentUser = "";

        private static int _carIdCounter      = 1;
        private static int _customerIdCounter = 1;
        private static int _rentalIdCounter   = 1;
        private static int _paymentIdCounter  = 1;

        public static int GetNextCarID()      { return _carIdCounter++; }
        public static int GetNextCustomerID() { return _customerIdCounter++; }
        public static int GetNextRentalID()   { return _rentalIdCounter++; }
        public static int GetNextPaymentID()  { return _paymentIdCounter++; }

        public static void LoadSampleData()
        {
            // --- سيارات تجريبية ---
            Cars.Add(new Car
            {
                CarID       = GetNextCarID(),
                Brand       = "تويوتا",
                Model       = "كامري",
                Year        = 2022,
                Color       = "أبيض",
                PlateNumber = "أ ب ج - 1234",
                DailyPrice  = 150,
                Status      = "متاحة",
                CarType     = "سيدان"
            });

            Cars.Add(new Car
            {
                CarID       = GetNextCarID(),
                Brand       = "BMW",
                Model       = "X5",
                Year        = 2023,
                Color       = "أسود",
                PlateNumber = "د هـ و - 5678",
                DailyPrice  = 300,
                Status      = "متاحة",
                CarType     = "دفع رباعي"
            });

            Cars.Add(new Car
            {
                CarID       = GetNextCarID(),
                Brand       = "فورد",
                Model       = "F-150",
                Year        = 2021,
                Color       = "أحمر",
                PlateNumber = "ز ح ط - 9999",
                DailyPrice  = 200,
                Status      = "صيانة",
                CarType     = "شاحنة"
            });

            // --- عملاء تجريبيون ---
            Customers.Add(new Customer
            {
                CustomerID    = GetNextCustomerID(),
                Name          = "أحمد علي",
                Phone         = "0501234567",
                Address       = "الرياض، المملكة العربية السعودية",
                LicenseNumber = "ر-001",
                Gender        = "ذكر"
            });

            Customers.Add(new Customer
            {
                CustomerID    = GetNextCustomerID(),
                Name          = "سارة محمد",
                Phone         = "0559876543",
                Address       = "جدة، المملكة العربية السعودية",
                LicenseNumber = "ر-002",
                Gender        = "أنثى"
            });
        }
    }
}
