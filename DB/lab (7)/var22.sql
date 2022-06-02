CREATE DATABASE LAB_10

GO
USE LAB_10

CREATE TABLE Student
(
	StudID      int   NOT NULL PRIMARY KEY,
	GroupId     int   NOT NULL,
	FirstName   nchar(50) NULL, 
	LastName    nchar(50) NULL,
    DateOfBirth DateTime
)

CREATE TABLE Learn
(
	PredmetID   int   NOT NULL PRIMARY KEY,
	TeacherName nchar(50) NULL,
	HoursCount  int       NULL
)

CREATE TABLE Subject_Success
(
	StudID    int   NOT NULL,
	PredmetID int   NOT NULL,
	Rating    float NULL

	PRIMARY KEY (StudID, PredmetID)

	FOREIGN KEY (StudID)    REFERENCES Student(StudID),
	FOREIGN KEY (PredmetID) REFERENCES Learn(PredmetID)

)
GO
--INSERTS--
INSERT Student (StudID, GroupId, FirstName, LastName, DateOfBirth)
	VALUES
		(1, 3, 'FirstName1',    'LastName1',1999-08-20),
		(2, 3, 'FirstName2',    'LastName2',1999-01-19),
		(3, 2, 'FirstName3',    'LastName3',1999-08-23),
		(4, 2, 'FirstName4',    'LastName4',1999-08-20),
		(5, 1, 'FirstName5',    'LastName5',1999-09-13),
		(6, 1, 'FirstName6',    'LastName6',2003-05-29),
		(7, 4, 'FirstName7',    'LastName7',1999-04-04),
		(8, 4, 'FirstName8',    'LastName8',2000-03-30)
GO
INSERT Learn (PredmetID, TeacherName, HoursCount)
	VALUES
		('JS', 'TeacherName1', 120),
		('ООП', 'TeacherName2', 125),
		('Python', 'TeacherName3',  200),
		('Теорія ймовірності', 'TeacherNam4', 300),
		('Вища математика', 'TeacherName5',   360)
GO
INSERT Subject_Success (StudID, PredmetID, Rating)
	VALUES
		(1, 'Python', '5'),
		(1,'Вища математика' ,'3'),
		(2, 'Python', '5'),
		(2, 'Вища математика', '2'),
		(3, 'ООП', '5'),
		(3, 'Python', '5'),
		(4, 'ООП', '2'),
		(4, 'JS', '2'),
		(4, 'Python', '2'),
		(5, 'Вища математика', '2'),
		(5, 'ООП', '2'),
		(5, 'Python', '2'),
		(6, 'Вища математика', '3'),
		(6, 'ООП', '4'),
		(6, 'Python', '5'),
		(7, 'Теорія ймовірності', '2'),
		(7, 'ООП', '2'),
		(7, 'JS', '4'),
		(8, 'Теорія ймовірності', '2'),
		(8, 'ООП', '5'),
		(8, 'JS', '5')

GO



USE LAB_10
GO

--Завдання 1--
SELECT * FROM Student
GO

--Завдання 2--
SELECT * FROM Learn
WHERE HoursCount BETWEEN 130 AND 300
GO

--Завдання 3--
SELECT * FROM Student
WHERE MONTH(DateOfBirth) > 04 AND MONTH(DateOfBirth) < 09
GO

--Завдання 4--
SELECT * FROM Student
WHERE LastName LIKE '%ов'
GO

--Завдання 5--
SELECT GroupID,COUNT(*) FROM Student
GROUP BY GroupID
ORDER BY COUNT(*)
GO

--Завдання 6--
SELECT StudID,AVG(CAST(Rating AS float)) FROM Subject_Success
GROUP BY StudID
GO

--Завдання 7--
SELECT st.FirstName + ' ' + st.LastName, l.PredmetID,l.TeacherName,su.Rating FROM Student st,Learn l,Subject_Success su
WHERE su.PredmetId = l.PredmetID AND su.StudID = st.StudID
GO

--Завдання 8--
INSERT INTO Student (StudId,GroupID,FirstName,LastName,DateOfBirth)
VALUES 
	(10,'144','FirstName11','LastName11','20015-11-11'),
	(11,'144','FirstName12','LastName11','1985-11-11')
GO
INSERT INTO Subject_Success(StudID,PredmetId,Rating)
VALUES 
	(3,'ООП','1'),
	(3,'JS','1')
GO

INSERT INTO Learn(PredmetID,TeacherName,HoursCount)
VALUES 
	('ООП4','RoW',100)
GO

UPDATE Learn SET HoursCount = 495 WHERE PredmetID = 'JS'
GO

--Завдання 9--
DELETE FROM Subject_Success
GO

DELETE FROM Subject_Success
WHERE StudID IN 
(
SELECT StudID FROM Subject_Success s2
WHERE Rating = '2'
GROUP BY StudID
HAVING COUNT(*) > 2
)
GO

SELECT * FROM Subject_Success
ORDER BY Rating
GO

--Завдання 10--
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