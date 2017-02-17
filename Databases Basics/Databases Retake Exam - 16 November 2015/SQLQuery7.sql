SELECT m.Name,
       c.Model,
	   c.Price 
  FROM Cameras AS c
  JOIN Manufacturers AS m
    ON m.Id=c.ManufacturerId
 WHERE c.Price>(SELECT AVG(Price) FROM Cameras) 
 ORDER BY c.Price DESC,c.Model ASC