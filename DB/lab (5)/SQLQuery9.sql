USE computer
SELECT DISTINCT  p1.maker, 
	CASE p1.type
		WHEN 'Printer' THEN 'yes(' + 
		RIGHT(STR((SELECT COUNT(p2.model) FROM Product p2 JOIN Printer pr ON p2.model = pr.model GROUP BY p2.maker HAVING p2.maker = p1.maker)),1)
		+ ')'
		ELSE 'no'
	END AS printer
FROM Product p1
;