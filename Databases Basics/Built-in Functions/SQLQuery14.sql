--Problem 14.	 Get Users with IPAdress Like Pattern
--Find all users along with their IP addresses sorted by username alphabetically. Display only rows that IP address matches the pattern: “***.1^.^.***”. Submit your query statements as Prepare DB & run queries.
--Legend: * - one symbol, ^ - one or more symbols

SELECT
	 U.Username,
	 U.IpAddress
 FROM Users AS U
 WHERE 
	 U.IpAddress LIKE '___.1_%._%.___'
ORDER BY U.Username