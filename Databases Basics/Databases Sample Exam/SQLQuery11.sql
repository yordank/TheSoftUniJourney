SELECT ads.Status,
       COUNT(ads.Id) AS Count
  FROM Ads AS a
  JOIN AdStatuses AS ads
    ON a.StatusId=ads.Id
 GROUP BY ads.Status
 ORDER BY ads.Status