CREATE TRIGGER t
ON Employees
AFTER INSERT
AS
BEGIN
  DECLARE @EmployeeID INT=(SELECT EmployeeID FROM inserted)


  INSERT INTO EmployeesLoans(EmployeeID,LoanID)
  VALUES (@EmployeeID,(SELECT LoanID FROM EmployeesLoans WHERE EmployeeID=@EmployeeID-1 ))


END

--INSERT INTO Employees VALUES (31, 'Jake', '20161212', 500, 2,NULL)