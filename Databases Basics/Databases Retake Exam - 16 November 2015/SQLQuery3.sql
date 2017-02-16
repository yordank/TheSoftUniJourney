SELECT p.Title,
       p.Link,
	   p.Description,
	   c.Name AS CategoryName,
	   u.FullName AS Author
  FROM Photographs AS p
  JOIN Categories AS c
    ON p.CategoryId=c.Id
  JOIN Users AS u
    ON u.Id=p.UserId
 WHERE p.Description IS NOT NULL
 ORDER BY p.Title 