CREATE Table Credentials
(

Id INT PRIMARY KEY IDENTITY CHECK (Id>=0),
Email VARCHAR(250),
Password VARCHAR(250)
)

CREATE TABLE Locations
(
Id INT PRIMARY KEY IDENTITY CHECK (Id>=0),
Latitude FLOAT,
Longitude FLOAT
)
CREATE TABLE Users
(
Id INT PRIMARY KEY IDENTITY CHECK (Id>=0),
Nickname VARCHAR(250),
Gender CHAR CHECK (Gender IN ('M','F')),
Age INT CHECK (Age>=0),
LocationId INT CHECK (LocationId>=0) ,
CredentialId INT UNIQUE CHECK (CredentialId>=0),
FOREIGN KEY (LocationId) REFERENCES Locations(Id),
FOREIGN KEY (CredentialId) REFERENCES Credentials(Id)
)

CREATE TABLE Chats
(
Id INT PRIMARY KEY IDENTITY CHECK (Id>=0),
Title VARCHAR(250),
StartDate DATE,
IsActive BIT
)

CREATE TABLE Messages 
(
Id INT PRIMARY KEY IDENTITY CHECK (Id>=0),
Content VARCHAR(250),
SentOn DATE,
ChatId INT CHECK (ChatId>=0),
UserId INT CHECK (UserId>=0),
FOREIGN KEY (ChatId) REFERENCES Chats(Id),
FOREIGN KEY (UserId) REFERENCES Users(Id)

)
CREATE TABLE UsersChats
(
UserId INT CHECK (UserId>=0),
ChatId INT CHECK (ChatId>=0),
 PRIMARY KEY (ChatId,UserId),
FOREIGN KEY (ChatId) REFERENCES Chats(Id),
FOREIGN KEY (UserId) REFERENCES Users(Id)


)