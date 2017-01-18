--Problem 8.	 Deposit charge
--Create a query that selects:
--•	Deposit group 
--•	Magic wand creator
--•	Minimum deposit charge for each group 
--Select the data in ascending order by MagicWandCreator and DepositGroup.

SELECT w.DepositGroup,
       w.MagicWandCreator,
	   MIN(w.DepositCharge)
  FROM WizzardDeposits AS w
 GROUP BY w.DepositGroup,w.MagicWandCreator
 ORDER BY w.MagicWandCreator,w.DepositGroup