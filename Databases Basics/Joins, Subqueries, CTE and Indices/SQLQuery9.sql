SELECT e1.EmployeeID,
	   e1.FirstName,
	   e1.ManagerID,
	   e2.FirstName	
 FROM Employees AS e1
 LEFT JOIN Employees AS e2
   ON e2.EmployeeID=e1.ManagerID
WHERE e1.ManagerID IN (3,7) 
ORDER BY e1.EmployeeID 