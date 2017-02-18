SELECT a.Title,
       c.Name AS CategoryName,
	   t.Name TownName,
	   ads.Status AS Status
  FROM Ads AS a
  JOIN Towns AS t
    ON a.TownId=t.Id
  JOIN Categories AS c
    ON c.Id=a.CategoryId
  JOIN AdStatuses AS ads
    ON ads.Id=A.StatusId
 WHERE t.Name IN ('Sofia','Blagoevgrad','Stara Zagora')
   AND ads.Status='Published'
 ORDER BY a.Title

 