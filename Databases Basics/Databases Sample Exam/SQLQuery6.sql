SELECT a.Title,
       c.Name AS CategoryName,
	   t.Name AS TownName,
	   ads.Status
  FROM Ads AS a
  LEFT JOIN Categories AS c
    ON a.CategoryId=c.Id
  LEFT JOIN Towns AS t
    ON t.Id=a.TownId
  LEFT JOIN AdStatuses AS ads
    ON ads.Id=a.StatusId