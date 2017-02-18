	SELECT Title,
	       Date,
		   CASE 
		     WHEN ImageDataURL IS NULL THEN 'no'
			 ELSE 'yes'
           END AS 'Has Image'
	  FROM Ads
	 ORDER BY Id  