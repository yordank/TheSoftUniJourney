--Problem 9.	Age Groups
--Write down a query that creates 7 different groups based on their age.
--Age groups should be as follows:
--•	[0-10]
--•	[11-20]
--•	[21-30]
--•	[31-40]
--•	[41-50]
--•	[51-60]
--•	[61+]
--The query should return
--•	Age groups
--•	Count of wizards in it

--Just Copied from --https://softuni.bg/downloads/svn/DB-Fundamentals/DB-Basics-MSSQL/Sept-2016/05.%20DB-Basics-MSSQL-Data-Aggregation/05.%20DB-Basics-MSSQL-Data-Aggregation-Exercises-Demo.sql


SELECT CASE
			WHEN Age <= 10 THEN '[0-10]'
			WHEN Age <= 20 THEN '[11-20]'
			WHEN Age <= 30 THEN '[21-30]'
			WHEN Age <= 40 THEN '[31-40]'
			WHEN Age <= 50 THEN '[41-50]'
			WHEN Age <= 60 THEN '[51-60]'
			ELSE '[61+]'
		END AS AgeGroup,
        COUNT(*) AS WizzardCount
   FROM [dbo].[WizzardDeposits]
  GROUP BY CASE
			WHEN Age <= 10 THEN '[0-10]'
			WHEN Age <= 20 THEN '[11-20]'
			WHEN Age <= 30 THEN '[21-30]'
			WHEN Age <= 40 THEN '[31-40]'
			WHEN Age <= 50 THEN '[41-50]'
			WHEN Age <= 60 THEN '[51-60]'
			ELSE '[61+]'
		END