SELECT TOP 10
       p.Name,
       P.Description,
       AVG(f.Rate),
	   COUNT(f.Id) 
  FROM Feedbacks AS f
  JOIN Products AS p
    ON f.ProductId=p.Id
  GROUP BY p.Name,p.Description
  ORDER BY AVG(f.Rate) DESC,COUNT(f.Id) DESC 