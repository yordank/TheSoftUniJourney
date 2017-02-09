SELECT m.Id,
       m.ChatId,
	   u.Id AS UserId 
FROM Messages AS m
LEFT JOIN Users AS u
  ON m.UserId=u.Id
WHERE m.ChatId=17
 AND  u.Id NOT IN (
				SELECT  UserId
        		  FROM  UsersChats
		   	      WHERE ChatId=m.ChatId
				 )
OR u.Id IS NULL

 
ORDER BY m.Id DESC