USE computer
SELECT pr.maker,pri.price
FROM Product pr JOIN Printer pri ON pr.model = pri.model
WHERE pri.price = (
	SELECT MIN(price) FROM Printer
)

;