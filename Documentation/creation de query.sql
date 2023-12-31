--USE
CREATE TABLE [User]
(
UserId INT PRIMARY KEY IDENTITY,
FistName Varchar(50) NOT NULL,
LastName VARCHAR(50) NOT Null,
UserName VARCHAR(50) NOT NULL,
Password VARCHAR(10) NOT NULL
);

--Customer
CREATE TABLE [Customer]
(
CustomerId INT PRIMARY KEY IDENTITY,
FullName VARCHAR(50) NOT NULL,
DocumentNumber VARCHAR(9) NOT NULL
);

--Booking
CREATE TABLE [Booking]
(
  BookingId INT PRIMARY KEY IDENTITY,
  RegisterDate DATETIME NOT NULL,
  Code VARCHAR(50) NOT NULL,
  Type VARCHAR(50) NOT NULL,
  UserId INT NOT NULL,
  CustomerId INT NOT NULL,
  FOREIGN KEY (UserId) REFERENCES [User] (UserId),
  FOREIGN KEY (CustomerId) REFERENCES [Customer] (CustomerId)
);
