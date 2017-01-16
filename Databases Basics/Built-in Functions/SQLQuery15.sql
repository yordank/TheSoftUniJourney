--Problem 15.	 Show All Games with Duration and Part of the Day
--Find all games with part of the day and duration sorted by game name alphabetically then by duration and part of the day. Parts of the day should be Morning (time is >= 0 and < 12), Afternoon (time is >= 12 and < 18), Evening (time is >= 18 and < 24). Duration should be Extra Short (smaller or equal to 3), Short (between 4 and 6 including), Long (greater than 6) and Extra Long (without duration). Submit your query statements as Prepare DB & run queries.

SELECT Name,
		 
	   CASE 
	    WHEN DATEPART(hh,Start)<12 THEN 'Morning'	 
		WHEN DATEPART(hh,Start)<18 THEN 'Afternoon'	
		ELSE 'Evening'	 
		END
		AS [Part of the Day]
		,
		 CASE 
			  WHEN Duration<=3 THEN 'Extra Short'
			  WHEN Duration<=6 THEN 'Short'
			  WHEN Duration>6  THEN 'Long'
			  ELSE 'Extra Long'
		 END
		 AS Duration
		 
FROM Games
ORDER BY 1,3,2
