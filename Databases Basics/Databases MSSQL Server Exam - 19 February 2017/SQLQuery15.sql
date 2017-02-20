SELECT t1.CountryName,
       t1.DistributorName
  FROM
(
SELECT   
       d.Name AS DistributorName,
	   c.Name AS CountryName, 
	   COUNT(i.Id) AS cccccccccc
  FROM Ingredients AS i
  RIGHT JOIN Distributors AS d
    ON i.DistributorId=d.Id
  JOIN Countries AS c
    ON c.Id=d.CountryId
  GROUP BY d.Name,c.Name
  --ORDER BY c.Name,d.Name

)AS t1
JOIN
(
SELECT
   tabl1.CountryName,
   MAX(Count) AS MaxDistribution
   FROM
( 
SELECT   
       d.Name AS DistributorName,
	   c.Name AS CountryName,
	   COUNT(i.Id) AS Count
  FROM Ingredients AS i
  RIGHT JOIN Distributors AS d
    ON i.DistributorId=d.Id
  JOIN Countries AS c
    ON c.Id=d.CountryId
  GROUP BY d.Name,c.Name
 
) AS tabl1
GROUP BY tabl1.CountryName
--ORDER BY tabl1.CountryName 
)AS t2
ON t1.CountryName=t2.CountryName
WHERE t1.cccccccccc=t2.MaxDistribution
ORDER BY t1.CountryName,t1.DistributorName
