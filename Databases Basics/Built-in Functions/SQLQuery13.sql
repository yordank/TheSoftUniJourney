--Problem 13.	 User Email Providers
--Find all users along with information about their email providers. Display the username and email provider. Sort the results by email provider alphabetically, then by username. Submit your query statements as Prepare DB & run queries.

SELECT 
u.Username,
SUBSTRING(u.Email,CHARINDEX('@',u.Email,1)+1,LEN(u.Email)-CHARINDEX('@',u.Email)) AS [Email Provider]
FROM Users AS u
ORDER BY 2,1