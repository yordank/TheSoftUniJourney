SELECT Name,
       Description,
	   OriginCountryId 
  FROM Ingredients
  WHERE OriginCountryId in (1,10,20)
  ORDER BY Id