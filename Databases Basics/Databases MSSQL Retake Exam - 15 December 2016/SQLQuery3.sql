UPDATE cc
SET cc.StartDate=MM.SentOn

FROM Messages AS MM
JOIN Chats AS cc
  ON MM.ChatId=cc.Id
WHERE cc.StartDate>MM.SentOn



