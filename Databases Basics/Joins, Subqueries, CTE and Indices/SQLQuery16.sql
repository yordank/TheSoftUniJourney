SELECT COUNT(*) AS CountryCount FROM
(
SELECT c.CountryCode
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc
  ON c.CountryCode=mc.CountryCode
  LEFT JOIN Mountains AS m
  ON m.Id=mc.MountainId
  WHERE m.MountainRange IS NULL 
)AS tabl