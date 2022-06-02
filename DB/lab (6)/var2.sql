CREATE DATABASE LAB8VAR2--��������� ���� ����� � ��'�� LAB8VAR2
--ON PRIMARY
--(NAME = LAB81,FILENAME = 'D:\lab_8_dat.mdf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20) --��������� ����� ���� �����
--LOG ON
--(NAME = LAB81_log,FILENAME = 'D:\lab_8_log.ldf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20) -- ��������� ����� ��������� 
GO
USE LAB8VAR2 -- �� ��������� ����� use �������� ��������������� ���� ����� �� ������ LAB8VAR2
GO
CREATE TABLE Table_Kafedra -- ��������� �������� �� ������ Table_Kafedra
(
	ID_Kafedra int NOT NULL,--����������� �������� � ������ ID_Kafedra � ������������� ����� �����(int) ��� ��������� �������� null ��������(NOT NULL)
	ID_Teacher_Zav_Kaf int NOT NULL, -- ���� ���� �� ��������
	Name_Kafedra nchar(255) NULL, --����� �������� � ���������� ����� ����� � ���������� � 255 ������� � ��������� �������� null �������
	Phone_Kafedra nchar(13) NULL,--������ �� ������������ ����� � ���������� � 13 ������� � ��������� �������� null �������
	PRIMARY KEY(ID_Kafedra) -- ������ ���� �������� �������� ���� � �������� ��������� �����
)
GO
CREATE TABLE Table_Grupa -- ��������� �������� �� ������ Table_Grupa
(
	ID_Grupa int NOT NULL,
	ID_Kafedra int NULL,
	Name_Grupe nchar(10) NULL,
	Max_count_students int NULL,
	Pball float NULL,--�������� � ��������� �������� ��������� �������� �� null ��������
	PRIMARY KEY(ID_Grupa),-- ������ ���� �������� �������� ���� � �������� ��������� �����
	FOREIGN KEY(ID_Kafedra) REFERENCES Table_Kafedra (ID_Kafedra)--������ ���� �������� ������� ���� � ��������� ����� � ���� ��������
	-- �������� �������� � ����� �������� ����� ���� �� ������� ���� REFERENCES ����� � � ������ ����� ������� ���� �� ������ 
)
GO
CREATE TABLE Table_Student -- ��������� �������� �� ������ Table_Student
(
	ID_Student int NOT NULL,
	ID_Grupa int NULL,
	Number int NULL,
	First_name_student nchar(50) NULL,
	Last_name_student nchar(50) NULL,
	Birth_date_student date NULL,--��������� �������� � ���� �� ������� ����
	Adress_student nchar(255) NULL,
	Pball_student float NULL,
	PRIMARY KEY(ID_Student),
	FOREIGN KEY(ID_Grupa) REFERENCES Table_Grupa(ID_Grupa)
)
GO

INSERT Table_Kafedra -- INSERT ������� ����� ��� ��������� ���������� ������� � �������
	(ID_Kafedra,ID_Teacher_Zav_Kaf,Name_Kafedra,Phone_Kafedra) --������ �������� � �� ������ ����������� ���
	VALUES -- ������� ����� ���� ����� ������� ������ ���
	(1,1,'1','+380999999999'),-- ��� �� �� ���������� � ������� ������� � ����� �� ������� ������ �������� 
	(2,2,'2','+380999999999'),
	(3,3,'3','+380999999999'),
	(4,4,'4','+380999999999'),
	(5,5,'5','+380999999999')
GO

INSERT Table_Grupa
	(ID_Grupa,ID_Kafedra,Name_Grupe,Max_count_students,Pball)
	VALUES
	(1,1,'Name1',15,5),
	(2,2,'Name2',25,3),
	(3,3,'Name3',35,5),
	(4,4,'Name4',40,4),
	(5,5,'Name5',50,3)
GO

INSERT Table_Student
	(ID_Student,ID_Grupa,Number,First_name_student,
	Last_name_student,Birth_date_student,
	Adress_student,	Pball_student)
	VALUES
	(1,1,1,'Firstname1','Lastname1','2000-01-12','adr1',4.1),
	(2,2,2,'Firstname2','Lastname2','2000-01-13','adr2',5),
	(3,3,3,'Firstname3','Lastname3','2000-01-14','adr3',3.9),
	(4,4,4,'Firstname4','Lastname4','2000-01-25','adr4',3.3),
	(5,5,5,'Firstname5','Lastname5','2000-01-15','adr5',3.2)
GO

select * From Table_Kafedra--���� �� �������� � �������
select * from Table_Grupa
select * from Table_Student
GO