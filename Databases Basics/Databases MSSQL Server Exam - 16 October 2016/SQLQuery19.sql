CREATE PROCEDURE usp_PurchaseTicket(
@CustomerID INT,
@FlightID VARCHAR(100),
@TicketPrice NUMERIC(8, 2),
@Class VARCHAR(10),
@Seat VARCHAR(5)

)
AS
BEGIN

	DECLARE @Cash NUMERIC(10,2)=(SELECT Balance FROM CustomerBankAccounts WHERE CustomerID=@CustomerID)-@TicketPrice
	
	IF(@Cash >=0)
	BEGIN
	
	 DECLARE @TicketID INT=(SELECT TOP 1 TicketId FROM Tickets ORDER BY TicketId DESC)
	 IF(@TicketID IS NULL)
	 SET @TicketID=1
	 
	 INSERT INTO Tickets(TicketId,Price,Class,Seat,CustomerID,FlightID)
	 VALUES(@TicketID+1,@TicketPrice,@Class,@Seat,@CustomerID,@FlightID)
	 
	 UPDATE CustomerBankAccounts
	 SET Balance=@Cash
	 WHERE CustomerID=@CustomerID
	
	END
	ELSE
	RAISERROR('Insufficient bank account balance for ticket purchase.',16,1)
 
END