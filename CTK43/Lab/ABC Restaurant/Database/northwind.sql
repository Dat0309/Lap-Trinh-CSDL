create database NorthwindCompany

create table Categories
(
CatID int identity(1,1) primary key,
CatName nvarchar(250),
Description nvarchar(MAX),
Picture nvarchar(250)
)

create table Suppliers
(
SupplierID int identity(1,1) primary key,
CompanyName nvarchar(250),
ContactName nvarchar(250),
Address nvarchar(250),
City nvarchar(250),
Region nvarchar(250),
PostalCode nvarchar(250),
Country nvarchar(250),
Phone nvarchar(250),
Fax nvarchar(250),
HomePage nvarchar(250)
)

create table Products
(
ProductID int identity(1,1) primary key,
ProductName nvarchar(250),
SupplierID int references Suppliers(SupplierID),
CategoryID int references Categories(CatID),
QuantityPerUnit int,
UnitPrice nvarchar(250),
UnitsInStock nvarchar(250),
UnitsOnOrder nvarchar(250),
ReorderLevel int,
Discontinued bit not null
)

create table Region
(
RegionID int identity(1,1) primary key,
Description nvarchar(MAX)
)

create table Territories
(
TerritoryID int identity(1,1) primary key,
Description nvarchar(MAX),
RegionID int references Region(RegionID)
)

create table EmployeeTerritories
(
EmployeeID int references Employees(EmployeeID),
TerritoryID int references Territories(TerritoryID),
primary key(EmployeeID, TerritoryID)
)

create table Employees
(
EmployeeID int identity(1,1) primary key,
LastName nvarchar(50),
FirstName nvarchar(100),
Title nvarchar(250),
BirthDay smalldatetime,
Address nvarchar(MAX),
City nvarchar(250),
Region nvarchar(250),
PostalCode nvarchar(250),
Country nvarchar(250),
Phone nvarchar(250),
Photo nvarchar(250),
Notes nvarchar(250)
)

create table Shippers
(
ShipperID int identity(1,1) primary key,
CompanyName nvarchar(250),
Phone nvarchar(50)
)

create table CustomerDemographics
(
CustomerTypeID int identity(1,1) primary key,
CustomerDesc nvarchar(250)
)

create table Customers
(
CustomerID int identity(1,1) primary key,
CompanyName nvarchar(250),
ContactName nvarchar(250),
ContactTitle nvarchar(250),
Address nvarchar(250),
City nvarchar(250),
Region nvarchar(250),
PostalCode nvarchar(250),
Country nvarchar(250),
Phone nvarchar(50),
Fax nvarchar(50)
)

create table CustomerDemo
(
CustomerID int references Customers(CustomerID),
CustomerTypeID int references CustomerDemographics(CustomerTypeID),
primary key(CustomerID, CustomerTypeID)
)

create table Orders
(
OrderID int identity(1,1) primary key,
CustomerID int references Customers(CustomerID),
EmployeeID int references Employees(EmployeeID),
OrderDate smalldatetime,
RequiredDate smalldatetime,
ShipperDate smalldatetime,
ShipVia nvarchar(250),
Freight nvarchar(250),
ShipName nvarchar(250),
ShipAddress nvarchar(250),
ShipCity nvarchar(250),
ShipRegion nvarchar(250),
ShipPostalCode nvarchar(250),
ShipCountry nvarchar(250)
)

create table OrderDetails
(
OrderID int references Orders(OrderID),
ProductID int references Products(ProductID),
UnitPrice nvarchar(250),
Quantity int,
Discount int
primary key(OrderID, ProductID)
)

--drop procedure InsertCustomer
--PROCEDURE
CREATE PROCEDURE InsertCustomer
@companyName nvarchar(250),
@contactName nvarchar(250),
@contactTitle nvarchar(250),
@address nvarchar(250),
@city nvarchar(250),
@region nvarchar(250),
@postalCode nvarchar(250),
@country nvarchar(250),
@phone nvarchar(50),
@fax nvarchar(50)
AS
	INSERT INTO Customers(CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone, Fax)
	VALUES ( @companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax)
go

CREATE PROCEDURE InsertSupplier
@companyName nvarchar(250),
@contactName nvarchar(250),
@address nvarchar(250),
@city nvarchar(250),
@region nvarchar(250),
@postalCode nvarchar(250),
@country nvarchar(250),
@phone nvarchar(250),
@fax nvarchar(250),
@homePage nvarchar(250)
AS
	INSERT INTO Suppliers(CompanyName,ContactName,Address,City,Region,PostalCode,Country,Phone, Fax, HomePage)
	VALUES ( @companyName,@contactName,@address,@city,@region,@postalCode,@country,@phone,@fax, @homePage)
go

CREATE PROCEDURE InsertEmployee
@lastName nvarchar(50),
@firstName nvarchar(100),
@title nvarchar(250),
@birthDay smalldatetime,
@address nvarchar(250),
@city nvarchar(250),
@region nvarchar(250),
@postalCode nvarchar(250),
@country nvarchar(250),
@phone nvarchar(250),
@photo nvarchar(250),
@note nvarchar(250)
AS
	INSERT INTO Employees(LastName, FirstName, Title, BirthDay,Address,City,Region,PostalCode,Country,Phone,Photo, Notes)
	VALUES (@lastName,@firstName,@title,@birthDay,@address,@city,@region,@postalCode,@country,@phone,@phone,@note)
go

CREATE PROCEDURE InsertPrroduct
@name nvarchar(250),
@suppID int,
@catID int,
@quantity int,
@price nvarchar(250),
@stock nvarchar(250),
@order nvarchar(250),
@lever int,
@discontribute bit
AS
	INSERT INTO Products(ProductName, SupplierID,CategoryID, QuantityPerUnit, UnitPrice,UnitsInStock, UnitsOnOrder, ReorderLevel,Discontinued)
	VALUES (@name,@suppID,@catID,@quantity,@price,@stock,@order,@lever,@discontribute)
go


