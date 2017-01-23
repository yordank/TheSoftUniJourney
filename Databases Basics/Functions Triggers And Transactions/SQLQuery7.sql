CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50), @word VARCHAR(50)) 
RETURNS BIT
AS
BEGIN
	DECLARE @i INT =1;
	
	WHILE(@i<=LEN(@word))
		BEGIN
		
			DECLARE @ch VARCHAR(1)= SUBSTRING(@word,@i,1)
			 
			DECLARE @exp VARCHAR(100)='%'+@ch+'%'
			
			IF(@setOfLetters NOT LIKE @exp)
			   RETURN 0;
	
			SET @i=@i+1
		END

	RETURN 1;
END


 --SELECT [dbo].[ufn_IsWordComprised]('oistmiahf','Sofia')
 
 --SELECT [dbo].[ufn_IsWordComprised]('ppp','guy')