	SELECT TOP 10 
	       Title,
		   Date,
		   ads.Status
	  FROM Ads AS a
	  JOIN AdStatuses AS ads
	    ON ads.Id=a.StatusId
	  ORDER BY Date DESC