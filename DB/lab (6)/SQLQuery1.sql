CREATE DATABASE LAB_81
ON PRIMARY
(
  NAME = LAB81,
  FILENAME = 'D:\my program\Бази даних\SQL DB\8\lab_8_dat.mdf',
  SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20
)
LOG ON
(
  NAME = LAB81_log,
  FILENAME = 'D:\my program\Бази даних\SQL DB\8\lab_8_log.ldf',
  SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20
)
GO
USE LAB_81
GO
CREATE TABLE Table_Subject
(
	ID_Subject int NOT NULL ,
	Name_subject nchar(255) NULL,
	Projram_subject nvarchar(MAX) NULL
)
GO
CREATE TABLE Table_Type_Exam
(
	ID_Type_Exam int NOT NULL,
	Name_Type_Exam nchar(50) NULL
)
GO
CREATE TABLE Table_Subject_Success
(
	ID_Student int NOT NULL,
	ID_Subject int NOT NULL,
	ID_Type_Exam int NOT NULL,
	Mark float NULL
)
GO

ALTER TABLE Table_Subject
ADD 
PRIMARY KEY (ID_Subject)
GO

ALTER TABLE Table_Type_Exam
ADD 
PRIMARY KEY (ID_Type_Exam)
GO

ALTER TABLE Table_Subject_Success
ADD 
PRIMARY KEY (ID_Student,ID_Type_Exam,ID_Subject)
GO

ALTER TABLE Table_Subject_Success
ADD 
FOREIGN KEY (ID_Subject) REFERENCES Table_Subject (ID_Subject),
FOREIGN KEY (ID_Type_Exam) REFERENCES Table_Type_Exam (ID_Type_Exam)
GO

INSERT Table_Subject
	(ID_Subject,Name_subject,Projram_subject)
	VALUES
	(1,'ООП','Тема 1'),
	(2,'C++','Тема 2'),
	(3,'JS','Тема 3'),
	(4,'Теорія ймовірності','Тема 4'),
	(5,'ОБДтаЗ','Тема 5')
GO

INSERT Table_Type_Exam
	(ID_Type_Exam,Name_Type_Exam)
	VALUES
	(1,'ООП екзамен'),
	(2,'C++ екзамен'),
	(3,'JS екзамен'),
	(4,'Теорія ймовірності екзамен'),
	(5,'ОБДтаЗ екзамен')
GO

INSERT Table_Subject_Success
	(ID_Student,ID_Subject,ID_Type_Exam,Mark)
	VALUES
	(1,1,1,3.4),
	(2,2,2,3.7),
	(3,3,3,4.1),
	(4,4,4,3.2),
	(5,5,5,4.6)
GO

--select * From Table_Subject2
--select * from Table_Type_Exam2
--select * from Table_Subject_Success2
--GO