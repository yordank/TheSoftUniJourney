		SELECT 
			   a.Id, 
			   Title,
			   Date,
			   ads.Status
			   
		  FROM Ads AS a
		  JOIN AdStatuses AS ads
			ON ads.Id=a.StatusId
		 WHERE ads.Status <>'Published'
		   AND MONTH(Date)=(SELECT MONTH(MIN(Date)) FROM Ads)
		   AND YEAR(Date)=(SELECT YEAR(MIN(Date)) FROM Ads) 
		 ORDER BY a.Id
		 
	   
	 