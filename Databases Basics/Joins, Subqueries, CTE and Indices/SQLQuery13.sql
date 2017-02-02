 SELECT mc.CountryCode,
        COUNT(m.MountainRange) AS MountainRange
   FROM MountainsCountries AS mc
   JOIN Mountains AS m
     ON mc.MountainId=m.Id
  GROUP BY mc.CountryCode
 HAVING mc.CountryCode IN ('BG','US','RU')