SELECT CustomerID,
       FirstName+' '+LastName AS FullName,
	   Gender 
FROM Customers
ORDER BY FirstName+' '+LastName,CustomerID 