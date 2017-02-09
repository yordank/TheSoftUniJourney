SELECT c.Id,
       c.Title,
	   m.Id
FROM Messages AS m
JOIN Chats AS c
  ON m.ChatId=c.Id
 WHERE m.SentOn<'2012-03-26'
  AND RIGHT(Title,1)='x'  
  ORDER BY c.Id ASC, m.Id ASC