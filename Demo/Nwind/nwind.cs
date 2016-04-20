using System;
using System.IO;
using DevExpress.Xpo;
using System.Linq;
using System.Linq.Dynamic;
using SmartData.API;
namespace nwind
{

    [Persistent("Order Details")]
    public partial class OrderDetails : SDLiteObject
    {
        OrderDetails_Key fSmartDataStrucKey;
        [Key, Persistent]
        [DevExpress.Xpo.DisplayName("Smart Data Struc Key")]
        public OrderDetails_Key SmartDataStrucKey
        {
            get { return fSmartDataStrucKey; }
            set { SetPropertyValue<OrderDetails_Key>("SmartDataStrucKey", ref fSmartDataStrucKey, value); }
        }
        float fDiscount;
        [Persistent("Discount")]
        [DevExpress.Xpo.DisplayName("Discount")]
        public float Discount
        {
            get { return fDiscount; }
            set { SetPropertyValue<float>("Discount", ref fDiscount, value); }
        }
        short fQuantity;
        [Persistent("Quantity")]
        [DevExpress.Xpo.DisplayName("Quantity")]
        public short Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<short>("Quantity", ref fQuantity, value); }
        }
        decimal fUnitPrice;
        [Persistent("UnitPrice")]
        [DevExpress.Xpo.DisplayName("Unit Price")]
        public decimal UnitPrice
        {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        public OrderDetails(Session session) : base(session) { }
        public OrderDetails() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Customers : SDLiteObject
    {
        string fAddress;
        [Size(60)]
        [Persistent("Address")]
        [DevExpress.Xpo.DisplayName("Address")]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        [Persistent("City")]
        [DevExpress.Xpo.DisplayName("City")]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCompanyName;
        [Size(40)]
        [Persistent("CompanyName")]
        [DevExpress.Xpo.DisplayName("Company Name")]
        public string CompanyName
        {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        [Persistent("ContactName")]
        [DevExpress.Xpo.DisplayName("Contact Name")]
        public string ContactName
        {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        [Size(30)]
        [Persistent("ContactTitle")]
        [DevExpress.Xpo.DisplayName("Contact Title")]
        public string ContactTitle
        {
            get { return fContactTitle; }
            set { SetPropertyValue<string>("ContactTitle", ref fContactTitle, value); }
        }
        string fCountry;
        [Size(15)]
        [Persistent("Country")]
        [DevExpress.Xpo.DisplayName("Country")]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        EmployeeCustomers fCustomerID;
        [Key]
        [Size(5)]
        [Persistent("CustomerID")]
        [Association("Customers__CustomerID__EmployeeCustomers")]
        [DevExpress.Xpo.DisplayName("Customer I D")]
        public EmployeeCustomers CustomerID
        {
            get { return fCustomerID; }
            set { SetPropertyValue<EmployeeCustomers>("CustomerID", ref fCustomerID, value); }
        }
        string fFax;
        [Size(24)]
        [Persistent("Fax")]
        [DevExpress.Xpo.DisplayName("Fax")]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fPhone;
        [Size(24)]
        [Persistent("Phone")]
        [DevExpress.Xpo.DisplayName("Phone")]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fPostalCode;
        [Size(10)]
        [Persistent("PostalCode")]
        [DevExpress.Xpo.DisplayName("Postal Code")]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        [Persistent("Region")]
        [DevExpress.Xpo.DisplayName("Region")]
        public string Region
        {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        public Customers(Session session) : base(session) { }
        public Customers() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Products : SDLiteObject
    {
        Categories fCategoryID;
        [Persistent("CategoryID")]
        [Association("Products__CategoryID__Categories")]
        [DevExpress.Xpo.DisplayName("Category I D")]
        public Categories CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>("CategoryID", ref fCategoryID, value); }
        }
        bool fDiscontinued;
        [Persistent("Discontinued")]
        [DevExpress.Xpo.DisplayName("Discontinued")]
        public bool Discontinued
        {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref fDiscontinued, value); }
        }
        string fEAN13;
        [Size(12)]
        [Persistent("EAN13")]
        [DevExpress.Xpo.DisplayName("E A N13")]
        public string EAN13
        {
            get { return fEAN13; }
            set { SetPropertyValue<string>("EAN13", ref fEAN13, value); }
        }
        int fProductID;
        [Key(true)]
        [Persistent("ProductID")]
        [DevExpress.Xpo.DisplayName("Product I D")]
        public int ProductID
        {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        [Persistent("ProductName")]
        [DevExpress.Xpo.DisplayName("Product Name")]
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        [Persistent("QuantityPerUnit")]
        [DevExpress.Xpo.DisplayName("Quantity Per Unit")]
        public string QuantityPerUnit
        {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        short fReorderLevel;
        [Persistent("ReorderLevel")]
        [DevExpress.Xpo.DisplayName("Reorder Level")]
        public short ReorderLevel
        {
            get { return fReorderLevel; }
            set { SetPropertyValue<short>("ReorderLevel", ref fReorderLevel, value); }
        }
        Suppliers fSupplierID;
        [Persistent("SupplierID")]
        [Association("Products__SupplierID__Suppliers")]
        [DevExpress.Xpo.DisplayName("Supplier I D")]
        public Suppliers SupplierID
        {
            get { return fSupplierID; }
            set { SetPropertyValue<Suppliers>("SupplierID", ref fSupplierID, value); }
        }
        decimal fUnitPrice;
        [Persistent("UnitPrice")]
        [DevExpress.Xpo.DisplayName("Unit Price")]
        public decimal UnitPrice
        {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        short fUnitsInStock;
        [Persistent("UnitsInStock")]
        [DevExpress.Xpo.DisplayName("Units In Stock")]
        public short UnitsInStock
        {
            get { return fUnitsInStock; }
            set { SetPropertyValue<short>("UnitsInStock", ref fUnitsInStock, value); }
        }
        short fUnitsOnOrder;
        [Persistent("UnitsOnOrder")]
        [DevExpress.Xpo.DisplayName("Units On Order")]
        public short UnitsOnOrder
        {
            get { return fUnitsOnOrder; }
            set { SetPropertyValue<short>("UnitsOnOrder", ref fUnitsOnOrder, value); }
        }
        public Products(Session session) : base(session) { }
        public Products() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Shippers : SDLiteObject
    {
        string fCompanyName;
        [Size(40)]
        [Persistent("CompanyName")]
        [DevExpress.Xpo.DisplayName("Company Name")]
        public string CompanyName
        {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fPhone;
        [Size(24)]
        [Persistent("Phone")]
        [DevExpress.Xpo.DisplayName("Phone")]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        int fShipperID;
        [Key(true)]
        [Persistent("ShipperID")]
        [DevExpress.Xpo.DisplayName("Shipper I D")]
        public int ShipperID
        {
            get { return fShipperID; }
            set { SetPropertyValue<int>("ShipperID", ref fShipperID, value); }
        }
        public Shippers(Session session) : base(session) { }
        public Shippers() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Orders : SDLiteObject
    {
        Customers fCustomerID;
        [Size(5)]
        [Persistent("CustomerID")]
        [Association("Orders__CustomerID__Customers")]
        [DevExpress.Xpo.DisplayName("Customer I D")]
        public Customers CustomerID
        {
            get { return fCustomerID; }
            set { SetPropertyValue<Customers>("CustomerID", ref fCustomerID, value); }
        }
        Employees fEmployeeID;
        [Persistent("EmployeeID")]
        [Association("Orders__EmployeeID__Employees")]
        [DevExpress.Xpo.DisplayName("Employee I D")]
        public Employees EmployeeID
        {
            get { return fEmployeeID; }
            set { SetPropertyValue<Employees>("EmployeeID", ref fEmployeeID, value); }
        }
        decimal fFreight;
        [Persistent("Freight")]
        [DevExpress.Xpo.DisplayName("Freight")]
        public decimal Freight
        {
            get { return fFreight; }
            set { SetPropertyValue<decimal>("Freight", ref fFreight, value); }
        }
        DateTime fOrderDate;
        [Persistent("OrderDate")]
        [DevExpress.Xpo.DisplayName("Order Date")]
        public DateTime OrderDate
        {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>("OrderDate", ref fOrderDate, value); }
        }
        int fOrderID;
        [Key(true)]
        [Persistent("OrderID")]
        [DevExpress.Xpo.DisplayName("Order I D")]
        public int OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<int>("OrderID", ref fOrderID, value); }
        }
        DateTime fRequiredDate;
        [Persistent("RequiredDate")]
        [DevExpress.Xpo.DisplayName("Required Date")]
        public DateTime RequiredDate
        {
            get { return fRequiredDate; }
            set { SetPropertyValue<DateTime>("RequiredDate", ref fRequiredDate, value); }
        }
        string fShipAddress;
        [Size(60)]
        [Persistent("ShipAddress")]
        [DevExpress.Xpo.DisplayName("Ship Address")]
        public string ShipAddress
        {
            get { return fShipAddress; }
            set { SetPropertyValue<string>("ShipAddress", ref fShipAddress, value); }
        }
        string fShipCity;
        [Size(15)]
        [Persistent("ShipCity")]
        [DevExpress.Xpo.DisplayName("Ship City")]
        public string ShipCity
        {
            get { return fShipCity; }
            set { SetPropertyValue<string>("ShipCity", ref fShipCity, value); }
        }
        string fShipCountry;
        [Size(15)]
        [Persistent("ShipCountry")]
        [DevExpress.Xpo.DisplayName("Ship Country")]
        public string ShipCountry
        {
            get { return fShipCountry; }
            set { SetPropertyValue<string>("ShipCountry", ref fShipCountry, value); }
        }
        string fShipName;
        [Size(40)]
        [Persistent("ShipName")]
        [DevExpress.Xpo.DisplayName("Ship Name")]
        public string ShipName
        {
            get { return fShipName; }
            set { SetPropertyValue<string>("ShipName", ref fShipName, value); }
        }
        DateTime fShippedDate;
        [Persistent("ShippedDate")]
        [DevExpress.Xpo.DisplayName("Shipped Date")]
        public DateTime ShippedDate
        {
            get { return fShippedDate; }
            set { SetPropertyValue<DateTime>("ShippedDate", ref fShippedDate, value); }
        }
        string fShipPostalCode;
        [Size(10)]
        [Persistent("ShipPostalCode")]
        [DevExpress.Xpo.DisplayName("Ship Postal Code")]
        public string ShipPostalCode
        {
            get { return fShipPostalCode; }
            set { SetPropertyValue<string>("ShipPostalCode", ref fShipPostalCode, value); }
        }
        string fShipRegion;
        [Size(15)]
        [Persistent("ShipRegion")]
        [DevExpress.Xpo.DisplayName("Ship Region")]
        public string ShipRegion
        {
            get { return fShipRegion; }
            set { SetPropertyValue<string>("ShipRegion", ref fShipRegion, value); }
        }
        Shippers fShipVia;
        [Persistent("ShipVia")]
        [Association("Orders__ShipVia__Shippers")]
        [DevExpress.Xpo.DisplayName("Ship Via")]
        public Shippers ShipVia
        {
            get { return fShipVia; }
            set { SetPropertyValue<Shippers>("ShipVia", ref fShipVia, value); }
        }
        public Orders(Session session) : base(session) { }
        public Orders() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Employees : SDLiteObject
    {
        string fAddress;
        [Size(60)]
        [Persistent("Address")]
        [DevExpress.Xpo.DisplayName("Address")]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        DateTime fBirthDate;
        [Persistent("BirthDate")]
        [DevExpress.Xpo.DisplayName("Birth Date")]
        public DateTime BirthDate
        {
            get { return fBirthDate; }
            set { SetPropertyValue<DateTime>("BirthDate", ref fBirthDate, value); }
        }
        string fCity;
        [Size(15)]
        [Persistent("City")]
        [DevExpress.Xpo.DisplayName("City")]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCountry;
        [Size(15)]
        [Persistent("Country")]
        [DevExpress.Xpo.DisplayName("Country")]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        int fEmployeeID;
        [Key(true)]
        [Persistent("EmployeeID")]
        [DevExpress.Xpo.DisplayName("Employee I D")]
        public int EmployeeID
        {
            get { return fEmployeeID; }
            set { SetPropertyValue<int>("EmployeeID", ref fEmployeeID, value); }
        }
        string fExtension;
        [Size(4)]
        [Persistent("Extension")]
        [DevExpress.Xpo.DisplayName("Extension")]
        public string Extension
        {
            get { return fExtension; }
            set { SetPropertyValue<string>("Extension", ref fExtension, value); }
        }
        string fFirstName;
        [Size(10)]
        [Persistent("FirstName")]
        [DevExpress.Xpo.DisplayName("First Name")]
        public string FirstName
        {
            get { return fFirstName; }
            set { SetPropertyValue<string>("FirstName", ref fFirstName, value); }
        }
        DateTime fHireDate;
        [Persistent("HireDate")]
        [DevExpress.Xpo.DisplayName("Hire Date")]
        public DateTime HireDate
        {
            get { return fHireDate; }
            set { SetPropertyValue<DateTime>("HireDate", ref fHireDate, value); }
        }
        string fHomePhone;
        [Size(24)]
        [Persistent("HomePhone")]
        [DevExpress.Xpo.DisplayName("Home Phone")]
        public string HomePhone
        {
            get { return fHomePhone; }
            set { SetPropertyValue<string>("HomePhone", ref fHomePhone, value); }
        }
        string fLastName;
        [Size(20)]
        [Persistent("LastName")]
        [DevExpress.Xpo.DisplayName("Last Name")]
        public string LastName
        {
            get { return fLastName; }
            set { SetPropertyValue<string>("LastName", ref fLastName, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Notes")]
        [DevExpress.Xpo.DisplayName("Notes")]
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>("Notes", ref fNotes, value); }
        }
        byte[] fPhoto;
        [Persistent("Photo")]
        [DevExpress.Xpo.DisplayName("Photo")]
        public byte[] Photo
        {
            get { return fPhoto; }
            set { SetPropertyValue<byte[]>("Photo", ref fPhoto, value); }
        }
        string fPostalCode;
        [Size(10)]
        [Persistent("PostalCode")]
        [DevExpress.Xpo.DisplayName("Postal Code")]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        [Persistent("Region")]
        [DevExpress.Xpo.DisplayName("Region")]
        public string Region
        {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        int fReportsTo;
        [Persistent("ReportsTo")]
        [DevExpress.Xpo.DisplayName("Reports To")]
        public int ReportsTo
        {
            get { return fReportsTo; }
            set { SetPropertyValue<int>("ReportsTo", ref fReportsTo, value); }
        }
        string fTitle;
        [Size(30)]
        [Persistent("Title")]
        [DevExpress.Xpo.DisplayName("Title")]
        public string Title
        {
            get { return fTitle; }
            set { SetPropertyValue<string>("Title", ref fTitle, value); }
        }
        string fTitleOfCourtesy;
        [Size(25)]
        [Persistent("TitleOfCourtesy")]
        [DevExpress.Xpo.DisplayName("Title Of Courtesy")]
        public string TitleOfCourtesy
        {
            get { return fTitleOfCourtesy; }
            set { SetPropertyValue<string>("TitleOfCourtesy", ref fTitleOfCourtesy, value); }
        }
        public Employees(Session session) : base(session) { }
        public Employees() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class EmployeeCustomers : SDLiteObject
    {
        string fCustomerId;
        [Key]
        [Size(5)]
        [Persistent("CustomerId")]
        [DevExpress.Xpo.DisplayName("Customer Id")]
        public string CustomerId
        {
            get { return fCustomerId; }
            set { SetPropertyValue<string>("CustomerId", ref fCustomerId, value); }
        }
        Employees fEmployeeId;
        [Persistent("EmployeeId")]
        [Association("EmployeeCustomers__EmployeeId__Employees")]
        [DevExpress.Xpo.DisplayName("Employee Id")]
        public Employees EmployeeId
        {
            get { return fEmployeeId; }
            set { SetPropertyValue<Employees>("EmployeeId", ref fEmployeeId, value); }
        }
        public EmployeeCustomers(Session session) : base(session) { }
        public EmployeeCustomers() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Suppliers : SDLiteObject
    {
        string fAddress;
        [Size(60)]
        [Persistent("Address")]
        [DevExpress.Xpo.DisplayName("Address")]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        [Persistent("City")]
        [DevExpress.Xpo.DisplayName("City")]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCompanyName;
        [Size(40)]
        [Persistent("CompanyName")]
        [DevExpress.Xpo.DisplayName("Company Name")]
        public string CompanyName
        {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        [Persistent("ContactName")]
        [DevExpress.Xpo.DisplayName("Contact Name")]
        public string ContactName
        {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        [Size(30)]
        [Persistent("ContactTitle")]
        [DevExpress.Xpo.DisplayName("Contact Title")]
        public string ContactTitle
        {
            get { return fContactTitle; }
            set { SetPropertyValue<string>("ContactTitle", ref fContactTitle, value); }
        }
        string fCountry;
        [Size(15)]
        [Persistent("Country")]
        [DevExpress.Xpo.DisplayName("Country")]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        string fFax;
        [Size(24)]
        [Persistent("Fax")]
        [DevExpress.Xpo.DisplayName("Fax")]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fHomePage;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("HomePage")]
        [DevExpress.Xpo.DisplayName("Home Page")]
        public string HomePage
        {
            get { return fHomePage; }
            set { SetPropertyValue<string>("HomePage", ref fHomePage, value); }
        }
        string fPhone;
        [Size(24)]
        [Persistent("Phone")]
        [DevExpress.Xpo.DisplayName("Phone")]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fPostalCode;
        [Size(10)]
        [Persistent("PostalCode")]
        [DevExpress.Xpo.DisplayName("Postal Code")]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        [Persistent("Region")]
        [DevExpress.Xpo.DisplayName("Region")]
        public string Region
        {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        int fSupplierID;
        [Key(true)]
        [Persistent("SupplierID")]
        [DevExpress.Xpo.DisplayName("Supplier I D")]
        public int SupplierID
        {
            get { return fSupplierID; }
            set { SetPropertyValue<int>("SupplierID", ref fSupplierID, value); }
        }
        public Suppliers(Session session) : base(session) { }
        public Suppliers() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Categories : SDLiteObject
    {
        int fCategoryID;
        [Key(true)]
        [Persistent("CategoryID")]
        [DevExpress.Xpo.DisplayName("Category I D")]
        public int CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<int>("CategoryID", ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15)]
        [Persistent("CategoryName")]
        [DevExpress.Xpo.DisplayName("Category Name")]
        public string CategoryName
        {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Description")]
        [DevExpress.Xpo.DisplayName("Description")]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        byte[] fIcon_17;
        [Persistent("Icon_17")]
        [DevExpress.Xpo.DisplayName("Icon 17")]
        public byte[] Icon_17
        {
            get { return fIcon_17; }
            set { SetPropertyValue<byte[]>("Icon_17", ref fIcon_17, value); }
        }
        byte[] fIcon_25;
        [Persistent("Icon_25")]
        [DevExpress.Xpo.DisplayName("Icon 25")]
        public byte[] Icon_25
        {
            get { return fIcon_25; }
            set { SetPropertyValue<byte[]>("Icon_25", ref fIcon_25, value); }
        }
        byte[] fPicture;
        [Persistent("Picture")]
        [DevExpress.Xpo.DisplayName("Picture")]
        public byte[] Picture
        {
            get { return fPicture; }
            set { SetPropertyValue<byte[]>("Picture", ref fPicture, value); }
        }
        public Categories(Session session) : base(session) { }
        public Categories() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public partial class Products : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Order Details")]
        [System.ComponentModel.Browsable(false)]
        [Association("OrderDetails__ProductID__Products", typeof(OrderDetails))]
        public XPCollection<OrderDetails> OrderDetails
        {
            get
            {
                return GetCollection<OrderDetails>("OrderDetails");
            }
        }
        [DevExpress.Xpo.DisplayName("Order Details")]
        [Association("OrderDetails__ProductID__Products", typeof(OrderDetails))]
        public XPQuery<OrderDetails> OrderDetails_s
        {
            get
            {
                XPQuery<OrderDetails> t = new XPQuery<OrderDetails>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "SmartDataStrucKey.ProductID ==@0", this) as XPQuery<OrderDetails>;
            }
        }
    }
    public partial class Orders : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Order Details")]
        [System.ComponentModel.Browsable(false)]
        [Association("OrderDetails__OrderID__Orders", typeof(OrderDetails))]
        public XPCollection<OrderDetails> OrderDetails
        {
            get
            {
                return GetCollection<OrderDetails>("OrderDetails");
            }
        }
        [DevExpress.Xpo.DisplayName("Order Details")]
        [Association("OrderDetails__OrderID__Orders", typeof(OrderDetails))]
        public XPQuery<OrderDetails> OrderDetails_s
        {
            get
            {
                XPQuery<OrderDetails> t = new XPQuery<OrderDetails>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "SmartDataStrucKey.OrderID ==@0", this) as XPQuery<OrderDetails>;
            }
        }
    }
    public struct OrderDetails_Key
    {
        Products fProductID;
        [Persistent("ProductID")]
        [Association("OrderDetails__ProductID__Products")]
        [DevExpress.Xpo.DisplayName("Product I D")]
        public Products ProductID
        {
            get { return fProductID; }
            set { fProductID = value; }
        }
        Orders fOrderID;
        [Persistent("OrderID")]
        [Association("OrderDetails__OrderID__Orders")]
        [DevExpress.Xpo.DisplayName("Order I D")]
        public Orders OrderID
        {
            get { return fOrderID; }
            set { fOrderID = value; }
        }
    }

    public partial class EmployeeCustomers : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Customers")]
        [System.ComponentModel.Browsable(false)]
        [Association("Customers__CustomerID__EmployeeCustomers", typeof(Customers))]
        public XPCollection<Customers> Customers
        {
            get
            {
                return GetCollection<Customers>("Customers");
            }
        }
        [DevExpress.Xpo.DisplayName("Customers")]
        [Association("Customers__CustomerID__EmployeeCustomers", typeof(Customers))]
        public XPQuery<Customers> Customers_s
        {
            get
            {
                XPQuery<Customers> t = new XPQuery<Customers>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "CustomerID ==@0", this) as XPQuery<Customers>;
            }
        }
    }
    public partial class Categories : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Products")]
        [System.ComponentModel.Browsable(false)]
        [Association("Products__CategoryID__Categories", typeof(Products))]
        public XPCollection<Products> Products
        {
            get
            {
                return GetCollection<Products>("Products");
            }
        }
        [DevExpress.Xpo.DisplayName("Products")]
        [Association("Products__CategoryID__Categories", typeof(Products))]
        public XPQuery<Products> Products_s
        {
            get
            {
                XPQuery<Products> t = new XPQuery<Products>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "CategoryID ==@0", this) as XPQuery<Products>;
            }
        }
    }
    public partial class Suppliers : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Products")]
        [System.ComponentModel.Browsable(false)]
        [Association("Products__SupplierID__Suppliers", typeof(Products))]
        public XPCollection<Products> Products
        {
            get
            {
                return GetCollection<Products>("Products");
            }
        }
        [DevExpress.Xpo.DisplayName("Products")]
        [Association("Products__SupplierID__Suppliers", typeof(Products))]
        public XPQuery<Products> Products_s
        {
            get
            {
                XPQuery<Products> t = new XPQuery<Products>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "SupplierID ==@0", this) as XPQuery<Products>;
            }
        }
    }
    public partial class Customers : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Orders")]
        [System.ComponentModel.Browsable(false)]
        [Association("Orders__CustomerID__Customers", typeof(Orders))]
        public XPCollection<Orders> Orders
        {
            get
            {
                return GetCollection<Orders>("Orders");
            }
        }
        [DevExpress.Xpo.DisplayName("Orders")]
        [Association("Orders__CustomerID__Customers", typeof(Orders))]
        public XPQuery<Orders> Orders_s
        {
            get
            {
                XPQuery<Orders> t = new XPQuery<Orders>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "CustomerID ==@0", this) as XPQuery<Orders>;
            }
        }
    }
    public partial class Employees : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Orders")]
        [System.ComponentModel.Browsable(false)]
        [Association("Orders__EmployeeID__Employees", typeof(Orders))]
        public XPCollection<Orders> Orders
        {
            get
            {
                return GetCollection<Orders>("Orders");
            }
        }
        [DevExpress.Xpo.DisplayName("Orders")]
        [Association("Orders__EmployeeID__Employees", typeof(Orders))]
        public XPQuery<Orders> Orders_s
        {
            get
            {
                XPQuery<Orders> t = new XPQuery<Orders>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "EmployeeID ==@0", this) as XPQuery<Orders>;
            }
        }
    }
    public partial class Shippers : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Orders")]
        [System.ComponentModel.Browsable(false)]
        [Association("Orders__ShipVia__Shippers", typeof(Orders))]
        public XPCollection<Orders> Orders
        {
            get
            {
                return GetCollection<Orders>("Orders");
            }
        }
        [DevExpress.Xpo.DisplayName("Orders")]
        [Association("Orders__ShipVia__Shippers", typeof(Orders))]
        public XPQuery<Orders> Orders_s
        {
            get
            {
                XPQuery<Orders> t = new XPQuery<Orders>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "ShipVia ==@0", this) as XPQuery<Orders>;
            }
        }
    }
    public partial class Employees : SDLiteObject
    {
        [DevExpress.Xpo.DisplayName("Employee Customers")]
        [System.ComponentModel.Browsable(false)]
        [Association("EmployeeCustomers__EmployeeId__Employees", typeof(EmployeeCustomers))]
        public XPCollection<EmployeeCustomers> EmployeeCustomers
        {
            get
            {
                return GetCollection<EmployeeCustomers>("EmployeeCustomers");
            }
        }
        [DevExpress.Xpo.DisplayName("Employee Customers")]
        [Association("EmployeeCustomers__EmployeeId__Employees", typeof(EmployeeCustomers))]
        public XPQuery<EmployeeCustomers> EmployeeCustomers_s
        {
            get
            {
                XPQuery<EmployeeCustomers> t = new XPQuery<EmployeeCustomers>(this.Session);
                return System.Linq.Dynamic.DynamicQueryable.Where(t, "EmployeeId ==@0", this) as XPQuery<EmployeeCustomers>;
            }
        }
    }
    public class UserSession : DevExpress.Xpo.Session
    {
        public UserSession()// I slightly modified the statements to make it robust when I copy the DLL to another PC.
        {
            string filename = GetUserDBFileName();
            if (!File.Exists(filename))
                filename = "C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\SmartData\\SmartData.Winforms\\bin\\Release\\UserData\\nwind.mdb";

            ConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;data source={0};user id=;password=;", filename);
        }
        private static UserSession defaultSession;
        public static UserSession InternalSession
        {
            get
            {
                if (defaultSession == null)
                    defaultSession = new UserSession();
                return defaultSession;
            }
        }
        private static string GetUserDBFileName()
        {
            string UserDBFileName = String.Format("{0}\\nwind.mdb", System.IO.Path.GetDirectoryName(typeof(UserSession).Assembly.Location));
            return UserDBFileName;
        }
    }


    [SmartData.API.SmartDataRoot]
    [System.Composition.Export(typeof(SmartData.API.ISmartDataRoot))]
    public class Root : DevExpress.Xpo.XPORoot, SmartData.API.ISmartDataRoot
    {
        public Type[] GetIgnoredPropertiesOfTypes()
        {
            return new Type[] { };
        }
        public XPQuery<OrderDetails> OrderDetails
        {
            get { return new XPQuery<OrderDetails>(UserSession.InternalSession); }
        }
        public XPQuery<Customers> Customers
        {
            get { return new XPQuery<Customers>(UserSession.InternalSession); }
        }
        public XPQuery<Products> Products
        {
            get { return new XPQuery<Products>(UserSession.InternalSession); }
        }
        public XPQuery<Shippers> Shippers
        {
            get { return new XPQuery<Shippers>(UserSession.InternalSession); }
        }
        public XPQuery<Orders> Orders
        {
            get { return new XPQuery<Orders>(UserSession.InternalSession); }
        }
        public XPQuery<Employees> Employees
        {
            get { return new XPQuery<Employees>(UserSession.InternalSession); }
        }
        public XPQuery<EmployeeCustomers> EmployeeCustomers
        {
            get { return new XPQuery<EmployeeCustomers>(UserSession.InternalSession); }
        }
        public XPQuery<Suppliers> Suppliers
        {
            get { return new XPQuery<Suppliers>(UserSession.InternalSession); }
        }
        public XPQuery<Categories> Categories
        {
            get { return new XPQuery<Categories>(UserSession.InternalSession); }
        }
    }

}
