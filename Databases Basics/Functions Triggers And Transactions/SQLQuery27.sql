SELECT i.Name,
	   i.Price,
	   i.MinLevel,
	   gt.Name	
  FROM Items AS i
  LEFT  JOIN GameTypeForbiddenItems AS gtfi
    ON gtfi.ItemId=i.Id
  LEFT JOIN GameTypes AS gt
    ON gt.Id=gtfi.GameTypeId
 ORDER BY gt.Name DESC,i.Name ASC

