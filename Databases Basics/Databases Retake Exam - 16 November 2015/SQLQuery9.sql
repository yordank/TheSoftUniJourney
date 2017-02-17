SELECT u.FullName,
	   m.Name AS 'Manufacturer',
	   c.Model AS 'Camera Model',
	   c.Megapixels
  FROM Users AS u
  JOIN Equipments AS e
    ON u.EquipmentId=e.Id
  JOIN Cameras AS c
    ON c.Id=e.CameraId
  JOIN Manufacturers AS m
    ON c.ManufacturerId=m.Id
 WHERE c.Year<2015 
 ORDER BY u.FullName