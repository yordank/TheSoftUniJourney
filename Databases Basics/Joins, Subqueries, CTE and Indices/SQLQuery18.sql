SELECT TOP 5 ff.CountryName,ff.HighestPeakName,ff.HighestPeakElevation,ff.Mountain FROM 

(

SELECT t1.CountryName,
       t1.HighestPeakName,
	   t1.HighestPeakElevation,
	   t1.Mountain,
	 
	   CASE 
	      WHEN t2.HighestPeakElevation IS NULL THEN 0
		  ELSE t2.HighestPeakElevation
	   END AS HighestPeakElevation2 
	   
 FROM

(

SELECT  
       c.CountryName,
	   CASE 
	      WHEN m1.PeakName IS NULL THEN '(no highest peak)'
		  ELSE m1.PeakName
	   END AS HighestPeakName, 
	   CASE 
	      WHEN m1.Elevation IS NULL THEN 0
		  ELSE m1.Elevation
	   END AS HighestPeakElevation,
	   CASE 
	        WHEN m1.MountainRange IS NULL THEN '(no mountain)'
		    ELSE m1.MountainRange
       END AS Mountain
	   
	   --MAX(m1.Elevation) HighestPeakElevation  

 FROM Countries AS c
 
 LEFT JOIN MountainsCountries AS mc
 ON mc.CountryCode=c.CountryCode
 LEFT JOIN (
			SELECT t1.Id,
			       t1.MountainRange,
				   t2.Elevation,
				   t2.PeakName
				    
				 
			FROM Mountains AS t1
			JOIN Peaks AS t2
			   ON t1.Id=t2.MountainId
			 
		    )AS m1
 ON m1.Id=mc.MountainId
 --GROUP BY c.CountryName     
 

 )AS t1

 LEFT JOIN

 (

 SELECT  
       c.CountryName,
	   

	   MAX(m1.Elevation) HighestPeakElevation  

 FROM Countries AS c
 
 LEFT JOIN MountainsCountries AS mc
 ON mc.CountryCode=c.CountryCode
 LEFT JOIN (
			SELECT t1.Id,
			       t1.MountainRange,
				   t2.Elevation,
				   t2.PeakName
				    
				 
			FROM Mountains AS t1
			JOIN Peaks AS t2
			   ON t1.Id=t2.MountainId
			 
		    )AS m1
 ON m1.Id=mc.MountainId
 GROUP BY c.CountryName     
 )
 AS t2
 ON t1.CountryName=t2.CountryName

  )AS ff

  WHERE ff.HighestPeakElevation=ff.HighestPeakElevation2
  ORDER BY ff.CountryName 