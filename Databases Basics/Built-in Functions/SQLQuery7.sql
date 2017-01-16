--Problem 7.	 Find Towns Not Starting With
--Write a SQL query to find all towns that does not start with letters R, B or D. Order them alphabetically by name. Submit your query statements as Prepare DB & run queries.

SELECT TownID,Name
 FROM Towns
 WHERE NAME NOT LIKE '[RBD]%'
 ORDER BY Name