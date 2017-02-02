CREATE PROCEDURE usp_AssignProject(@emloyeeId INT, @projectID INT) 
AS
BEGIN

	DECLARE @maxEmployeeProjectsCount INT = 3
	DECLARE @employeeProjectsCount INT
	SET @employeeProjectsCount = (SELECT COUNT(*) 
					FROM [dbo].[EmployeesProjects] AS ep
				   WHERE ep.EmployeeId = @emloyeeId)


   
   
		 BEGIN TRAN

			INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
			VALUES (@emloyeeId, @projectID)

			IF(@employeeProjectsCount >= @maxEmployeeProjectsCount)
			BEGIN
		
				RAISERROR('The employee has too many projects!',16,1)
				ROLLBACK
			END
			ELSE
			BEGIN
				COMMIT
			END

	 
END

--EXEC usp_AssignProject 263,24