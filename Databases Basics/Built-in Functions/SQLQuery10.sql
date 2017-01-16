--Problem 10.	Countries Holding ‘A’ 3 or More Times
--Find all countries that holds the letter 'A' in their name at least 3 times (case insensitively), sorted by ISO code. Display the country name and ISO code. Submit your query statements as Prepare DB & run queries.

SELECT c.CountryName,c.IsoCode
 FROM Countries AS c
WHERE c.CountryName LIKE '%a%a%a%'
ORDER BY c.IsoCode 