SELECT p.Title,
       a.Name
  FROM AlbumsPhotographs AS ap
  JOIN Albums AS a
    ON a.Id=ap.AlbumId
  JOIN Photographs AS p
    ON p.Id=ap.PhotographId
 ORDER BY a.Name ASC,p.Title DESC
