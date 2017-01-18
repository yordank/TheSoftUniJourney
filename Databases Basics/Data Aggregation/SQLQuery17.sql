--Problem 17.	*3rd Highest Salary
--Find the third highest salary in each department if there is such. 

SELECT DepartmentID,MAX(Salary) AS SECONDMAX FROM Employees 
WHERE EmployeeID NOT IN 
(
 
SELECT  mm2.EmployeeID FROM
  (
SELECT DepartmentID,MAX(Salary) AS SECONDMAX FROM Employees 
WHERE EmployeeID NOT IN (
SELECT e1.EmployeeID FROM Employees AS e1 
JOIN 
(
SELECT DepartmentID,MAX(Salary) AS MaxSalary
 FROM Employees AS e
 
GROUP BY DepartmentID)AS e2
ON e1.DepartmentID=e2.DepartmentID AND
   e1.Salary=e2.MaxSalary
   )

   

   GROUP BY DepartmentID
   
 )AS mm1
 JOIN
 Employees mm2
 ON 
 mm1.DepartmentID=mm2.DepartmentID
 AND
 mm1.SECONDMAX=mm2.Salary


 UNION

 
SELECT e1.EmployeeID FROM Employees AS e1 
JOIN 
(
SELECT DepartmentID,MAX(Salary) AS MaxSalary
 FROM Employees AS e
 
GROUP BY DepartmentID)AS e2
ON e1.DepartmentID=e2.DepartmentID AND
   e1.Salary=e2.MaxSalary


   )


   GROUP BY DepartmentID