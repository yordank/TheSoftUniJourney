SELECT p.PeakName,
       m.MountainRange,
	   c.CountryName,
	   ct.ContinentName
  FROM MountainsCountries AS mc
  JOIN Mountains AS m
    ON mc.MountainId=m.Id
  LEFT JOIN Peaks AS p
    ON p.MountainId=m.Id
  JOIN Countries AS c
    ON c.CountryCode=mc.CountryCode
  JOIN Continents AS ct
    ON ct.ContinentCode=c.ContinentCode
  WHERE p.PeakName IS NOT NULL
 ORDER BY p.PeakName
  