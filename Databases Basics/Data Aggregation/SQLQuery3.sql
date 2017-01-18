--Problem 3.	Longest Magic Wand per Deposit Groups
--For wizards in each deposit group show the longest magic wand. Rename the new column appropriately.
SELECT w.DepositGroup ,
	   MAX(w.MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits AS w
GROUP BY w.DepositGroup