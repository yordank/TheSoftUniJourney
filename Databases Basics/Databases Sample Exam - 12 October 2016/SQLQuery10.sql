SELECT SUM(l.Amount) AS TotalLoanAmount,
       MAX(l.Interest) AS MaxInterest,
	   MIN(e.Salary) AS MinEmployeeSalary
  FROM EmployeesLoans AS el
  JOIN Employees AS e
    ON e.EmployeeID=el.EmployeeID
  JOIN Loans AS l
    ON l.LoanID=el.LoanID
 