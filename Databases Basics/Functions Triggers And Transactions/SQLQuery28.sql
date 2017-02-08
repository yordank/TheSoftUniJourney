INSERT INTO UserGameItems
SELECT Id,235
 FROM Items 
WHERE Name IN('Blackguard','Bottomless Potion of Amplification','Eye of Etlich (Diablo III)','Gem of Efficacious Toxin','Golden Gorget of Leoric','Hellfire Amulet') 

--SELECT * FROM UsersGames
--WHERE UserId=5 AND GameId=221 

--SELECT * FROM UserGameItems
--WHERE UserGameId=235

UPDATE UsersGames
SET Cash=(SELECT CASH FROM UsersGames WHERE UserId=5 AND GameId=221)-(
SELECT SUM(Price) AS PRICE
 FROM Items 
WHERE Name IN('Blackguard','Bottomless Potion of Amplification','Eye of Etlich (Diablo III)','Gem of Efficacious Toxin','Golden Gorget of Leoric','Hellfire Amulet'))
WHERE UserId=5 AND GameId=221 


SELECT u.Username,
       g.Name,
	   ug.Cash,
	   i.Name
  FROM UserGameItems AS ugi
  JOIN UsersGames AS ug
    ON ugi.UserGameId=ug.Id
  JOIN Users AS u
    ON ug.UserId=u.Id
  JOIN Games AS g
    ON g.Id=ug.GameId
  JOIN Items AS i
    ON i.Id=ugi.ItemId
 WHERE g.Name='Edinburgh'
 ORDER BY i.Name ASC
 