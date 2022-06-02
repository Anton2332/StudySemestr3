USE computer

SELECT DISTINCT pr2.maker ,(
	SELECT MAX(pri.price)
	FROM Product pr
	JOIN Printer pri ON pr.model = pri.model
	GROUP BY pr.maker
	HAVING pr2.maker = pr.maker
) AS MaxPrice
FROM Product pr2

;
