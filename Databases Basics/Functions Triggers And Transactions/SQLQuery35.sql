UPDATE Countries
   SET CountryName='Burma'
 WHERE CountryName='Myanmar'

 INSERT INTO Monasteries(Name,CountryCode)VALUES('Hanga Abbey',(SELECT CountryCode FROM Countries WHERE CountryName='Tanzania'))
 
 INSERT INTO Monasteries(Name,CountryCode)VALUES('Myin-Tin-Daik',(SELECT CountryCode FROM Countries WHERE CountryName='Myanmar'))




 SELECT 
        cnt.ContinentName,
		c.CountryName,
		COUNT(m.CountryCode) AS MonasteriesCount
   FROM Countries AS c
   LEFT JOIN Monasteries AS m
     ON c.CountryCode=m.CountryCode
   LEFT JOIN Continents AS cnt
     ON cnt.ContinentCode=c.ContinentCode
  WHERE c.IsDeleted=0
  GROUP BY c.CountryName,cnt.ContinentName
  ORDER BY COUNT(m.CountryCode)  DESC,c.CountryName ASC