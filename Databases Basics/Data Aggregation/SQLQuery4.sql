--  Problem 4.	* Smallest Deposit Group per Magic Wand Size
--Select the deposit group with the lowest average wand size.

  SELECT DepositGroup
    FROM WizzardDeposits  
   GROUP BY DepositGroup
  HAVING AVG(MagicWandSize)= 
                    (SELECT MIN(t.avr) 
					   FROM (SELECT  DepositGroup,
					                 AVG(MagicWandSize) AS avr
                               FROM WizzardDeposits AS w
                              GROUP BY DepositGroup 
                     )    AS t)
