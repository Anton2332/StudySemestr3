use computer
SELECT model ,maker FROM Product
WHERE type = 'PC' AND model IN 
	(SELECT model FROM PC WHERE price < 600);
