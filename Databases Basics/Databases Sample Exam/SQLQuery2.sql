SELECT Title,
       Date 
  FROM Ads
  WHERE Date BETWEEN '2014-12-26 00:00:00.000' AND  '2015-01-01 23:59:59.000'
  ORDER BY Date