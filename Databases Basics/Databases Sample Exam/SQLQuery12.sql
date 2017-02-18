SELECT t.Name AS 'Town Name',
       ads.Status,
	   COUNT(ads.Id) AS Count
 FROM Ads AS a
 JOIN AdStatuses AS ads
   ON a.StatusId=ads.Id
 JOIN Towns AS t
   ON t.Id=a.TownId
GROUP BY t.Name,ads.Status
HAVING COUNT(ads.Id) >0
ORDER BY t.Name,ads.Status