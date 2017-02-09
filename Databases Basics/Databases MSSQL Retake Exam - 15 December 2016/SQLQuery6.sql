SELECT Content,
       SentOn
  FROM Messages
  WHERE Content LIKE  '%just%' 
    AND SentOn>'2014-05-12'
	ORDER BY Id DESC