CREATE PROCEDURE usp_SubmitReview(
@CustomerID INT,
@ReviewContent VARCHAR(100),
@ReviewGrade INT,
@AirlineName VARCHAR(100)
)
AS
BEGIN

	DECLARE @AirlineID INT=(SELECT AirlineID FROM Airlines WHERE AirlineName=@AirlineName)
	
	IF(@AirlineID IS NOT NULL)
	BEGIN
	 DECLARE @ReviewID INT=(SELECT TOP 1 ReviewID FROM CustomerReviews ORDER BY ReviewID DESC)
	 IF(@ReviewID IS NULL)
	 SET @ReviewID=1
	 INSERT INTO CustomerReviews(ReviewID,ReviewContent,ReviewGrade,AirlineID,CustomerID)
	  VALUES(@ReviewID+1,@ReviewContent,@ReviewGrade,@AirlineID,@CustomerID)
	END
	ELSE
	RAISERROR('Airline does not exist.',16,1)
 
END