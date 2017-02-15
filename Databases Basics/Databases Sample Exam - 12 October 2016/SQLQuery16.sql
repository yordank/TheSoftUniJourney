CREATE PROCEDURE usp_CustomersWithUnexpiredLoans(@CustomerID INT)
AS
BEGIN
    SELECT  c.CustomerID,
	        c.FirstName,
			l.LoanID   
	  FROM  Loans AS l
	  JOIN  Customers AS c
	    ON  l.CustomerID=c.CustomerID
     WHERE l.ExpirationDate IS NULL
	   AND c.CustomerID=@CustomerID

END

--EXEC usp_CustomersWithUnexpiredLoans @CustomerID = 9