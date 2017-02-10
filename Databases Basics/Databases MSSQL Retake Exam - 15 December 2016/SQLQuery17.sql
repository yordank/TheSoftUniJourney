CREATE PROCEDURE udp_SendMessage(@UserId INT,@ChatId INT,@Content VARCHAR(100))
AS
BEGIN
  DECLARE @FLAG INT =(SELECT UserId FROM UsersChats WHERE UserId=@UserId AND ChatId=@ChatId )
  IF(@FLAG IS NOT NULL)
  BEGIN
     INSERT INTO Messages VALUES (@Content,FORMAT(GETDATE(),'yyyy-MM-dd'),@ChatId,@UserId)
  END
  ELSE
  BEGIN
	 RAISERROR ('There is no chat with that user!', -- Message text.
               16, -- Severity.
               1 -- State.
               );
  END
END
