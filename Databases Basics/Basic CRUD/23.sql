--Problem 23.	 Biggest Countries by Population
--Find the 30 biggest countries by population from Europe. Display the country name and population. Sort the results by population (from biggest to smallest), then by country alphabetically. Submit your query statements as Prepare DB & run queries.
SELECT TOP 30 c.CountryName  ,
	   c.Population
FROM Countries AS c
WHERE c.ContinentCode='EU'
ORDER BY c.Population DESC,c.CountryName
