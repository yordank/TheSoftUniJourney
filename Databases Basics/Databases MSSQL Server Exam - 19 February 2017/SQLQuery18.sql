CREATE PROCEDURE usp_SendFeedback(@customerId INT, @productId INT,@rate DECIMAL(10,2),@description NVARCHAR(MAX))
AS
BEGIN
   DECLARE @v INT=(SELECT COUNT(*)
				FROM Feedbacks 
				WHERE CustomerId=@customerId)
   BEGIN TRAN
    INSERT INTO Feedbacks(Description,Rate,ProductId,CustomerId)
	     VALUES(@description,@rate,@productId,@customerId)
    
	IF(@v>=3)
	BEGIN 
	  ROLLBACK
	  RAISERROR ('You are limited to only 3 feedbacks per product!',16,1)
    END
	ELSE
	COMMIT
    
END