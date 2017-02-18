SELECT a1.Date AS FirstDate,
       a2.Date AS SecondDate
	  
  FROM Ads AS a1
  LEFT JOIN Ads AS a2
    ON 1=1
  WHERE DATEADD(HOUR,12,a1.Date)>a2.Date
    AND a1.Date<a2.Date
	AND  DATEDIFF(HOUR,a1.Date,a2.Date)<12

  ORDER BY a1.Date,a2.Date

 