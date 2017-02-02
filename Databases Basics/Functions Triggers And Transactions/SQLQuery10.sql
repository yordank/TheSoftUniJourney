CREATE PROCEDURE usp_GetHoldersFullName 
AS
BEGIN
 SELECT FirstName+' '+LastName FROM AccountHolders
END

--EXEC usp_GetHoldersFullName