SELECT u.Username,
       u.FullName,
	   u.BirthDate,
	   CASE 
	     WHEN p.Title IS NULL THEN 'No photos' 
		 ELSE p.Title
       END AS Photo
  FROM Photographs AS p
  RIGHT JOIN Users AS u
    ON p.UserId=u.Id
 WHERE MONTH(u.BirthDate)=1
 ORDER BY u.FullName ASC
 