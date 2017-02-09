SELECT TOP 5
       c.Id,
	   COUNT(mm.Id) 
  FROM Chats AS c
  RIGHT JOIN Messages AS mm
    ON mm.ChatId=c.Id
  WHERE mm.Id<90
 GROUP BY c.Id
 ORDER BY COUNT(mm.Id) DESC,c.Id 