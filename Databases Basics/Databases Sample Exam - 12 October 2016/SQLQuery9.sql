SELECT c.CityName,
       b.Name,
	   COUNT(e.EmployeeID) 
  FROM Branches AS b
  JOIN Cities AS c
    ON b.CityID=c.CityID
  LEFT JOIN Employees AS e
    ON e.BranchID=b.BranchID
 WHERE c.CityID NOT IN (4, 5)
 GROUP BY c.CityName,b.Name
 HAVING COUNT(e.EmployeeID) >=3