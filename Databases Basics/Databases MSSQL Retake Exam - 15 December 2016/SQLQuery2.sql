/****** Script for SelectTopNRows command from SSMS  ******/
INSERT INTO Messages

SELECT  
      CONCAT(Age,'-',Gender,'-',Latitude,'-',Longitude) AS Content
      ,FORMAT(GetDate(), 'yyyy-MM-dd') AS SentOn
	
      ,CASE
		 WHEN Gender='F'  THEN CEILING(SQRT(AGE*2))
		 ELSE CEILING(POWER(AGE/18,3))
	   END	AS ChatId
      ,u.Id AS UserId
 
  FROM Users AS u
   JOIN Locations AS l
    ON u.LocationId=l.Id
  WHERE u.Id BETWEEN 10 AND 20