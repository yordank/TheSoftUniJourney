SELECT e.EmployeeID,
       e.FirstName,
	   CASE 
	     WHEN YEAR(p.StartDate)>=2005 THEN NULL
		 ELSE p.Name
	   END	
  FROM Employees AS e
  INNER JOIN EmployeesProjects AS ep
  ON e.EmployeeID=ep.EmployeeID 
  INNER JOIN Projects AS p
  ON ep.ProjectID=p.ProjectID
  WHERE e.EmployeeID=24