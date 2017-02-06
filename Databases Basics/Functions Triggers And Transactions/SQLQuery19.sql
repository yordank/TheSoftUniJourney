CREATE FUNCTION ufn_CashInUsersGames(@gameName VARCHAR(100))
RETURNS 
@rtnTable TABLE 
(
    -- columns returned by the function
   
    Cash MONEY NOT NULL
) 
AS
BEGIN

	DECLARE @Id INT=(
					SELECT Id 
					FROM GAMES
					WHERE Name=@gameName)
	INSERT INTO @rtnTable 
						SELECT SUM(tabl.Cash)
						FROM
						(
						SELECT 
						ROW_NUMBER() OVER(ORDER BY Cash DESC) AS Row#,
						Cash
						 FROM UsersGames
						WHERE GameId=@Id
						)AS tabl
						WHERE tabl.Row#%2=1


RETURN  
END

 