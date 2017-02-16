	SELECT tabl2.Title,
	       tabl2.Name AS 'Category Name',
		   tabl2.Model AS 'Model',
		   tabl2.[Manufacturer Name] AS 'Manufacturer Name',
		   tabl2.Megapixels,
		   tabl.MaxPrice AS Price
	        
	  FROM 
	(SELECT c.Id,
	       MAX(cc.Price) AS MaxPrice
	  FROM Photographs AS p
	  JOIN Categories AS c
	    ON c.Id=p.CategoryId
      JOIN Equipments AS e
	    ON e.Id=p.EquipmentId
	  JOIN 	Cameras AS cc
	    ON e.CameraId=cc.Id
      JOIN Manufacturers AS m
	    ON m.Id=cc.ManufacturerId
     GROUP BY  c.Id)AS tabl
	 LEFT JOIN
	 (SELECT 
	       c.Id,
		   p.Title,
		   cc.Price,
		   c.Name,
		   cc.Model,
		   m.Name AS 'Manufacturer Name',
		   cc.Megapixels,
		   cc.Id AS CameraID
		   
	  FROM Photographs AS p
	  JOIN Categories AS c
	    ON c.Id=p.CategoryId
      JOIN Equipments AS e
	    ON e.Id=p.EquipmentId
	  JOIN 	Cameras AS cc
	    ON e.CameraId=cc.Id
      JOIN Manufacturers AS m
	    ON m.Id=cc.ManufacturerId)AS tabl2
     ON tabl.Id=tabl2.Id
     WHERE MaxPrice=Price
	 ORDER BY Price DESC,Title ASC