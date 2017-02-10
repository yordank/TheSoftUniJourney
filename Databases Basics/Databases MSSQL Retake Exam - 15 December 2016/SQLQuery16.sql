CREATE PROCEDURE udp_ChangePassword(@Email VARCHAR(100),@NewPass VARCHAR(100))
AS
BEGIN

   DECLARE @Id INT =(SELECT Id FROM Credentials WHERE Email=@Email)
   
   IF(@Id IS NOT NULL)
   BEGIN
		UPDATE Credentials
		SET Password=@NewPass
		WHERE Email=@Email
   END
   ELSE
   RAISERROR ('The email does''t exist!', -- Message text.
               16, -- Severity.
               1 -- State.
               );

END