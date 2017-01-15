--Problem 6.	Find Email Address of Each Employee
--Write a SQL query to find the email address of each employee. (by his first and last name). Consider that the email domain is softuni.bg. Emails should look like “John.Doe@softuni.bg". The produced column should be named "Full Email Address". Submit your query statements as Prepare DB & run queries.

SELECT FirstName+'.'+LastName+'@softuni.bg' AS [Full Email Address]
FROM Employees