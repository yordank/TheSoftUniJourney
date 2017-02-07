
SELECT 
	   g.Name,
	   gt.Name,
	   u.Username,
	   ug.Level,
	   ug.Cash,	
	   c.Name 
  FROM UsersGames AS ug 
  JOIN Users AS u
    ON ug.UserId=u.Id 
  JOIN Games AS g
    ON g.Id=ug.GameId
  JOIN GameTypes AS gt
    ON gt.Id=g.GameTypeId
  JOIN Characters AS c
    ON c.Id=ug.CharacterId
 ORDER BY ug.Level DESC,u.Username,g.Name