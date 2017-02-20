  CREATE FUNCTION udf_GetRating(@ProductName NVARCHAR(100))
  RETURNS NVARCHAR(100)
  AS
  BEGIN
     DECLARE @vv VARCHAR(100)=( 
									SELECT  
										   CASE 
											 WHEN AVG(f.Rate) IS NULL THEN 'No rating'
											 WHEN AVG(f.Rate)<5 THEN 'Bad'
											 WHEN AVG(f.Rate) BETWEEN 5 AND 8 THEN 'Average'
											 ELSE 'Good'
											END AS Rating
									  FROM Feedbacks AS f
									  RIGHT JOIN Products AS p
										ON f.ProductId=p.Id
									  GROUP BY p.Name
									  HAVING p.Name=@ProductName
									)

   RETURN @vv

  END