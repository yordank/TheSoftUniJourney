--Problem 17.	Create View Employees with Job Titles
--Write a SQL query to create view V_EmployeeNameJobTitle with full employee name and job title. When middle name is NULL replace it with empty string (‘’). Submit your query statements as Run skeleton, run queries & check DB.
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName+
		' '+
		CASE 
			WHEN MiddleName is NULL THEN ''
			ELSE MiddleName
		END+
		' '+
		LastName 
		AS [FullName],
		JobTitle AS [Job Title]
		
 FROM Employees

