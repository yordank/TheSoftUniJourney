CREATE TABLE Countries
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
Name NVARCHAR(50) UNIQUE
)

CREATE TABLE Products
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
Name NVARCHAR(25) UNIQUE,
Description NVARCHAR(250),
Recipe NVARCHAR(MAX),
Price MONEY CHECK(Price >=0)
)

CREATE TABLE Distributors
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
Name NVARCHAR(25),
AddressText NVARCHAR(30),
Summary NVARCHAR(200),
CountryId INT CHECK(CountryId>=0),
FOREIGN KEY (CountryId) REFERENCES Countries(Id)


)


CREATE TABLE Customers
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
FirstName NVARCHAR(25),
LastName NVARCHAR(25),
Gender CHAR(1) CHECK (Gender IN ('M','F')),
Age INT CHECK(Age>=0),
PhoneNumber CHAR(10) CHECK ( PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CountryId INT CHECK(CountryId>=0),
FOREIGN KEY (CountryId) REFERENCES Countries(Id)

)
CREATE TABLE Feedbacks
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
Description NVARCHAR(255),
Rate DECIMAL(4,2) CHECK (Rate BETWEEN 0 AND 10),
ProductId INT CHECK(ProductId>=0) ,
CustomerId INT CHECK(CustomerId>=0),
FOREIGN KEY (ProductId) REFERENCES Products(Id),
FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)


CREATE TABLE Ingredients
(
Id INT PRIMARY KEY IDENTITY CHECK(Id>=0),
Name NVARCHAR(30),
Description NVARCHAR(200),
OriginCountryId INT CHECK(OriginCountryId>=0),
DistributorId INT CHECK(DistributorId>=0),
FOREIGN KEY (OriginCountryId) REFERENCES Countries(Id),
FOREIGN KEY (DistributorId) REFERENCES Distributors(Id)
  
)

CREATE TABLE ProductsIngredients
(
ProductId INT CHECK(ProductId>=0), 
IngredientId INT CHECK(IngredientId>=0), 


FOREIGN KEY (ProductId) REFERENCES Products(Id),
FOREIGN KEY (IngredientId) REFERENCES Ingredients(Id),
PRIMARY KEY (ProductId,IngredientId)

)

