 
  SELECT 
		 u.Username,
		 g.Name,
		 COUNT(ugi.ItemId) AS 'Items Count',
		 SUM(i.Price) AS 'Items Price'
    FROM UserGameItems AS ugi
    JOIN Items AS i
	  ON ugi.ItemId=i.Id
	JOIN UsersGames AS ug
	  ON ug.Id=ugi.UserGameId
    JOIN Users AS u
	  ON u.Id=ug.UserId
    JOIN Games AS g
	  ON g.Id=ug.GameId
	GROUP BY u.Username,g.Name
	HAVING COUNT(ugi.ItemId)>=10
	ORDER BY COUNT(ugi.ItemId) DESC,SUM(i.Price) DESC,u.Username ASC     
 