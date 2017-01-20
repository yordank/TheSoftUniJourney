 


 SELECT t1.ContinentCode,
        t1.CurrencyCode,
		t2.CurrencyUsage
   FROM 
		(SELECT c.ContinentCode,
		        cur.CurrencyCode,
				COUNT(*) AS Count
		   FROM Countries AS c
           
		   LEFT JOIN Currencies AS cur
             ON c.CurrencyCode=cur.CurrencyCode
          GROUP BY c.ContinentCode,cur.CurrencyCode
		)AS t1

    LEFT JOIN
  
       (
        SELECT tt.ContinentCode,
		       MAX(tt.Count) AS CurrencyUsage 
	      FROM 
			  (
				SELECT c.ContinentCode,
					   cur.CurrencyCode,
					   COUNT(*) AS Count
				FROM Countries AS c
				
				LEFT JOIN Currencies AS cur
				  ON c.CurrencyCode=cur.CurrencyCode
			   GROUP BY c.ContinentCode,cur.CurrencyCode
			  ) AS tt
        GROUP BY ContinentCode 
 
		)AS t2
    ON t1.ContinentCode=t2.ContinentCode
 WHERE Count=CurrencyUsage AND Count>1
 ORDER BY ContinentCode