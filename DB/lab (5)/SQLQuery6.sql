USE aero
SELECT 'ряд: ' + LEFT(place,1) AS 'Ряди','місце: ' + RIGHT(place,9)
FROM Pass_in_trip;