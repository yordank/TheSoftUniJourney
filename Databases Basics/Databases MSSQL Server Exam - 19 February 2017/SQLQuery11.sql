SELECT f.ProductId,
         CONCAT(c.FirstName,' ',c.LastName),
		 f.Description
    FROM Feedbacks AS f
	JOIN Customers AS c
	  ON f.CustomerId=c.Id
   WHERE c.Id IN ( 
					 SELECT c.Id 
					 FROM Customers AS c
					 LEFT JOIN Feedbacks AS f
					   ON c.Id=f.CustomerId
					GROUP BY c.Id
					HAVING COUNT(f.Id)>=3
				 )
   ORDER BY f.ProductId,CONCAT(c.FirstName,' ',c.LastName),f.Id


  