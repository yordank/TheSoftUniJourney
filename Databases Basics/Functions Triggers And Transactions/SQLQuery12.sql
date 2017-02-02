CREATE FUNCTION ufn_CalculateFutureValue (@sum MONEY,@interestRate FLOAT,@years INT)
RETURNS MONEY
AS
BEGIN
		RETURN @sum*POWER((1+@interestRate),@years)
END

--SELECT dbo.ufn_CalculateFutureValue(1000,0.10,5)