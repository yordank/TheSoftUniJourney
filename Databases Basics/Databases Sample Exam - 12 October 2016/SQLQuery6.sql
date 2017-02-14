SELECT FirstName,
       DateOfBirth,
	   DATEDIFF(YEAR,DateOfBirth,'01-10-2016') AS Age
  FROM Customers
  WHERE DATEDIFF(YEAR,DateOfBirth,'01-10-2016') BETWEEN 40 AND 50