SELECT --TOP 1
        tabl.Title,
		m.Content
  FROM
(SELECT TOP 1 
   * 
  FROM Chats
  ORDER BY StartDate DESC) AS tabl
  LEFT JOIN Messages AS m 
  ON  tabl.Id=m.ChatId
  ORDER BY m.SentOn