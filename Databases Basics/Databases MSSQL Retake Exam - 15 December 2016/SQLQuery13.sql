SELECT DISTINCT
       u.Nickname,
       c.Title,
	   l.Latitude,
	   l.Longitude 
      FROM Users AS u
      JOIN Locations AS l
       ON u.LocationId=l.Id
	  LEFT JOIN UsersChats AS uc
        ON uc.UserId=u.Id
       JOIN Chats AS c
	     ON c.Id=uc.ChatId
	   WHERE l.Latitude BETWEEN 41.14 AND 44.13
	     AND l.Longitude BETWEEN  21.21 AND 28.30
		 OR u.LocationId IS NULL
      ORDER BY c.Title ASC


	   