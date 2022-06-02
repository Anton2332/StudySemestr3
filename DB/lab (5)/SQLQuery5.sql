USE Ships

SELECT class FROM Ships WHERE name IN (
	SELECT ship FROM Outcomes WHERE result = 'sunk'
	) OR class IN (
	SELECT ship FROM Outcomes WHERE result = 'sunk'
	)