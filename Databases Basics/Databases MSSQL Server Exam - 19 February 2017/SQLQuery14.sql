SELECT cc.Name,
       AVG(f.Rate) 
  FROM Feedbacks AS f
  JOIN Customers AS c
    ON f.CustomerId=c.Id
  JOIN Countries AS cc
    ON cc.Id=c.CountryId
 GROUP BY cc.Name
  
 HAVING AVG(f.Rate) =(
						SELECT TOP 1
							   AVG(f.Rate) 
						  FROM Feedbacks AS f
						  JOIN Customers AS c
							ON f.CustomerId=c.Id
						  JOIN Countries AS cc
							ON cc.Id=c.CountryId
						 GROUP BY cc.Name
						 ORDER BY AVG(f.Rate) DESC
						)