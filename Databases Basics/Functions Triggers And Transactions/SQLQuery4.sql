CREATE PROCEDURE usp_GetEmployeesFromTown (@town NVARCHAR(100))
AS
BEGIN
 
	SELECT e.FirstName,
	       e.LastName
	  FROM Employees AS e
	 INNER JOIN Addresses AS a
	    ON e.AddressID=a.AddressID
	 INNER JOIN	Towns as t
	    ON t.TownID=a.TownID
	 WHERE t.Name=@town 

END

--