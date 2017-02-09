DELETE FROM Locations  
WHERE Id IN (
SELECT l.Id
  FROM Users AS u 
  RIGHT JOIN Locations AS l
    ON u.LocationId=l.Id
  WHERE u.Id IS NULL
)
