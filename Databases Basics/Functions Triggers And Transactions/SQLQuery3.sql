CREATE PROCEDURE usp_GetTownsStartingWith(@letter NVARCHAR(50))
AS
BEGIN
	  DECLARE @l NVARCHAR(50)=@letter+'%' 
	   SELECT Name
		 FROM Towns
		WHERE Name LIKE @l
END


--EXEC usp_GetTownsStartingWith 'be'