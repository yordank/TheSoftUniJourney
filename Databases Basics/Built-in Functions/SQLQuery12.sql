--Problem 12.	Games from 2011 and 2012 year
--Find the top 50 games ordered by start date, then by name of the game. Display only games from 2011 and 2012 year. Display start date in the format “YYYY-MM-DD”. Submit your query statements as Prepare DB & run queries.

SELECT TOP (50)
	 [Name],
	 FORMAT([Start],'yyyy-MM-dd') AS [Start]
 FROM Games AS g
 WHERE YEAR(g.[Start]) BETWEEN 2011 AND 2012 
 ORDER BY g.[Start],[Name]