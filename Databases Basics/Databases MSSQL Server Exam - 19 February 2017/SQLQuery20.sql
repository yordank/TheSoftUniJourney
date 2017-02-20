
SELECT  
       ppp.Name,
	   AVG(f.Rate),
	   botevplovdiv.Distributor,
	   botevplovdiv.CountryName

 FROM Feedbacks AS f
right JOIN


(
SELECT botev.ProductId,
       botev.Distributor,
	   botev.CountryName
       
       
 FROM
(
SELECT tabl1.Id AS ProductId,
       tabl1.Distributor,
	   tabl1.CountryName,
       COUNT(*) AS countt
 FROM
(

SELECT p.Name AS ProductName,
       i.Name AS i,
	   d.Name AS Distributor,
	   ccc.Name AS CountryName,
       p.Id
  FROM Products AS p
  LEFT JOIN ProductsIngredients AS pp
    ON p.Id=pp.ProductId
  JOIN Ingredients AS i
    ON i.Id=pp.IngredientId
  JOIN Distributors AS d
    ON d.Id=i.DistributorId
  JOIN Countries AS ccc
    ON ccc.Id=d.CountryId
  		 
)AS tabl1



LEFT JOIN

(

SELECT p.Name AS ProductName,
       i.Name AS i,
	   d.Name AS Distributor
 
  FROM Products AS p
  LEFT JOIN ProductsIngredients AS pp
    ON p.Id=pp.ProductId
  JOIN Ingredients AS i
    ON i.Id=pp.IngredientId
  JOIN Distributors AS d
    ON d.Id=i.DistributorId
 	 
)AS tabl2
ON tabl1.ProductName=tabl2.ProductName
WHERE tabl1.Distributor=tabl2.Distributor
GROUP BY tabl1.Id,tabl1.Distributor,tabl1.CountryName
 

)
AS botev
JOIN

(
SELECT p.Id AS ProductId,
       COUNT(*)*COUNT(*) AS secondcount
 
  FROM Products AS p
  LEFT JOIN ProductsIngredients AS pp
    ON p.Id=pp.ProductId
  JOIN Ingredients AS i
    ON i.Id=pp.IngredientId
  JOIN Distributors AS d
    ON d.Id=i.DistributorId
 GROUP BY p.Id
 )AS plovdiv
 ON botev.ProductId=plovdiv.ProductId
 WHERE botev.countt=plovdiv.secondcount
 )
 AS botevplovdiv
 ON f.ProductId=botevplovdiv.ProductId
 JOIN Products AS ppp
 ON botevplovdiv.ProductId=ppp.Id
 GROUP BY botevplovdiv.ProductId,botevplovdiv.Distributor,ppp.Name,botevplovdiv.CountryName
 ORDER BY botevplovdiv.ProductId