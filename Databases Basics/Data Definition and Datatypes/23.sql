--Problem 23.	Decrease Tax Rate
--Use Hotel database and decrease tax rate by 3% to all payments. Select only TaxRate column from the Payments table. Submit your query statements as Prepare DB & Run queries.

UPDATE Payments
SET TaxRate=TaxRate*0.97

SELECT TaxRate FROM Payments