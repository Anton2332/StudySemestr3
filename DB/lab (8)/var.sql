USE LAB_10
GO

CREATE PROC my_proc1_2
(@a INT = 3,@b NVARCHAR(50) = 'ООП',@c NVARCHAR(50) = '2')
AS
INSERT INTO Subject_Success(StudID,PredmetId,Rating)
VALUES 
	(@a,@b,@c)
GO

EXEC my_proc1_2 @a = 1, @b = 'ООП', @c = '1'
GO

CREATE PROC my_proc1_3
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

EXEC my_proc1_3
GO

CREATE PROC my_proc1_4
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

EXEC my_proc1_4
GO

DROP PROC my_proc2_1
GO

CREATE PROC my_proc2_1
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
(Learn INNER JOIN Subject_Success ON Learn.PredmetID = Subject_Success.PredmetID)
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

EXEC my_proc2_1
GO

CREATE PROC my_proc3_1
(@a NVARCHAR(50),@b NCHAR(50) ,@c INT)
AS
INSERT INTO Learn(PredmetID,TeacherName,HoursCount)
VALUES 
	(@a,@b,@c)
GO

EXEC my_proc3_1 @a = '',@b = '',@c = 25
GO

CREATE PROC my_proc4_1
(@a NVARCHAR(50),@b NCHAR(50) ,@c INT)
AS
UPDATE Learn
SET HoursCount = @c
WHERE TeacherName = @b AND PredmetID = @a
GO

EXEC my_proc4_1 @a = '',@b = '',@c = 0
GO

DROP TRIGGER my_trig5_1
GO

CREATE TRIGGER my_trig5_1
ON Learn
AFTER INSERT,UPDATE
AS
BEGIN
	DECLARE @d int, @d2 int
	select @d = 500,@d2 = 1000
	if(@d <= ANY 
	(
	SELECT SUM(HoursCount) FROM Learn 
	GROUP BY TeacherName)
	)
	BEGIN
	ROLLBACK TRAN
	EXEC my_proc3_1 @a = '9',@b = '1',@c = 1
	END
	if(@d2 <= ANY 
	(
	SELECT SUM(HOURSCOUNT) FROM Learn l 
	INNER JOIN Subject_Success 
	ON l.PredmetID = Subject_Success.PredmetID
	GROUP BY Subject_Success.StudID
	)
	)
	BEGIN
	ROLLBACK TRAN
	EXEC my_proc3_1 @a = '8',@b = '2',@c = 2
	END
END
GO
INSERT INTO Learn(PredmetID,TeacherName,HoursCount)
VALUES 
	('ООП4','RoW',100)
GO

UPDATE Learn SET HoursCount = 495 WHERE PredmetID = 'JS'
GO

CREATE TRIGGER my_trig5_2
ON Subject_Success
AFTER INSERT,UPDATE
AS
BEGIN
	DECLARE @d int
	select @d = 1000
	if(@d <= ANY 
	(
	SELECT SUM(HOURSCOUNT) FROM Learn l 
	INNER JOIN Subject_Success 
	ON l.PredmetID = Subject_Success.PredmetID
	GROUP BY Subject_Success.StudID
	)
	)
	BEGIN
	ROLLBACK TRAN
	EXEC my_proc3_1 @a = '2',@b = '2',@c = 2
	END
END
GO
