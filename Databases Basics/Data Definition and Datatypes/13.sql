--Problem 13.	Movies Database
--Using SQL queries create Movies database with the following entities:
--	Directors (Id, DirectorName, Notes)
--	Genres (Id, GenreName, Notes)
--	Categories (Id, CategoryName, Notes)
--	Movies (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes)
--Set most appropriate data types for each column. Set primary key to each table. Populate each table with 5 records. Make sure the columns that are present in 2 tables would be of the same data type. Consider which fields are always required and which are optional. Submit your CREATE TABLE and INSERT statements as Run queries & check DB.
 
CREATE TABLE Directors
(
Id INT PRIMARY KEY IDENTITY ,
DirectorName NVARCHAR(50) ,
Notes NVARCHAR(50) DEFAULT 'None'
)

INSERT INTO Directors(DirectorName) VALUES('Ivan'),('YORDAN'),('STEFAN'),('TODORA'),('DELCHO')

CREATE TABLE Genres
(
Id INT PRIMARY KEY IDENTITY,
GenreName NVARCHAR(50) ,
Notes NVARCHAR(50) DEFAULT 'None'
)

INSERT INTO Genres(GenreName) VALUES ('ACTION'),('DOCUMENTARY'),('COMEDY'),('CLASSIC'),('SCIENCE')

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(50) ,
Notes NVARCHAR(50) DEFAULT 'None'
)

INSERT INTO Categories(CategoryName) VALUES
('CATEGORY1'),
('CATEGORY2'),
('CATEGORY3'),
('CATEGORY4'),
('CATEGORY5')



CREATE TABLE Movies
(
Id INT PRIMARY KEY IDENTITY,
Title NVARCHAR(50) NOT NULL,
DirectorId INT ,
CopyrightYear INT,
Lenght INT CHECK(Lenght>1),
GenreId INT,
CategoryId INT,
Rating INT,
Notes NVARCHAR(50)
FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
FOREIGN KEY (GenreId) REFERENCES Genres(Id),
FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)

INSERT INTO Movies  VALUES ('Titanik',1,2008,90,1,1,10,'Excellent Movie'),
('Die Hard',1,2008,90,1,1,10,'Excellent Movie'),
('С деца на море',1,2008,90,1,1,10,'Excellent Movie'),
('Жребият',1,2008,90,1,1,10,'Excellent Movie'),
('Глад за промяна',1,2008,90,1,1,10,'Excellent Movie')
