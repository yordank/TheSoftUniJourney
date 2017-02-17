SELECT m.Name,
       SUM(l.Price) AS 'Total Price'
  FROM Lenses AS l
  JOIN Manufacturers AS m
    ON l.ManufacturerId=m.Id
 GROUP BY m.Name
 ORDER BY m.Name ASC