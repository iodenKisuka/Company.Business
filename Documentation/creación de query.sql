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