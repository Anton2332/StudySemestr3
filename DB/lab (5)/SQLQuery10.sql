USE Ships
SELECT COUNT(*) AS countShips,class FROM Ships
GROUP BY class
HAVING COUNT(*) = 1 OR COUNT(*) = 2
UNION
SELECT COUNT(*),O1.ship
FROM Outcomes O1
WHERE NOT EXISTS
(
	SELECT O2.ship FROM Outcomes O2 
	RIGHT JOIN Ships sh2 ON sh2.name = O2.ship
	WHERE O1.ship = sh2.name
)
GROUP BY O1.ship
HAVING COUNT(*) = 1 OR COUNT(*) = 2
ORDER BY countShips
;
