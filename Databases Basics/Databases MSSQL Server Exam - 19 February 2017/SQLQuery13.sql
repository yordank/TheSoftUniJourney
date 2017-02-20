SELECT d.Name,
       i.Name,
	   p.Name,
	   tabl1.AverageRate
 FROM
(
SELECT p.Id,
       AVG(f.Rate) AS AverageRate
  FROM Feedbacks AS f
  JOIN Products AS p
    ON f.ProductId=p.Id
  GROUP BY p.Id 
  HAVING AVG(f.Rate) BETWEEN 5 AND 8)
  AS tabl1


LEFT JOIN ProductsIngredients AS ppi
ON ppi.ProductId=tabl1.Id
JOIN Ingredients AS i
ON i.Id=ppi.IngredientId
JOIN Distributors AS d
ON d.Id=i.DistributorId
JOIN Products AS p
 ON p.Id=tabl1.Id
 ORDER BY d.Name,i.Name,p.Name