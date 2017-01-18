--Problem 7.	Deposits Filter
--Select all deposit groups and its total deposit sum but only for the wizards who has their magic wand crafted by Ollivander family. After this filter total deposit amounts lower than 150000. Order by total deposit amount in descending order.
SELECT w.DepositGroup,
	   SUM(w.DepositAmount) AS TotalSum	 
  FROM WizzardDeposits AS w
 WHERE MagicWandCreator='Ollivander family'
 GROUP BY w.DepositGroup
HAVING SUM(w.DepositAmount)<150000
 ORDER BY SUM(w.DepositAmount) DESC
 