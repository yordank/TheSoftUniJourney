SELECT TOP 5 e.EmployeeID,e.FirstName,p.Name
FROM (Employees AS e
LEFT JOIN EmployeesProjects AS ep
ON e.EmployeeID=ep.EmployeeID) 
LEFT JOIN Projects AS p
ON ep.ProjectID=p.ProjectID
WHERE StartDate > '2002-08-13'  
AND EndDate IS NULL
ORDER BY e.EmployeeID