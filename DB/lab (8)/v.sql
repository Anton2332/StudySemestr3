USE LAB_10
GO

CREATE PROC proc12
(@a INT = 3,@b NVARCHAR(50) = 'ООП',@c NVARCHAR(50) = '2')
AS
INSERT INTO Subject_Success(StudID,PredmetId,Rating)
VALUES 
	(@a,@b,@c)
GO

EXEC proc12 @a = 1, @b = 'JS', @c = '1'
GO

CREATE PROC proc13
AS
DELETE FROM Subject_Success
WHERE StudID IN 
(
SELECT StudID FROM Subject_Success s2
WHERE Rating = '2'
GROUP BY StudID
HAVING COUNT(*) > 2
)
GO

EXEC proc13
GO

CREATE PROC proc14
AS
UPDATE Subject_Success
SET Rating = 'Перездача'
WHERE StudID IN 
(
SELECT StudID FROM Subject_Success s2
WHERE Rating = '2'
GROUP BY StudID
HAVING COUNT(*) < 3
) AND Rating = '2'
GO

EXEC proc14
GO


CREATE PROC proc21
AS
CREATE TABLE TheBestOfTheBest
(
	FullName nvarchar(100) null,
	GroupId int null,
	PredmetId nvarchar(50) null,
	TeacherName nchar(50) null
)
INSERT INTO TheBestOfTheBest
SELECT Student.FirstName + ' ' + Student.LastName AS FullName,Student.GroupId,Subject_Success.PredmetID
,Learn.TeacherName
FROM Student INNER JOIN 
(
Learn INNER JOIN Subject_Success 
ON Learn.PredmetID = Subject_Success.PredmetID
)
ON Student.StudID = Subject_Success.StudID
WHERE Student.StudID IN 
(SELECT TOP(5) StudID FROM Subject_Success
GROUP BY StudID
ORDER BY AVG(CAST(Rating AS float)) DESC) AND Subject_Success.Rating = 
(
SELECT MAX(CAST(Rating AS float)) FROM Subject_Success
WHERE Student.StudID = Subject_Success.StudID
)
GO

EXEC proc21
GO

CREATE PROC proc31
(@a NVARCHAR(50),@b NCHAR(50) ,@c INT)
AS
INSERT INTO Learn(PredmetID,TeacherName,HoursCount)
VALUES 
	(@a,@b,@c)
GO

EXEC proc31 @a = '',@b = '',@c = 25
GO

CREATE PROC proc41
(@a NVARCHAR(50),@b NCHAR(50) ,@c INT)
AS
UPDATE Learn
SET HoursCount = @c
WHERE TeacherName = @b AND PredmetID = @a
GO

EXEC proc41 @a = '',@b = '',@c = 0
GO
