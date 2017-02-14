SELECT c.CustomerID,
       c.FirstName,
	   c.LastName,
	   c.Gender,
	   cc.CityName
  FROM Customers AS c
  JOIN Cities as cc
    ON c.CityID=cc.CityID 
 WHERE (c.LastName LIKE 'Bu%' 
    OR c.FirstName LIKE '%a')
	AND LEN(cc.CityName)>=8
 ORDER BY c.CustomerID ASC