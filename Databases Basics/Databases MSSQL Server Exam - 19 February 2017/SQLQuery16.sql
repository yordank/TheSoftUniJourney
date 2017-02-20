CREATE VIEW v_UserWithCountries 
AS
SELECT CONCAT(FirstName,' ',LastName) AS CustomerName,
       Age,
	   Gender,
	   cc.Name AS CountryName
  FROM Customers AS c
  JOIN Countries AS cc
    ON c.CountryId=cc.Id