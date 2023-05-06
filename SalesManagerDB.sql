USE SalesManagerDB

CREATE TABLE "Supplier"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "CompanyName" NVARCHAR(50) NOT NULL,
    "Address" NVARCHAR(100) NOT NULL,
    "Phone" VARCHAR(20) NULL,
    "Email" VARCHAR(20) NULL,
    "Webpage" VARCHAR(100) NULL,
    "Description" NVARCHAR(100) NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "Category"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "CategoryName" NVARCHAR(30) NOT NULL,
    "Description" NVARCHAR(100) NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "SalesDetail"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "WareHouseId" BIGINT NOT NULL,
    "ProductId" BIGINT NOT NULL,
    "Total" BIGINT NULL,
    "SellNumber" BIGINT NULL,
    "SalesTotal" DECIMAL(8, 2) NULL
);


CREATE TABLE "Product"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "ProductName" NVARCHAR(40) NOT NULL,
    "SupplierId" BIGINT NOT NULL,
    "CategoryId" BIGINT NOT NULL,
    "ProductPrice" DECIMAL(30, 2) NOT NULL,
    "UnitPrice" NVARCHAR(10) NOT NULL,
    "ProductStatusId" INT NOT NULL,
    "DiscountPercent" FLOAT NULL,
    "Rating" INT NULL,
    "ImageId" BIGINT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "Account"(
    "Username" VARCHAR(40) PRIMARY KEY NOT NULL,
    "Password" VARCHAR(200) NOT NULL,
    "StatusId" INT NOT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);

CREATE TABLE "OrderDetail"(
    "OrderId" BIGINT NOT NULL,
    "ProductId" BIGINT NOT NULL,
    "NumberOfProducts" INT NOT NULL,
	"TotalPriceOfProducts" decimal(8,2) NOT NULL,
	CONSTRAINT PK_OrderDetail PRIMARY KEY ("OrderId","ProductId")
);

CREATE TABLE "Status"(
    "Id" INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "StatusName" VARCHAR(30) NOT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "WareHouse"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "WareHouseName" NVARCHAR(40) NOT NULL,
    "Address" NVARCHAR(100) NOT NULL,
    "NumberOfImport" BIGINT NULL,
    "NumberOfExport" BIGINT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "Order"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "CustomerName" nvarchar(40) NOT NULL,
    "OrderDate" DATETIME NOT NULL,
    "ShipperId" VARCHAR(40) NOT NULL,
    "ShipDate" DATETIME NULL,
    "ShipAddress" NVARCHAR(100) NOT NULL,
    "ShipPostalCode" VARCHAR(10) NULL,
    "ShipPrice" DECIMAL(8, 2) NOT NULL,
    "StatusId" INT NOT NULL,
    "PrivateDiscount" FLOAT NULL,
    "TotalPrice" DECIMAL(8, 2) NOT NULL,
    "PaymentMethod" nvarchar(50) NOT NULL,
    "Note" NVARCHAR(255) NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "Image"(
    "Id" BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "Source" VARCHAR(20) NOT NULL,
    "Description" VARCHAR(100) NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);


CREATE TABLE "Person"(
	"Id" bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
    "Username" VARCHAR(40) NULL,
    "LastName" NVARCHAR(30) NOT NULL,
    "FirstName" NVARCHAR(10) NOT NULL,
    "Gender" BIT NULL,
    "BirthDate" DATETIME NULL,
    "Phone" VARCHAR(20) NOT NULL,
    "Email" VARCHAR(40) NULL,
    "Address" NVARCHAR(100) NULL,
    "RoleId" INT NOT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);

CREATE TABLE "Role"(
    "Id" INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    "RoleName" NVARCHAR(25) NOT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
);
CREATE TABLE "Permission"(
	"Id" INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    "PermissionName" varchar(300) NOT NULL,
	"CreateDate" datetime NULL,
	"CreateBy" varchar(40) NULL,
	"UpdateDate" datetime NULL,
	"UpdateBy" varchar(40) NULL,
	"DeleteDate" datetime NULL,
	"DeleteBy" varchar(40) NULL,
	"IsDelete" bit NULL
)
CREATE TABLE "RolePermission"(
	"RoleId" INT NOT NULL,
    "PermissionId" INT NOT NULL,
	CONSTRAINT PK_RolePermission PRIMARY KEY ("RoleId","PermissionId")
)
