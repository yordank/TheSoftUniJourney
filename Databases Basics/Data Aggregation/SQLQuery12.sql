--Problem 12.	* Rich Wizard, Poor Wizard
--Mr. Bodrog definitely likes his werewolves more than you. This is your last chance to survive! Give him some data to play his favorite game Rich Wizard, Poor Wizard. The rules are simple: You compare the deposits of every wizard with the wizard after him. If a wizard is the last one in the database, simply ignore it. At the end you have to sum the difference between the deposits.

--At the end your query should return a single value: the SUM of all differences.

 SELECT SUM(t.DIFF) FROM (
SELECT -w1.DepositAmount +w2.DepositAmount AS DIFF
  FROM WizzardDeposits AS w1
  JOIN
   (
    SELECT Id,DepositAmount 
      FROM WizzardDeposits
   )AS w2
   ON w1.Id=w2.Id+1
   )AS t
   
 