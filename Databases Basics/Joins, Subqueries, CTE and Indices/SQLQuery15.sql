SELECT t1.ContinentCode,
        t1.CurrencyCode,
		t2.CurrencyUsage
   FROM 
		(SELECT c.ContinentCode,
		        c.CurrencyCode,
				COUNT(*) AS Count
		   FROM Countries AS c
           
		  
          GROUP BY c.ContinentCode,c.CurrencyCode
		)AS t1

    LEFT JOIN
  
       (
        SELECT tt.ContinentCode,
		       MAX(tt.Count) AS CurrencyUsage 
	      FROM 
			  (
				SELECT c.ContinentCode,
					   c.CurrencyCode,
					   COUNT(*) AS Count
				FROM Countries AS c
		  	   GROUP BY c.ContinentCode,c.CurrencyCode
			  ) AS tt
        GROUP BY ContinentCode 
 
		)AS t2
    ON t1.ContinentCode=t2.ContinentCode
 WHERE Count=CurrencyUsage AND Count>1
 ORDER BY ContinentCode