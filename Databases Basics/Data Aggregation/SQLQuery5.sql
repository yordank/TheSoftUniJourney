--Problem 5.	Deposits Sum
--Select all deposit groups and its total deposit sum.

SELECT w.DepositGroup,SUM(w.DepositAmount)
  FROM WizzardDeposits AS w
 GROUP BY w.DepositGroup 