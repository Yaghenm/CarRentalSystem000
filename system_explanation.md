# 🚗 شرح نظام إدارة وتأجير السيارات
## Car Rental Management System

> **مخصص لمادة البرمجة المرئية — C# Windows Forms**
> بدون قاعدة بيانات — كل البيانات محفوظة في Lists داخل الذاكرة

---

## 📌 فكرة النظام بشكل عام

النظام يحاكي شركة تأجير سيارات حقيقية.
يستطيع المستخدم (الموظف) أن:

- **يضيف** سيارات وعملاء للنظام
- **يسجّل** عملية تأجير سيارة لعميل
- **يسجّل** إرجاع السيارة وحساب أي غرامات تأخير
- **يسجّل** الدفع ويولّد فاتورة
- **يبحث** عن أي سيارة أو عميل أو تأجير
- **يعرض** تقارير وإحصائيات عن النظام

---

## 🗄️ كيف يُخزَّن البيانات؟ (بدل قاعدة البيانات)

```
DataStore.cs
├── List<Car>      Cars      ← كل السيارات
├── List<Customer> Customers ← كل العملاء
├── List<Rental>   Rentals   ← كل عمليات التأجير
└── List<Payment>  Payments  ← كل المدفوعات
```

> هذا الـ `DataStore` هو **static** — يعني مشترك بين جميع الواجهات.
> أي واجهة تضيف بيانات، الواجهة الأخرى ترى نفس البيانات.

---

## 📋 الكلاسات (Models)

### 🚗 Car — كلاس السيارة
| الخاصية | النوع | المعنى |
|---------|-------|--------|
| CarID | int | رقم السيارة الفريد |
| Brand | string | الماركة (Toyota, BMW...) |
| Model | string | الموديل (Camry, X5...) |
| Year | int | سنة الصنع |
| Color | string | اللون |
| PlateNumber | string | رقم اللوحة |
| DailyPrice | decimal | السعر اليومي |
| **Status** | string | **الحالة: Available / Rented / Maintenance** |
| CarType | string | نوع السيارة: Sedan / SUV / Truck |

### 👤 Customer — كلاس العميل
| الخاصية | النوع | المعنى |
|---------|-------|--------|
| CustomerID | int | رقم العميل الفريد |
| Name | string | الاسم الكامل |
| Phone | string | رقم الهاتف |
| Address | string | العنوان |
| LicenseNumber | string | رقم رخصة القيادة |
| Gender | string | الجنس: Male / Female |
| LicenseDate | DateTime | تاريخ إصدار الرخصة |

### 📋 Rental — كلاس التأجير
| الخاصية | النوع | المعنى |
|---------|-------|--------|
| RentalID | int | رقم عملية التأجير |
| CustomerID | int | رقم العميل |
| CarID | int | رقم السيارة |
| RentalDate | DateTime | تاريخ بداية التأجير |
| ReturnDate | DateTime | تاريخ الإرجاع المتوقع |
| NumberOfDays | int | عدد الأيام |
| DailyPrice | decimal | السعر اليومي |
| TotalPrice | decimal | الإجمالي |
| **Status** | string | **Active / Returned** |
| LateFine | decimal | غرامة التأخير |

### 💳 Payment — كلاس الدفع
| الخاصية | النوع | المعنى |
|---------|-------|--------|
| PaymentID | int | رقم الدفعة |
| RentalID | int | رقم التأجير المرتبط |
| Amount | decimal | المبلغ المدفوع |
| PaymentMethod | string | طريقة الدفع: Cash / Card |
| IsPaid | bool | هل تم الدفع؟ |
| InvoiceDetails | string | نص الفاتورة الكاملة |

---

## 🖥️ شرح كل واجهة (Form)

---

### 1️⃣ LoginForm — واجهة تسجيل الدخول

**الوظيفة:**
بوابة الدخول للنظام — تتحقق من اسم المستخدم وكلمة المرور قبل السماح بالدخول.

**آلية العمل:**
```
المستخدم يكتب: admin / 1234
              ↓
البرنامج يقارن مع القيم الثابتة في الكود
              ↓
إذا صح ← يفتح DashboardForm ويخفي LoginForm
إذا خطأ ← MessageBox يعرض "Invalid Username or Password"
```

**المميزات:**
- ⏰ **Timer** يعرض الوقت الحالي ويحدّثه كل ثانية
- 👁️ **CheckBox** (Show Password) يكشف/يخفي كلمة المرور
- ⌨️ الضغط على **Enter** في حقل كلمة المرور يؤدي لتسجيل الدخول مباشرة
- 🔵 تصميم مقسّم: Panel أزرق (شعار + ساعة) | Panel أبيض (نموذج الدخول)

**بيانات الدخول:**
```
Username: admin
Password: 1234
```

---

### 2️⃣ DashboardForm — الواجهة الرئيسية

**الوظيفة:**
مركز التحكم الرئيسي في النظام — يعرض ملخصاً للنظام ويوفر التنقل بين جميع الواجهات.

**آلية العمل:**
```
بعد تسجيل الدخول ← يفتح Dashboard
Dashboard يقرأ من DataStore ويحسب:
  • عدد السيارات الإجمالي
  • عدد السيارات المتاحة
  • عدد السيارات المؤجرة
  • عدد العملاء
  • عدد التأجيرات النشطة
ويعرضها في بطاقات ملونة
```

**مكونات الواجهة:**
| المكوّن | الوظيفة |
|---------|---------|
| **MenuStrip** | قائمة التنقل: Home, Cars, Customers, Rentals, Returns, Payments, Search, Reports, Settings, Exit |
| **ToolStrip** | أزرار وصول سريع لأهم الواجهات |
| **ToolStripTextBox** | بحث سريع |
| **ToolStripLabel** | عرض اسم المستخدم الحالي |
| **StatusStrip** | شريط أسفل الشاشة: المستخدم + الحالة + التاريخ + الوقت |
| **Timer** | يحدّث الساعة في StatusStrip كل ثانية |
| **ProgressBar** | يعرض نسبة السيارات المتاحة (مثلاً 66%) |
| **5 بطاقات Panel** | كل بطاقة تعرض إحصائية بلون مختلف |

---

### 3️⃣ CarsForm — إدارة السيارات

**الوظيفة:**
إضافة وتعديل وحذف السيارات في النظام.

**آلية العمل:**

**➕ إضافة سيارة:**
```
المستخدم يملأ الحقول (ماركة، موديل، لوحة...)
         ↓
يضغط Add
         ↓
البرنامج يتحقق من الحقول (هل هي فارغة؟)
         ↓
ينشئ كائن Car جديد ويعطيه CarID تلقائي
         ↓
يضيفه: DataStore.Cars.Add(newCar)
         ↓
يحدّث DataGridView ويعرض رسالة نجاح
```

**✏️ تعديل سيارة:**
```
المستخدم يضغط على صف في DataGridView
         ↓
تُملأ الحقول ببيانات السيارة المحددة
         ↓
يعدّل البيانات ويضغط Update
         ↓
البرنامج يجد السيارة في List ويعدّل خصائصها
```

**🗑️ حذف سيارة:**
```
يختار صف ← يضغط Delete
         ↓
MessageBox: "Are you sure?" (Yes/No)
         ↓
إذا Yes: DataStore.Cars.RemoveAll(c => c.CarID == selectedCarID)
```

**المميزات الخاصة:**
- 📂 **OpenFileDialog** — اختيار صورة السيارة من الجهاز وعرضها في PictureBox
- 🎨 **ColorDialog** — اختيار لون السيارة من لوحة الألوان
- 🖱️ **ContextMenuStrip** — عند الضغط بزر الفأرة الأيمن على أي سيارة تظهر: Edit / Delete / View Details
- 📻 **RadioButtons** داخل GroupBox — Sedan / SUV / Truck

---

### 4️⃣ CustomersForm — إدارة العملاء

**الوظيفة:**
إضافة وتعديل وحذف بيانات العملاء.

**آلية العمل:**
```
إضافة عميل:
  المستخدم يكتب الاسم + الهاتف + الرخصة
            ↓
  يختار الجنس (RadioButton: Male / Female)
            ↓
  يختار تاريخ الرخصة من DateTimePicker
            ↓
  يكتب العنوان في RichTextBox
            ↓
  يضغط Add ← DataStore.Customers.Add(newCustomer)
```

**المميزات:**
- 📅 **DateTimePicker** لتاريخ إصدار رخصة القيادة
- 📝 **RichTextBox** للعنوان (يقبل نصاً طويلاً متعدد الأسطر)
- 🖱️ **ContextMenuStrip** — Edit / Delete / View Details
- 👫 RadioButtons للجنس داخل GroupBox

---

### 5️⃣ RentalForm — تأجير سيارة

**الوظيفة:**
تسجيل عملية تأجير سيارة لعميل مع حساب السعر الإجمالي.

**آلية العمل:**
```
1. المستخدم يختار العميل من ComboBox
2. يختار السيارة المتاحة من ComboBox
   (يظهر فقط السيارات حالتها = Available)
3. يحدد تاريخ التأجير والإرجاع
4. يضع عدد الأيام (NumericUpDown)
         ↓
[Calculate] يحسب:
   Total Price = Daily Price × Number of Days
         ↓
[Confirm Rental] يحفظ العملية:
   ✅ يضيف Rental جديد للـ List
   ✅ يغيّر حالة السيارة: Available → Rented
   ✅ يعرض MessageBox بتفاصيل التأجير
```

**المعادلة:**
```csharp
TotalPrice = selectedCar.DailyPrice × nudDays.Value
```

**المميزات:**
- عند اختيار السيارة يظهر سعرها اليومي تلقائياً
- عند تغيير عدد الأيام يتحدث تاريخ الإرجاع تلقائياً
- لا تظهر في القائمة إلا السيارات **المتاحة فقط**
- بعد التأجير تختفي السيارة من قائمة المتاحة

---

### 6️⃣ ReturnForm — إرجاع السيارة

**الوظيفة:**
تسجيل إرجاع سيارة وحساب غرامة التأخير إن وُجدت.

**آلية العمل:**
```
1. يختار عملية التأجير النشطة من ComboBox
   (يظهر فقط التأجيرات حالتها = Active)
2. يحدد تاريخ الإرجاع الفعلي
3. يحرك TrackBar لتقييم حالة السيارة (1-10)
   TrackBar يحدّث ProgressBar بصرياً:
     8-10 = أخضر (جيد)
     4-7  = برتقالي (متوسط)
     1-3  = أحمر (تالف)
4. يختار حالة السيارة: Good أو Damaged
         ↓
[Calculate Fine]:
   إذا تأخر ← Fine = أيام_التأخير × السعر_اليومي × 1.5
   إذا في الوقت ← Fine = $0.00
         ↓
[Return Car]:
   ✅ يغيّر حالة التأجير: Active → Returned
   ✅ إذا Good  ← السيارة تصبح: Available
   ✅ إذا Damaged ← السيارة تصبح: Maintenance
   ✅ يعرض MessageBox بتأكيد الإرجاع
```

**معادلة الغرامة:**
```csharp
int lateDays = (ActualReturnDate - ExpectedReturnDate).TotalDays;
decimal fine = lateDays × DailyPrice × 1.5;
```

**المميزات:**
- 🎚️ **TrackBar** بصري لتقييم حالة السيارة
- 📊 **ProgressBar** يتغير لونه حسب التقييم
- حساب تلقائي لأيام التأخير من الفرق بين تاريخين

---

### 7️⃣ PaymentsForm — المدفوعات والفواتير

**الوظيفة:**
تسجيل عملية الدفع وإنشاء فاتورة مفصّلة.

**آلية العمل:**
```
1. يختار عملية التأجير من ComboBox
   ← يظهر اسم العميل والمبلغ تلقائياً
2. يختار طريقة الدفع (RadioButton: Cash / Card)
3. يضع CheckBox: Paid + Print Invoice
         ↓
[Calculate] يحسب الإجمالي مع أي غرامات
         ↓
[Pay Now]:
   ✅ ينشئ كائن Payment جديد
   ✅ DataStore.Payments.Add(payment)
   ✅ يولّد الفاتورة في RichTextBox
   ✅ MessageBox: "Payment Successful"
   ✅ إذا Print Invoice = true ← يعرض الفاتورة
```

**الفاتورة تحتوي على:**
```
═══════════════════════════════
        CAR RENTAL INVOICE
═══════════════════════════════
Invoice ID  : PAY-202608301234
Date        : 30/08/2026 12:34
───────────────────────────────
Customer    : Ahmed Ali
Car         : Toyota Camry (2022)
Rental Date : 25/08/2026
Return Date : 30/08/2026
Days        : 5
Daily Price : $150.00
───────────────────────────────
Subtotal    : $750.00
Late Fine   : $0.00
TOTAL       : $750.00
───────────────────────────────
Payment     : Cash
Status      : PAID ✓
═══════════════════════════════
```

---

### 8️⃣ SearchForm — البحث

**الوظيفة:**
البحث عن أي سيارة أو عميل أو عملية تأجير.

**آلية العمل:**
```
1. المستخدم يكتب كلمة البحث في ToolStripTextBox
2. يختار نوع البحث من ComboBox: Cars / Customers / Rentals
3. يضغط Search
         ↓
البرنامج يمر على كل عنصر في الـ List:
   foreach(Car car in DataStore.Cars)
     إذا (car.Brand.Contains(query) أو
          car.Model.Contains(query) أو
          car.PlateNumber.Contains(query))
       ← أضفه للنتائج
         ↓
النتائج تظهر في:
   • DataGridView — بشكل تفصيلي
   • ListBox — قائمة سريعة
   • lblResultCount — عدد النتائج
```

**TreeView — التصنيفات الهرمية:**
```
🏢 System
├── 🚗 Cars
│   ├── ✅ Available (2)
│   ├── 🔑 Rented (1)
│   └── 🔧 Maintenance (1)
├── 👥 Customers (5)
└── 📋 Rentals
    ├── 🟢 Active (1)
    └── ✓ Returned (2)
```
عند الضغط على أي فرع يظهر البحث المقابل تلقائياً.

---

### 9️⃣ ReportsForm — التقارير والإحصائيات

**الوظيفة:**
عرض إحصائيات شاملة عن النظام وتوليد تقارير مفصّلة.

**آلية العمل:**
```
عند فتح الواجهة:
   ← يحسب جميع الإحصائيات من Lists
   ← يعرضها في 8 بطاقات ملونة
   ← يحدّث 3 ProgressBars:
      Available: ██████░░ 66%
      Rented:    ███░░░░░ 33%
      Maintenance: █░░░░░ 11%

عند اختيار نوع التقرير (RadioButton):
   Cars / Customers / Rentals / Payments
         ↓
[Generate Report]:
   يحرك TrackBar ← يحدد عدد السجلات المعروضة
         ↓
   يملأ DataGridView بالبيانات
   يكتب تقريراً نصياً في RichTextBox
```

**أنواع التقارير:**
| التقرير | ما يعرضه |
|---------|---------|
| Cars Report | جميع السيارات مع حالتها والسعر |
| Customers Report | جميع العملاء |
| Rentals Report | جميع التأجيرات والإجمالي |
| Payments Report | جميع المدفوعات والإيراد الكلي |

---

## 🔄 تدفق البيانات الكامل

```
                    ┌─────────────────────┐
                    │    DataStore.cs      │
                    │  List<Car>           │
                    │  List<Customer>      │
                    │  List<Rental>        │
                    │  List<Payment>       │
                    └─────────┬───────────┘
                              │ مشترك بين كل الواجهات
          ┌───────────────────┼───────────────────┐
          ▼                   ▼                   ▼
    ┌──────────┐       ┌──────────┐       ┌──────────┐
    │ CarsForm │       │Customers │       │  Rental  │
    │ يضيف/يحذف│       │  Form    │       │  Form    │
    │ سيارات   │       │ يضيف/يحذف│       │ يختار    │
    └──────────┘       │ عملاء    │       │ عميل +   │
                       └──────────┘       │ سيارة    │
                                          └────┬─────┘
                                               │
                                    Car.Status = "Rented"
                                               │
                                          ┌────▼─────┐
                                          │  Return  │
                                          │  Form    │
                                          │ يرجع     │
                                          │ السيارة  │
                                          └────┬─────┘
                                               │
                                    Car.Status = "Available"
                                               │
                                          ┌────▼─────┐
                                          │ Payments │
                                          │  Form    │
                                          │ يدفع     │
                                          │ يولد     │
                                          │ فاتورة   │
                                          └──────────┘
```

---

## ⭐ مميزات المشروع

### 1. لا توجد قاعدة بيانات
```csharp
// بدل SQL: نستخدم Lists
public static List<Car> Cars = new List<Car>();

// إضافة: Cars.Add(newCar)
// حذف:   Cars.RemoveAll(c => c.CarID == id)
// بحث:   Cars.Find(c => c.CarID == id)
```

### 2. تغيير حالة السيارة تلقائياً
```csharp
// عند التأجير:
selectedCar.Status = "Rented";

// عند الإرجاع بحالة جيدة:
car.Status = "Available";

// عند الإرجاع بحالة تالفة:
car.Status = "Maintenance";
```

### 3. حساب الغرامة التلقائي
```csharp
int lateDays = (actualReturn - expectedReturn).Days;
if (lateDays > 0)
    fine = lateDays × dailyPrice × 1.5;
```

### 4. توليد الفواتير
```csharp
// يكتب الفاتورة كاملة في RichTextBox
rtbInvoice.AppendText($"TOTAL: {amount:C}");
```

### 5. 31 أداة مختلفة موزّعة بشكل منطقي
كل أداة في مكانها المناسب — لا توجد أداة عشوائية.

### 6. بيانات تجريبية جاهزة
عند تشغيل البرنامج تجد:
- **3 سيارات** مضافة مسبقاً (Toyota, BMW, Ford)
- **2 عميل** مضافين مسبقاً

### 7. تصميم موحّد
جميع الواجهات تستخدم نفس:
- الألوان (أزرق داكن `#1A365D` للهيدر)
- الخط (Segoe UI)
- ترتيب الأزرار (Add, Update, Delete, Clear)

---

## 🛡️ التحقق من البيانات (Validation)

| الحالة | الرسالة |
|--------|---------|
| تسجيل دخول خاطئ | "Invalid Username or Password" |
| حقل فارغ عند الإضافة | "Please enter the car Brand!" |
| لم تحدد سيارة للتعديل | "Please select a car first!" |
| حذف مع تأكيد | "Are you sure you want to delete?" |
| سيارة مؤجرة بالفعل | "This car is no longer available!" |
| تأجير بدون اختيار عميل | "Please select a Customer!" |
| دفع بمبلغ صفر | "Please enter a valid amount!" |

---

## 💡 نقاط مهمة للشرح أمام الدكتور

1. **لماذا `static` في DataStore؟**
   > لأن الـ static يعني أن الـ List مشتركة — جميع الـ Forms تقرأ وتكتب في **نفس القائمة** بدون تمرير قيم.

2. **لماذا `List<Car>` وليس `Car[]`؟**
   > لأن List حجمها يتغير تلقائياً — يمكن Add وRemove، أما Array فحجمه ثابت.

3. **كيف تعرف RentalForm السيارات المتاحة فقط؟**
   > تمر على كل سيارة وتتحقق: `if (car.Status == "Available")`

4. **ماذا يحدث لحالة السيارة في دورة الحياة؟**
   ```
   Available → (تأجير) → Rented → (إرجاع جيد) → Available
                                 → (إرجاع تالف) → Maintenance
   ```

5. **لماذا OpenFileDialog؟**
   > لأن الأداة توفر نافذة Windows الجاهزة لتصفح الملفات بدلاً من كتابة المسار يدوياً.
