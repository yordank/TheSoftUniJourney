SELECT p.Title,
       c.Model AS CameraModel,
	   l.Model AS LensModel 
  FROM Photographs AS p
  JOIN Equipments AS e
    ON p.EquipmentId=e.Id
  JOIN Lenses AS l
    ON l.Id=e.LensId
  JOIN Cameras AS c
    ON c.Id=e.CameraId
 ORDER BY p.Title