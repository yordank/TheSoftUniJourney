SELECT Type,
       COUNT(*) AS Count
  FROM Lenses
 GROUP BY Type 
 ORDER BY COUNT(*) DESC,Type ASC