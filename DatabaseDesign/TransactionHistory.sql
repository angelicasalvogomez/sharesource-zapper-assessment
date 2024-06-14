CREATE TABLE Customers (
	CustomerId INT PRIMARY KEY,
	CustomerFirstName VARCHAR(50) NOT NULL,
	CustomerLastName VARCHAR(50),
	Timestamp DATETIME NOT NULL
);

CREATE TABLE Merchants (
	MerchantId INT PRIMARY KEY,
	MerchantName VARCHAR(50) NOT NULL,
	CustomerLastName VARCHAR(20),
	Timestamp DATETIME NOT NULL
);

CREATE TABLE Products (
	ProductId INT PRIMARY KEY,
	ProductIdName VARCHAR(50) NOT NULL,
	Timestamp DATETIME NOT NULL
);

CREATE TABLE PurchaseStatus (
	PurchaseStatusId INT PRIMARY KEY,
	PurchaseStatusName VARCHAR(50) NOT NULL, -- InCart, Paid, Canceled, Refunded
	Timestamp DATETIME NOT NULL
);

CREATE TABLE TransactionHistory (
	TransactionId INT PRIMARY KEY,
	CustomerId INT,
	MerchantId INT,
	ProductId INT,
	PurchaseStatusId INT,
	PaidDateTime DATETIME,
	CanceledDateTime DATETIME,
	RefundedDateTime DATETIME,
	Timestamp DATETIME NOT NULL
);