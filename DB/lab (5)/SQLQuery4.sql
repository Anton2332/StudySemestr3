USE computer
SELECT p.maker FROM Product p
WHERE type = 'PC' AND model = ANY (
SELECT DISTINCT pc.model FROM PC pc
)
GROUP BY p.maker
HAVING COUNT(p.maker) = 
(
	SELECT COUNT(p2.maker) FROM Product p2
	WHERE p2.type = 'PC' AND p2.maker = p.maker
);