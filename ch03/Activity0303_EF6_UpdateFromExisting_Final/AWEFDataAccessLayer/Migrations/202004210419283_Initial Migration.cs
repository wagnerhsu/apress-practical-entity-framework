namespace AWEFDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
        //    CreateTable(
        //        "Person.Address",
        //        c => new
        //            {
        //                AddressID = c.Int(nullable: false, identity: true),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                AddressLine2 = c.String(maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceID = c.Int(nullable: false),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                SpatialLocation = c.Geography(),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.AddressID)
        //        .ForeignKey("Person.StateProvince", t => t.StateProvinceID)
        //        .Index(t => t.StateProvinceID);
            
        //    CreateTable(
        //        "Person.BusinessEntityAddress",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                AddressID = c.Int(nullable: false),
        //                AddressTypeID = c.Int(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.AddressID, t.AddressTypeID })
        //        .ForeignKey("Person.AddressType", t => t.AddressTypeID)
        //        .ForeignKey("Person.BusinessEntity", t => t.BusinessEntityID)
        //        .ForeignKey("Person.Address", t => t.AddressID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.AddressID)
        //        .Index(t => t.AddressTypeID);
            
        //    CreateTable(
        //        "Person.AddressType",
        //        c => new
        //            {
        //                AddressTypeID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.AddressTypeID);
            
        //    CreateTable(
        //        "Person.BusinessEntity",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false, identity: true),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Person.BusinessEntityContact",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                PersonID = c.Int(nullable: false),
        //                ContactTypeID = c.Int(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.PersonID, t.ContactTypeID })
        //        .ForeignKey("Person.ContactType", t => t.ContactTypeID)
        //        .ForeignKey("Person.Person", t => t.PersonID)
        //        .ForeignKey("Person.BusinessEntity", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.PersonID)
        //        .Index(t => t.ContactTypeID);
            
        //    CreateTable(
        //        "Person.ContactType",
        //        c => new
        //            {
        //                ContactTypeID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ContactTypeID);
            
        //    CreateTable(
        //        "Person.Person",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                PersonType = c.String(nullable: false, maxLength: 2, fixedLength: true),
        //                NameStyle = c.Boolean(nullable: false),
        //                Title = c.String(maxLength: 8),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                MiddleName = c.String(maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                EmailPromotion = c.Int(nullable: false),
        //                AdditionalContactInfo = c.String(storeType: "xml"),
        //                Demographics = c.String(storeType: "xml"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("Person.BusinessEntity", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Sales.Customer",
        //        c => new
        //            {
        //                CustomerID = c.Int(nullable: false, identity: true),
        //                PersonID = c.Int(),
        //                StoreID = c.Int(),
        //                TerritoryID = c.Int(),
        //                AccountNumber = c.String(nullable: false, maxLength: 10, unicode: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CustomerID)
        //        .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
        //        .ForeignKey("Sales.Store", t => t.StoreID)
        //        .ForeignKey("Person.Person", t => t.PersonID)
        //        .Index(t => t.PersonID)
        //        .Index(t => t.StoreID)
        //        .Index(t => t.TerritoryID);
            
        //    CreateTable(
        //        "Sales.SalesOrderHeader",
        //        c => new
        //            {
        //                SalesOrderID = c.Int(nullable: false, identity: true),
        //                RevisionNumber = c.Byte(nullable: false),
        //                OrderDate = c.DateTime(nullable: false),
        //                DueDate = c.DateTime(nullable: false),
        //                ShipDate = c.DateTime(),
        //                Status = c.Byte(nullable: false),
        //                OnlineOrderFlag = c.Boolean(nullable: false),
        //                SalesOrderNumber = c.String(nullable: false, maxLength: 25),
        //                PurchaseOrderNumber = c.String(maxLength: 25),
        //                AccountNumber = c.String(maxLength: 15),
        //                CustomerID = c.Int(nullable: false),
        //                SalesPersonID = c.Int(),
        //                TerritoryID = c.Int(),
        //                BillToAddressID = c.Int(nullable: false),
        //                ShipToAddressID = c.Int(nullable: false),
        //                ShipMethodID = c.Int(nullable: false),
        //                CreditCardID = c.Int(),
        //                CreditCardApprovalCode = c.String(maxLength: 15, unicode: false),
        //                CurrencyRateID = c.Int(),
        //                SubTotal = c.Decimal(nullable: false, storeType: "money"),
        //                TaxAmt = c.Decimal(nullable: false, storeType: "money"),
        //                Freight = c.Decimal(nullable: false, storeType: "money"),
        //                TotalDue = c.Decimal(nullable: false, storeType: "money"),
        //                Comment = c.String(maxLength: 128),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.SalesOrderID)
        //        .ForeignKey("Sales.CreditCard", t => t.CreditCardID)
        //        .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
        //        .ForeignKey("Purchasing.ShipMethod", t => t.ShipMethodID)
        //        .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID)
        //        .ForeignKey("Sales.CurrencyRate", t => t.CurrencyRateID)
        //        .ForeignKey("Sales.Customer", t => t.CustomerID)
        //        .ForeignKey("Person.Address", t => t.BillToAddressID)
        //        .ForeignKey("Person.Address", t => t.ShipToAddressID)
        //        .Index(t => t.CustomerID)
        //        .Index(t => t.SalesPersonID)
        //        .Index(t => t.TerritoryID)
        //        .Index(t => t.BillToAddressID)
        //        .Index(t => t.ShipToAddressID)
        //        .Index(t => t.ShipMethodID)
        //        .Index(t => t.CreditCardID)
        //        .Index(t => t.CurrencyRateID);
            
        //    CreateTable(
        //        "Sales.CreditCard",
        //        c => new
        //            {
        //                CreditCardID = c.Int(nullable: false, identity: true),
        //                CardType = c.String(nullable: false, maxLength: 50),
        //                CardNumber = c.String(nullable: false, maxLength: 25),
        //                ExpMonth = c.Byte(nullable: false),
        //                ExpYear = c.Short(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CreditCardID);
            
        //    CreateTable(
        //        "Sales.PersonCreditCard",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                CreditCardID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.CreditCardID })
        //        .ForeignKey("Sales.CreditCard", t => t.CreditCardID)
        //        .ForeignKey("Person.Person", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.CreditCardID);
            
        //    CreateTable(
        //        "Sales.CurrencyRate",
        //        c => new
        //            {
        //                CurrencyRateID = c.Int(nullable: false, identity: true),
        //                CurrencyRateDate = c.DateTime(nullable: false),
        //                FromCurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                ToCurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                AverageRate = c.Decimal(nullable: false, storeType: "money"),
        //                EndOfDayRate = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CurrencyRateID)
        //        .ForeignKey("Sales.Currency", t => t.FromCurrencyCode)
        //        .ForeignKey("Sales.Currency", t => t.ToCurrencyCode)
        //        .Index(t => t.FromCurrencyCode)
        //        .Index(t => t.ToCurrencyCode);
            
        //    CreateTable(
        //        "Sales.Currency",
        //        c => new
        //            {
        //                CurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CurrencyCode);
            
        //    CreateTable(
        //        "Sales.CountryRegionCurrency",
        //        c => new
        //            {
        //                CountryRegionCode = c.String(nullable: false, maxLength: 3),
        //                CurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.CountryRegionCode, t.CurrencyCode })
        //        .ForeignKey("Person.CountryRegion", t => t.CountryRegionCode)
        //        .ForeignKey("Sales.Currency", t => t.CurrencyCode)
        //        .Index(t => t.CountryRegionCode)
        //        .Index(t => t.CurrencyCode);
            
        //    CreateTable(
        //        "Person.CountryRegion",
        //        c => new
        //            {
        //                CountryRegionCode = c.String(nullable: false, maxLength: 3),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CountryRegionCode);
            
        //    CreateTable(
        //        "Sales.SalesTerritory",
        //        c => new
        //            {
        //                TerritoryID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                CountryRegionCode = c.String(nullable: false, maxLength: 3),
        //                Group = c.String(nullable: false, maxLength: 50),
        //                SalesYTD = c.Decimal(nullable: false, storeType: "money"),
        //                SalesLastYear = c.Decimal(nullable: false, storeType: "money"),
        //                CostYTD = c.Decimal(nullable: false, storeType: "money"),
        //                CostLastYear = c.Decimal(nullable: false, storeType: "money"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.TerritoryID)
        //        .ForeignKey("Person.CountryRegion", t => t.CountryRegionCode)
        //        .Index(t => t.CountryRegionCode);
            
        //    CreateTable(
        //        "Sales.SalesPerson",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                TerritoryID = c.Int(),
        //                SalesQuota = c.Decimal(storeType: "money"),
        //                Bonus = c.Decimal(nullable: false, storeType: "money"),
        //                CommissionPct = c.Decimal(nullable: false, storeType: "smallmoney"),
        //                SalesYTD = c.Decimal(nullable: false, storeType: "money"),
        //                SalesLastYear = c.Decimal(nullable: false, storeType: "money"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("HumanResources.Employee", t => t.BusinessEntityID)
        //        .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.TerritoryID);
            
        //    CreateTable(
        //        "HumanResources.Employee",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                NationalIDNumber = c.String(nullable: false, maxLength: 15),
        //                LoginID = c.String(nullable: false, maxLength: 256),
        //                OrganizationLevel = c.Short(),
        //                JobTitle = c.String(nullable: false, maxLength: 50),
        //                BirthDate = c.DateTime(nullable: false, storeType: "date"),
        //                MaritalStatus = c.String(nullable: false, maxLength: 1, fixedLength: true),
        //                Gender = c.String(nullable: false, maxLength: 1, fixedLength: true),
        //                HireDate = c.DateTime(nullable: false, storeType: "date"),
        //                SalariedFlag = c.Boolean(nullable: false),
        //                VacationHours = c.Short(nullable: false),
        //                SickLeaveHours = c.Short(nullable: false),
        //                CurrentFlag = c.Boolean(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("Person.Person", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "HumanResources.EmployeeDepartmentHistory",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                DepartmentID = c.Short(nullable: false),
        //                ShiftID = c.Byte(nullable: false),
        //                StartDate = c.DateTime(nullable: false, storeType: "date"),
        //                EndDate = c.DateTime(storeType: "date"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.DepartmentID, t.ShiftID, t.StartDate })
        //        .ForeignKey("HumanResources.Department", t => t.DepartmentID)
        //        .ForeignKey("HumanResources.Shift", t => t.ShiftID)
        //        .ForeignKey("HumanResources.Employee", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.DepartmentID)
        //        .Index(t => t.ShiftID);
            
        //    CreateTable(
        //        "HumanResources.Department",
        //        c => new
        //            {
        //                DepartmentID = c.Short(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                GroupName = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.DepartmentID);
            
        //    CreateTable(
        //        "HumanResources.Shift",
        //        c => new
        //            {
        //                ShiftID = c.Byte(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                StartTime = c.Time(nullable: false, precision: 7),
        //                EndTime = c.Time(nullable: false, precision: 7),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ShiftID);
            
        //    CreateTable(
        //        "HumanResources.EmployeePayHistory",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                RateChangeDate = c.DateTime(nullable: false),
        //                Rate = c.Decimal(nullable: false, storeType: "money"),
        //                PayFrequency = c.Byte(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.RateChangeDate })
        //        .ForeignKey("HumanResources.Employee", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "HumanResources.JobCandidate",
        //        c => new
        //            {
        //                JobCandidateID = c.Int(nullable: false, identity: true),
        //                BusinessEntityID = c.Int(),
        //                Resume = c.String(storeType: "xml"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.JobCandidateID)
        //        .ForeignKey("HumanResources.Employee", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Purchasing.PurchaseOrderHeader",
        //        c => new
        //            {
        //                PurchaseOrderID = c.Int(nullable: false, identity: true),
        //                RevisionNumber = c.Byte(nullable: false),
        //                Status = c.Byte(nullable: false),
        //                EmployeeID = c.Int(nullable: false),
        //                VendorID = c.Int(nullable: false),
        //                ShipMethodID = c.Int(nullable: false),
        //                OrderDate = c.DateTime(nullable: false),
        //                ShipDate = c.DateTime(),
        //                SubTotal = c.Decimal(nullable: false, storeType: "money"),
        //                TaxAmt = c.Decimal(nullable: false, storeType: "money"),
        //                Freight = c.Decimal(nullable: false, storeType: "money"),
        //                TotalDue = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.PurchaseOrderID)
        //        .ForeignKey("Purchasing.Vendor", t => t.VendorID)
        //        .ForeignKey("Purchasing.ShipMethod", t => t.ShipMethodID)
        //        .ForeignKey("HumanResources.Employee", t => t.EmployeeID)
        //        .Index(t => t.EmployeeID)
        //        .Index(t => t.VendorID)
        //        .Index(t => t.ShipMethodID);
            
        //    CreateTable(
        //        "Purchasing.PurchaseOrderDetail",
        //        c => new
        //            {
        //                PurchaseOrderID = c.Int(nullable: false),
        //                PurchaseOrderDetailID = c.Int(nullable: false),
        //                DueDate = c.DateTime(nullable: false),
        //                OrderQty = c.Short(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                UnitPrice = c.Decimal(nullable: false, storeType: "money"),
        //                LineTotal = c.Decimal(nullable: false, storeType: "money"),
        //                ReceivedQty = c.Decimal(nullable: false, precision: 8, scale: 2),
        //                RejectedQty = c.Decimal(nullable: false, precision: 8, scale: 2),
        //                StockedQty = c.Decimal(nullable: false, precision: 9, scale: 2),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.PurchaseOrderID, t.PurchaseOrderDetailID })
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .ForeignKey("Purchasing.PurchaseOrderHeader", t => t.PurchaseOrderID)
        //        .Index(t => t.PurchaseOrderID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Production.Product",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ProductNumber = c.String(nullable: false, maxLength: 25),
        //                MakeFlag = c.Boolean(nullable: false),
        //                FinishedGoodsFlag = c.Boolean(nullable: false),
        //                Color = c.String(maxLength: 15),
        //                SafetyStockLevel = c.Short(nullable: false),
        //                ReorderPoint = c.Short(nullable: false),
        //                StandardCost = c.Decimal(nullable: false, storeType: "money"),
        //                ListPrice = c.Decimal(nullable: false, storeType: "money"),
        //                Size = c.String(maxLength: 5),
        //                SizeUnitMeasureCode = c.String(maxLength: 3, fixedLength: true),
        //                WeightUnitMeasureCode = c.String(maxLength: 3, fixedLength: true),
        //                Weight = c.Decimal(precision: 8, scale: 2),
        //                DaysToManufacture = c.Int(nullable: false),
        //                ProductLine = c.String(maxLength: 2, fixedLength: true),
        //                Class = c.String(maxLength: 2, fixedLength: true),
        //                Style = c.String(maxLength: 2, fixedLength: true),
        //                ProductSubcategoryID = c.Int(),
        //                ProductModelID = c.Int(),
        //                SellStartDate = c.DateTime(nullable: false),
        //                SellEndDate = c.DateTime(),
        //                DiscontinuedDate = c.DateTime(),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductID)
        //        .ForeignKey("Production.UnitMeasure", t => t.SizeUnitMeasureCode)
        //        .ForeignKey("Production.UnitMeasure", t => t.WeightUnitMeasureCode)
        //        .ForeignKey("Production.ProductModel", t => t.ProductModelID)
        //        .ForeignKey("Production.ProductSubcategory", t => t.ProductSubcategoryID)
        //        .Index(t => t.SizeUnitMeasureCode)
        //        .Index(t => t.WeightUnitMeasureCode)
        //        .Index(t => t.ProductSubcategoryID)
        //        .Index(t => t.ProductModelID);
            
        //    CreateTable(
        //        "Production.BillOfMaterials",
        //        c => new
        //            {
        //                BillOfMaterialsID = c.Int(nullable: false, identity: true),
        //                ProductAssemblyID = c.Int(),
        //                ComponentID = c.Int(nullable: false),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(),
        //                UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                BOMLevel = c.Short(nullable: false),
        //                PerAssemblyQty = c.Decimal(nullable: false, precision: 8, scale: 2),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BillOfMaterialsID)
        //        .ForeignKey("Production.UnitMeasure", t => t.UnitMeasureCode)
        //        .ForeignKey("Production.Product", t => t.ComponentID)
        //        .ForeignKey("Production.Product", t => t.ProductAssemblyID)
        //        .Index(t => t.ProductAssemblyID)
        //        .Index(t => t.ComponentID)
        //        .Index(t => t.UnitMeasureCode);
            
        //    CreateTable(
        //        "Production.UnitMeasure",
        //        c => new
        //            {
        //                UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.UnitMeasureCode);
            
        //    CreateTable(
        //        "Purchasing.ProductVendor",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                BusinessEntityID = c.Int(nullable: false),
        //                AverageLeadTime = c.Int(nullable: false),
        //                StandardPrice = c.Decimal(nullable: false, storeType: "money"),
        //                LastReceiptCost = c.Decimal(storeType: "money"),
        //                LastReceiptDate = c.DateTime(),
        //                MinOrderQty = c.Int(nullable: false),
        //                MaxOrderQty = c.Int(nullable: false),
        //                OnOrderQty = c.Int(),
        //                UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.BusinessEntityID })
        //        .ForeignKey("Purchasing.Vendor", t => t.BusinessEntityID)
        //        .ForeignKey("Production.UnitMeasure", t => t.UnitMeasureCode)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.UnitMeasureCode);
            
        //    CreateTable(
        //        "Purchasing.Vendor",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                AccountNumber = c.String(nullable: false, maxLength: 15),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                CreditRating = c.Byte(nullable: false),
        //                PreferredVendorStatus = c.Boolean(nullable: false),
        //                ActiveFlag = c.Boolean(nullable: false),
        //                PurchasingWebServiceURL = c.String(maxLength: 1024),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("Person.BusinessEntity", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Production.ProductCostHistory",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(),
        //                StandardCost = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.StartDate })
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Production.ProductDocument",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Production.ProductInventory",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                LocationID = c.Short(nullable: false),
        //                Shelf = c.String(nullable: false, maxLength: 10),
        //                Bin = c.Byte(nullable: false),
        //                Quantity = c.Short(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.LocationID })
        //        .ForeignKey("Production.Location", t => t.LocationID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID)
        //        .Index(t => t.LocationID);
            
        //    CreateTable(
        //        "Production.Location",
        //        c => new
        //            {
        //                LocationID = c.Short(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                CostRate = c.Decimal(nullable: false, storeType: "smallmoney"),
        //                Availability = c.Decimal(nullable: false, precision: 8, scale: 2),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.LocationID);
            
        //    CreateTable(
        //        "Production.WorkOrderRouting",
        //        c => new
        //            {
        //                WorkOrderID = c.Int(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                OperationSequence = c.Short(nullable: false),
        //                LocationID = c.Short(nullable: false),
        //                ScheduledStartDate = c.DateTime(nullable: false),
        //                ScheduledEndDate = c.DateTime(nullable: false),
        //                ActualStartDate = c.DateTime(),
        //                ActualEndDate = c.DateTime(),
        //                ActualResourceHrs = c.Decimal(precision: 9, scale: 4),
        //                PlannedCost = c.Decimal(nullable: false, storeType: "money"),
        //                ActualCost = c.Decimal(storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.WorkOrderID, t.ProductID, t.OperationSequence })
        //        .ForeignKey("Production.WorkOrder", t => t.WorkOrderID)
        //        .ForeignKey("Production.Location", t => t.LocationID)
        //        .Index(t => t.WorkOrderID)
        //        .Index(t => t.LocationID);
            
        //    CreateTable(
        //        "Production.WorkOrder",
        //        c => new
        //            {
        //                WorkOrderID = c.Int(nullable: false, identity: true),
        //                ProductID = c.Int(nullable: false),
        //                OrderQty = c.Int(nullable: false),
        //                StockedQty = c.Int(nullable: false),
        //                ScrappedQty = c.Short(nullable: false),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(),
        //                DueDate = c.DateTime(nullable: false),
        //                ScrapReasonID = c.Short(),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.WorkOrderID)
        //        .ForeignKey("Production.ScrapReason", t => t.ScrapReasonID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID)
        //        .Index(t => t.ScrapReasonID);
            
        //    CreateTable(
        //        "Production.ScrapReason",
        //        c => new
        //            {
        //                ScrapReasonID = c.Short(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ScrapReasonID);
            
        //    CreateTable(
        //        "Production.ProductListPriceHistory",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(),
        //                ListPrice = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.StartDate })
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Production.ProductModel",
        //        c => new
        //            {
        //                ProductModelID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                CatalogDescription = c.String(storeType: "xml"),
        //                Instructions = c.String(storeType: "xml"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductModelID);
            
        //    CreateTable(
        //        "Production.ProductModelIllustration",
        //        c => new
        //            {
        //                ProductModelID = c.Int(nullable: false),
        //                IllustrationID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductModelID, t.IllustrationID })
        //        .ForeignKey("Production.Illustration", t => t.IllustrationID)
        //        .ForeignKey("Production.ProductModel", t => t.ProductModelID)
        //        .Index(t => t.ProductModelID)
        //        .Index(t => t.IllustrationID);
            
        //    CreateTable(
        //        "Production.Illustration",
        //        c => new
        //            {
        //                IllustrationID = c.Int(nullable: false, identity: true),
        //                Diagram = c.String(storeType: "xml"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.IllustrationID);
            
        //    CreateTable(
        //        "Production.ProductModelProductDescriptionCulture",
        //        c => new
        //            {
        //                ProductModelID = c.Int(nullable: false),
        //                ProductDescriptionID = c.Int(nullable: false),
        //                CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductModelID, t.ProductDescriptionID, t.CultureID })
        //        .ForeignKey("Production.Culture", t => t.CultureID)
        //        .ForeignKey("Production.ProductDescription", t => t.ProductDescriptionID)
        //        .ForeignKey("Production.ProductModel", t => t.ProductModelID)
        //        .Index(t => t.ProductModelID)
        //        .Index(t => t.ProductDescriptionID)
        //        .Index(t => t.CultureID);
            
        //    CreateTable(
        //        "Production.Culture",
        //        c => new
        //            {
        //                CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.CultureID);
            
        //    CreateTable(
        //        "Production.ProductDescription",
        //        c => new
        //            {
        //                ProductDescriptionID = c.Int(nullable: false, identity: true),
        //                Description = c.String(nullable: false, maxLength: 400),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductDescriptionID);
            
        //    CreateTable(
        //        "Production.ProductProductPhoto",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                ProductPhotoID = c.Int(nullable: false),
        //                Primary = c.Boolean(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.ProductPhotoID })
        //        .ForeignKey("Production.ProductPhoto", t => t.ProductPhotoID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID)
        //        .Index(t => t.ProductPhotoID);
            
        //    CreateTable(
        //        "Production.ProductPhoto",
        //        c => new
        //            {
        //                ProductPhotoID = c.Int(nullable: false, identity: true),
        //                ThumbNailPhoto = c.Binary(),
        //                ThumbnailPhotoFileName = c.String(maxLength: 50),
        //                LargePhoto = c.Binary(),
        //                LargePhotoFileName = c.String(maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductPhotoID);
            
        //    CreateTable(
        //        "Production.ProductReview",
        //        c => new
        //            {
        //                ProductReviewID = c.Int(nullable: false, identity: true),
        //                ProductID = c.Int(nullable: false),
        //                ReviewerName = c.String(nullable: false, maxLength: 50),
        //                ReviewDate = c.DateTime(nullable: false),
        //                EmailAddress = c.String(nullable: false, maxLength: 50),
        //                Rating = c.Int(nullable: false),
        //                Comments = c.String(maxLength: 3850),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductReviewID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Production.ProductSubcategory",
        //        c => new
        //            {
        //                ProductSubcategoryID = c.Int(nullable: false, identity: true),
        //                ProductCategoryID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductSubcategoryID)
        //        .ForeignKey("Production.ProductCategory", t => t.ProductCategoryID)
        //        .Index(t => t.ProductCategoryID);
            
        //    CreateTable(
        //        "Production.ProductCategory",
        //        c => new
        //            {
        //                ProductCategoryID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ProductCategoryID);
            
        //    CreateTable(
        //        "Sales.ShoppingCartItem",
        //        c => new
        //            {
        //                ShoppingCartItemID = c.Int(nullable: false, identity: true),
        //                ShoppingCartID = c.String(nullable: false, maxLength: 50),
        //                Quantity = c.Int(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                DateCreated = c.DateTime(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ShoppingCartItemID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Sales.SpecialOfferProduct",
        //        c => new
        //            {
        //                SpecialOfferID = c.Int(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.SpecialOfferID, t.ProductID })
        //        .ForeignKey("Sales.SpecialOffer", t => t.SpecialOfferID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.SpecialOfferID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Sales.SalesOrderDetail",
        //        c => new
        //            {
        //                SalesOrderID = c.Int(nullable: false),
        //                SalesOrderDetailID = c.Int(nullable: false),
        //                CarrierTrackingNumber = c.String(maxLength: 25),
        //                OrderQty = c.Short(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                SpecialOfferID = c.Int(nullable: false),
        //                UnitPrice = c.Decimal(nullable: false, storeType: "money"),
        //                UnitPriceDiscount = c.Decimal(nullable: false, storeType: "money"),
        //                LineTotal = c.Decimal(nullable: false, precision: 38, scale: 6, storeType: "numeric"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.SalesOrderID, t.SalesOrderDetailID })
        //        .ForeignKey("Sales.SalesOrderHeader", t => t.SalesOrderID, cascadeDelete: true)
        //        .ForeignKey("Sales.SpecialOfferProduct", t => new { t.SpecialOfferID, t.ProductID })
        //        .Index(t => t.SalesOrderID)
        //        .Index(t => new { t.SpecialOfferID, t.ProductID });
            
        //    CreateTable(
        //        "Sales.SpecialOffer",
        //        c => new
        //            {
        //                SpecialOfferID = c.Int(nullable: false, identity: true),
        //                Description = c.String(nullable: false, maxLength: 255),
        //                DiscountPct = c.Decimal(nullable: false, storeType: "smallmoney"),
        //                Type = c.String(nullable: false, maxLength: 50),
        //                Category = c.String(nullable: false, maxLength: 50),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(nullable: false),
        //                MinQty = c.Int(nullable: false),
        //                MaxQty = c.Int(),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.SpecialOfferID);
            
        //    CreateTable(
        //        "Production.TransactionHistory",
        //        c => new
        //            {
        //                TransactionID = c.Int(nullable: false, identity: true),
        //                ProductID = c.Int(nullable: false),
        //                ReferenceOrderID = c.Int(nullable: false),
        //                ReferenceOrderLineID = c.Int(nullable: false),
        //                TransactionDate = c.DateTime(nullable: false),
        //                TransactionType = c.String(nullable: false, maxLength: 1, fixedLength: true),
        //                Quantity = c.Int(nullable: false),
        //                ActualCost = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.TransactionID)
        //        .ForeignKey("Production.Product", t => t.ProductID)
        //        .Index(t => t.ProductID);
            
        //    CreateTable(
        //        "Purchasing.ShipMethod",
        //        c => new
        //            {
        //                ShipMethodID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ShipBase = c.Decimal(nullable: false, storeType: "money"),
        //                ShipRate = c.Decimal(nullable: false, storeType: "money"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.ShipMethodID);
            
        //    CreateTable(
        //        "Sales.SalesPersonQuotaHistory",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                QuotaDate = c.DateTime(nullable: false),
        //                SalesQuota = c.Decimal(nullable: false, storeType: "money"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.QuotaDate })
        //        .ForeignKey("Sales.SalesPerson", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Sales.SalesTerritoryHistory",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                TerritoryID = c.Int(nullable: false),
        //                StartDate = c.DateTime(nullable: false),
        //                EndDate = c.DateTime(),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.TerritoryID, t.StartDate })
        //        .ForeignKey("Sales.SalesPerson", t => t.BusinessEntityID)
        //        .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.TerritoryID);
            
        //    CreateTable(
        //        "Sales.Store",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                SalesPersonID = c.Int(),
        //                Demographics = c.String(storeType: "xml"),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID)
        //        .ForeignKey("Person.BusinessEntity", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.SalesPersonID);
            
        //    CreateTable(
        //        "Person.StateProvince",
        //        c => new
        //            {
        //                StateProvinceID = c.Int(nullable: false, identity: true),
        //                StateProvinceCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                CountryRegionCode = c.String(nullable: false, maxLength: 3),
        //                IsOnlyStateProvinceFlag = c.Boolean(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                TerritoryID = c.Int(nullable: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.StateProvinceID)
        //        .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
        //        .ForeignKey("Person.CountryRegion", t => t.CountryRegionCode)
        //        .Index(t => t.CountryRegionCode)
        //        .Index(t => t.TerritoryID);
            
        //    CreateTable(
        //        "Sales.SalesTaxRate",
        //        c => new
        //            {
        //                SalesTaxRateID = c.Int(nullable: false, identity: true),
        //                StateProvinceID = c.Int(nullable: false),
        //                TaxType = c.Byte(nullable: false),
        //                TaxRate = c.Decimal(nullable: false, storeType: "smallmoney"),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.SalesTaxRateID)
        //        .ForeignKey("Person.StateProvince", t => t.StateProvinceID)
        //        .Index(t => t.StateProvinceID);
            
        //    CreateTable(
        //        "Sales.SalesOrderHeaderSalesReason",
        //        c => new
        //            {
        //                SalesOrderID = c.Int(nullable: false),
        //                SalesReasonID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.SalesOrderID, t.SalesReasonID })
        //        .ForeignKey("Sales.SalesOrderHeader", t => t.SalesOrderID, cascadeDelete: true)
        //        .ForeignKey("Sales.SalesReason", t => t.SalesReasonID)
        //        .Index(t => t.SalesOrderID)
        //        .Index(t => t.SalesReasonID);
            
        //    CreateTable(
        //        "Sales.SalesReason",
        //        c => new
        //            {
        //                SalesReasonID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ReasonType = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.SalesReasonID);
            
        //    CreateTable(
        //        "Person.EmailAddress",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                EmailAddressID = c.Int(nullable: false),
        //                EmailAddress = c.String(maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.EmailAddressID })
        //        .ForeignKey("Person.Person", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Person.Password",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                PasswordHash = c.String(nullable: false, maxLength: 128, unicode: false),
        //                PasswordSalt = c.String(nullable: false, maxLength: 10, unicode: false),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID)
        //        .ForeignKey("Person.Person", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Person.PersonPhone",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                PhoneNumber = c.String(nullable: false, maxLength: 25),
        //                PhoneNumberTypeID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.PhoneNumber, t.PhoneNumberTypeID })
        //        .ForeignKey("Person.PhoneNumberType", t => t.PhoneNumberTypeID)
        //        .ForeignKey("Person.Person", t => t.BusinessEntityID)
        //        .Index(t => t.BusinessEntityID)
        //        .Index(t => t.PhoneNumberTypeID);
            
        //    CreateTable(
        //        "Person.PhoneNumberType",
        //        c => new
        //            {
        //                PhoneNumberTypeID = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.PhoneNumberTypeID);
            
        //    CreateTable(
        //        "dbo.AWBuildVersion",
        //        c => new
        //            {
        //                SystemInformationID = c.Byte(nullable: false, identity: true),
        //                DatabaseVersion = c.String(name: "Database Version", nullable: false, maxLength: 25),
        //                VersionDate = c.DateTime(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.SystemInformationID);
            
        //    CreateTable(
        //        "dbo.DatabaseLog",
        //        c => new
        //            {
        //                DatabaseLogID = c.Int(nullable: false, identity: true),
        //                PostTime = c.DateTime(nullable: false),
        //                DatabaseUser = c.String(nullable: false, maxLength: 128),
        //                Event = c.String(nullable: false, maxLength: 128),
        //                Schema = c.String(maxLength: 128),
        //                Object = c.String(maxLength: 128),
        //                TSQL = c.String(nullable: false),
        //                XmlEvent = c.String(nullable: false, storeType: "xml"),
        //            })
        //        .PrimaryKey(t => t.DatabaseLogID);
            
        //    CreateTable(
        //        "dbo.ErrorLog",
        //        c => new
        //            {
        //                ErrorLogID = c.Int(nullable: false, identity: true),
        //                ErrorTime = c.DateTime(nullable: false),
        //                UserName = c.String(nullable: false, maxLength: 128),
        //                ErrorNumber = c.Int(nullable: false),
        //                ErrorSeverity = c.Int(),
        //                ErrorState = c.Int(),
        //                ErrorProcedure = c.String(maxLength: 126),
        //                ErrorLine = c.Int(),
        //                ErrorMessage = c.String(nullable: false, maxLength: 4000),
        //            })
        //        .PrimaryKey(t => t.ErrorLogID);
            
        //    CreateTable(
        //        "Production.TransactionHistoryArchive",
        //        c => new
        //            {
        //                TransactionID = c.Int(nullable: false),
        //                ProductID = c.Int(nullable: false),
        //                ReferenceOrderID = c.Int(nullable: false),
        //                ReferenceOrderLineID = c.Int(nullable: false),
        //                TransactionDate = c.DateTime(nullable: false),
        //                TransactionType = c.String(nullable: false, maxLength: 1, fixedLength: true),
        //                Quantity = c.Int(nullable: false),
        //                ActualCost = c.Decimal(nullable: false, storeType: "money"),
        //                ModifiedDate = c.DateTime(nullable: false),
        //            })
        //        .PrimaryKey(t => t.TransactionID);
            
        //    CreateTable(
        //        "Person.vAdditionalContactInfo",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //                MiddleName = c.String(maxLength: 50),
        //                TelephoneNumber = c.String(maxLength: 50),
        //                TelephoneSpecialInstructions = c.String(),
        //                Street = c.String(maxLength: 50),
        //                City = c.String(maxLength: 50),
        //                StateProvince = c.String(maxLength: 50),
        //                PostalCode = c.String(maxLength: 50),
        //                CountryRegion = c.String(maxLength: 50),
        //                HomeAddressSpecialInstructions = c.String(),
        //                EMailAddress = c.String(maxLength: 128),
        //                EMailSpecialInstructions = c.String(),
        //                EMailTelephoneNumber = c.String(maxLength: 50),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.rowguid, t.ModifiedDate });
            
        //    CreateTable(
        //        "HumanResources.vEmployeeDepartmentHistory",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                Shift = c.String(nullable: false, maxLength: 50),
        //                Department = c.String(nullable: false, maxLength: 50),
        //                GroupName = c.String(nullable: false, maxLength: 50),
        //                StartDate = c.DateTime(nullable: false, storeType: "date"),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                EndDate = c.DateTime(storeType: "date"),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.Shift, t.Department, t.GroupName, t.StartDate });
            
        //    CreateTable(
        //        "HumanResources.vEmployeeDepartment",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                JobTitle = c.String(nullable: false, maxLength: 50),
        //                Department = c.String(nullable: false, maxLength: 50),
        //                GroupName = c.String(nullable: false, maxLength: 50),
        //                StartDate = c.DateTime(nullable: false, storeType: "date"),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.JobTitle, t.Department, t.GroupName, t.StartDate });
            
        //    CreateTable(
        //        "HumanResources.vEmployee",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                JobTitle = c.String(nullable: false, maxLength: 50),
        //                EmailPromotion = c.Int(nullable: false),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                PhoneNumber = c.String(maxLength: 25),
        //                PhoneNumberType = c.String(maxLength: 50),
        //                EmailAddress = c.String(maxLength: 50),
        //                AddressLine2 = c.String(maxLength: 60),
        //                AdditionalContactInfo = c.String(storeType: "xml"),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
        //    CreateTable(
        //        "Sales.vIndividualCustomer",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                EmailPromotion = c.Int(nullable: false),
        //                AddressType = c.String(nullable: false, maxLength: 50),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                PhoneNumber = c.String(maxLength: 25),
        //                PhoneNumberType = c.String(maxLength: 50),
        //                EmailAddress = c.String(maxLength: 50),
        //                AddressLine2 = c.String(maxLength: 60),
        //                Demographics = c.String(storeType: "xml"),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.EmailPromotion, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
        //    CreateTable(
        //        "HumanResources.vJobCandidateEducation",
        //        c => new
        //            {
        //                JobCandidateID = c.Int(nullable: false, identity: true),
        //                EduLevel = c.String(name: "Edu.Level"),
        //                EduStartDate = c.DateTime(name: "Edu.StartDate"),
        //                EduEndDate = c.DateTime(name: "Edu.EndDate"),
        //                EduDegree = c.String(name: "Edu.Degree", maxLength: 50),
        //                EduMajor = c.String(name: "Edu.Major", maxLength: 50),
        //                EduMinor = c.String(name: "Edu.Minor", maxLength: 50),
        //                EduGPA = c.String(name: "Edu.GPA", maxLength: 5),
        //                EduGPAScale = c.String(name: "Edu.GPAScale", maxLength: 5),
        //                EduSchool = c.String(name: "Edu.School", maxLength: 100),
        //                EduLocCountryRegion = c.String(name: "Edu.Loc.CountryRegion", maxLength: 100),
        //                EduLocState = c.String(name: "Edu.Loc.State", maxLength: 100),
        //                EduLocCity = c.String(name: "Edu.Loc.City", maxLength: 100),
        //            })
        //        .PrimaryKey(t => t.JobCandidateID);
            
        //    CreateTable(
        //        "HumanResources.vJobCandidateEmployment",
        //        c => new
        //            {
        //                JobCandidateID = c.Int(nullable: false, identity: true),
        //                EmpStartDate = c.DateTime(name: "Emp.StartDate"),
        //                EmpEndDate = c.DateTime(name: "Emp.EndDate"),
        //                EmpOrgName = c.String(name: "Emp.OrgName", maxLength: 100),
        //                EmpJobTitle = c.String(name: "Emp.JobTitle", maxLength: 100),
        //                EmpResponsibility = c.String(name: "Emp.Responsibility"),
        //                EmpFunctionCategory = c.String(name: "Emp.FunctionCategory"),
        //                EmpIndustryCategory = c.String(name: "Emp.IndustryCategory"),
        //                EmpLocCountryRegion = c.String(name: "Emp.Loc.CountryRegion"),
        //                EmpLocState = c.String(name: "Emp.Loc.State"),
        //                EmpLocCity = c.String(name: "Emp.Loc.City"),
        //            })
        //        .PrimaryKey(t => t.JobCandidateID);
            
        //    CreateTable(
        //        "HumanResources.vJobCandidate",
        //        c => new
        //            {
        //                JobCandidateID = c.Int(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //                BusinessEntityID = c.Int(),
        //                NamePrefix = c.String(name: "Name.Prefix", maxLength: 30),
        //                NameFirst = c.String(name: "Name.First", maxLength: 30),
        //                NameMiddle = c.String(name: "Name.Middle", maxLength: 30),
        //                NameLast = c.String(name: "Name.Last", maxLength: 30),
        //                NameSuffix = c.String(name: "Name.Suffix", maxLength: 30),
        //                Skills = c.String(),
        //                AddrType = c.String(name: "Addr.Type", maxLength: 30),
        //                AddrLocCountryRegion = c.String(name: "Addr.Loc.CountryRegion", maxLength: 100),
        //                AddrLocState = c.String(name: "Addr.Loc.State", maxLength: 100),
        //                AddrLocCity = c.String(name: "Addr.Loc.City", maxLength: 100),
        //                AddrPostalCode = c.String(name: "Addr.PostalCode", maxLength: 20),
        //                EMail = c.String(),
        //                WebSite = c.String(),
        //            })
        //        .PrimaryKey(t => new { t.JobCandidateID, t.ModifiedDate });
            
        //    CreateTable(
        //        "Sales.vPersonDemographics",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                TotalPurchaseYTD = c.Decimal(storeType: "money"),
        //                DateFirstPurchase = c.DateTime(),
        //                BirthDate = c.DateTime(),
        //                MaritalStatus = c.String(maxLength: 1),
        //                YearlyIncome = c.String(maxLength: 30),
        //                Gender = c.String(maxLength: 1),
        //                TotalChildren = c.Int(),
        //                NumberChildrenAtHome = c.Int(),
        //                Education = c.String(maxLength: 30),
        //                Occupation = c.String(maxLength: 30),
        //                HomeOwnerFlag = c.Boolean(),
        //                NumberCarsOwned = c.Int(),
        //            })
        //        .PrimaryKey(t => t.BusinessEntityID);
            
        //    CreateTable(
        //        "Production.vProductAndDescription",
        //        c => new
        //            {
        //                ProductID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ProductModel = c.String(nullable: false, maxLength: 50),
        //                CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
        //                Description = c.String(nullable: false, maxLength: 400),
        //            })
        //        .PrimaryKey(t => new { t.ProductID, t.Name, t.ProductModel, t.CultureID, t.Description });
            
        //    CreateTable(
        //        "Production.vProductModelCatalogDescription",
        //        c => new
        //            {
        //                ProductModelID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //                Summary = c.String(),
        //                Manufacturer = c.String(),
        //                Copyright = c.String(maxLength: 30),
        //                ProductURL = c.String(maxLength: 256),
        //                WarrantyPeriod = c.String(maxLength: 256),
        //                WarrantyDescription = c.String(maxLength: 256),
        //                NoOfYears = c.String(maxLength: 256),
        //                MaintenanceDescription = c.String(maxLength: 256),
        //                Wheel = c.String(maxLength: 256),
        //                Saddle = c.String(maxLength: 256),
        //                Pedal = c.String(maxLength: 256),
        //                BikeFrame = c.String(),
        //                Crankset = c.String(maxLength: 256),
        //                PictureAngle = c.String(maxLength: 256),
        //                PictureSize = c.String(maxLength: 256),
        //                ProductPhotoID = c.String(maxLength: 256),
        //                Material = c.String(maxLength: 256),
        //                Color = c.String(maxLength: 256),
        //                ProductLine = c.String(maxLength: 256),
        //                Style = c.String(maxLength: 256),
        //                RiderExperience = c.String(maxLength: 1024),
        //            })
        //        .PrimaryKey(t => new { t.ProductModelID, t.Name, t.rowguid, t.ModifiedDate });
            
        //    CreateTable(
        //        "Production.vProductModelInstructions",
        //        c => new
        //            {
        //                ProductModelID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                rowguid = c.Guid(nullable: false),
        //                ModifiedDate = c.DateTime(nullable: false),
        //                Instructions = c.String(),
        //                LocationID = c.Int(),
        //                SetupHours = c.Decimal(precision: 9, scale: 4),
        //                MachineHours = c.Decimal(precision: 9, scale: 4),
        //                LaborHours = c.Decimal(precision: 9, scale: 4),
        //                LotSize = c.Int(),
        //                Step = c.String(maxLength: 1024),
        //            })
        //        .PrimaryKey(t => new { t.ProductModelID, t.Name, t.rowguid, t.ModifiedDate });
            
        //    CreateTable(
        //        "Sales.vSalesPerson",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                JobTitle = c.String(nullable: false, maxLength: 50),
        //                EmailPromotion = c.Int(nullable: false),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //                SalesYTD = c.Decimal(nullable: false, storeType: "money"),
        //                SalesLastYear = c.Decimal(nullable: false, storeType: "money"),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                PhoneNumber = c.String(maxLength: 25),
        //                PhoneNumberType = c.String(maxLength: 50),
        //                EmailAddress = c.String(maxLength: 50),
        //                AddressLine2 = c.String(maxLength: 60),
        //                TerritoryName = c.String(maxLength: 50),
        //                TerritoryGroup = c.String(maxLength: 50),
        //                SalesQuota = c.Decimal(storeType: "money"),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName, t.SalesYTD, t.SalesLastYear });
            
        //    CreateTable(
        //        "Sales.vSalesPersonSalesByFiscalYears",
        //        c => new
        //            {
        //                JobTitle = c.String(nullable: false, maxLength: 50),
        //                SalesTerritory = c.String(nullable: false, maxLength: 50),
        //                SalesPersonID = c.Int(),
        //                FullName = c.String(maxLength: 152),
        //                _2002 = c.Decimal(name: "2002", storeType: "money"),
        //                _2003 = c.Decimal(name: "2003", storeType: "money"),
        //                _2004 = c.Decimal(name: "2004", storeType: "money"),
        //            })
        //        .PrimaryKey(t => new { t.JobTitle, t.SalesTerritory });
            
        //    CreateTable(
        //        "Person.vStateProvinceCountryRegion",
        //        c => new
        //            {
        //                StateProvinceID = c.Int(nullable: false),
        //                StateProvinceCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
        //                IsOnlyStateProvinceFlag = c.Boolean(nullable: false),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                TerritoryID = c.Int(nullable: false),
        //                CountryRegionCode = c.String(nullable: false, maxLength: 3),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //            })
        //        .PrimaryKey(t => new { t.StateProvinceID, t.StateProvinceCode, t.IsOnlyStateProvinceFlag, t.StateProvinceName, t.TerritoryID, t.CountryRegionCode, t.CountryRegionName });
            
        //    CreateTable(
        //        "Sales.vStoreWithAddresses",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                AddressType = c.String(nullable: false, maxLength: 50),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //                AddressLine2 = c.String(maxLength: 60),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.Name, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
        //    CreateTable(
        //        "Sales.vStoreWithContacts",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ContactType = c.String(nullable: false, maxLength: 50),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                EmailPromotion = c.Int(nullable: false),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                PhoneNumber = c.String(maxLength: 25),
        //                PhoneNumberType = c.String(maxLength: 50),
        //                EmailAddress = c.String(maxLength: 50),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.Name, t.ContactType, t.FirstName, t.LastName, t.EmailPromotion });
            
        //    CreateTable(
        //        "Sales.vStoreWithDemographics",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                AnnualSales = c.Decimal(storeType: "money"),
        //                AnnualRevenue = c.Decimal(storeType: "money"),
        //                BankName = c.String(maxLength: 50),
        //                BusinessType = c.String(maxLength: 5),
        //                YearOpened = c.Int(),
        //                Specialty = c.String(maxLength: 50),
        //                SquareFeet = c.Int(),
        //                Brands = c.String(maxLength: 30),
        //                Internet = c.String(maxLength: 30),
        //                NumberEmployees = c.Int(),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.Name });
            
        //    CreateTable(
        //        "Purchasing.vVendorWithAddresses",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                AddressType = c.String(nullable: false, maxLength: 50),
        //                AddressLine1 = c.String(nullable: false, maxLength: 60),
        //                City = c.String(nullable: false, maxLength: 30),
        //                StateProvinceName = c.String(nullable: false, maxLength: 50),
        //                PostalCode = c.String(nullable: false, maxLength: 15),
        //                CountryRegionName = c.String(nullable: false, maxLength: 50),
        //                AddressLine2 = c.String(maxLength: 60),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.Name, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
        //    CreateTable(
        //        "Purchasing.vVendorWithContacts",
        //        c => new
        //            {
        //                BusinessEntityID = c.Int(nullable: false),
        //                Name = c.String(nullable: false, maxLength: 50),
        //                ContactType = c.String(nullable: false, maxLength: 50),
        //                FirstName = c.String(nullable: false, maxLength: 50),
        //                LastName = c.String(nullable: false, maxLength: 50),
        //                EmailPromotion = c.Int(nullable: false),
        //                Title = c.String(maxLength: 8),
        //                MiddleName = c.String(maxLength: 50),
        //                Suffix = c.String(maxLength: 10),
        //                PhoneNumber = c.String(maxLength: 25),
        //                PhoneNumberType = c.String(maxLength: 50),
        //                EmailAddress = c.String(maxLength: 50),
        //            })
        //        .PrimaryKey(t => new { t.BusinessEntityID, t.Name, t.ContactType, t.FirstName, t.LastName, t.EmailPromotion });
            
        }
        
        public override void Down()
        {
            //we never want to destroy the existing data, so all code has been purposefully removed.
        }
    }
}
