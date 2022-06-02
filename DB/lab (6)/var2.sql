CREATE DATABASE LAB8VAR2--створюємо базу даних з ім'ям LAB8VAR2
--ON PRIMARY
--(NAME = LAB81,FILENAME = 'D:\lab_8_dat.mdf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20) --Розмішення файлу бази даних
--LOG ON
--(NAME = LAB81_log,FILENAME = 'D:\lab_8_log.ldf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20) -- розмішення файлу логування 
GO
USE LAB8VAR2 -- за допомогою слова use починаємо використовувати базу диних під назвою LAB8VAR2
GO
CREATE TABLE Table_Kafedra -- створюємо таблючку під назвою Table_Kafedra
(
	ID_Kafedra int NOT NULL,--створюється стовбець з назвою ID_Kafedra з цілочисельним типом даних(int) без можливості введення null значення(NOT NULL)
	ID_Teacher_Zav_Kaf int NOT NULL, -- таке саме як попереднє
	Name_Kafedra nchar(255) NULL, --тепер стовбець з символьним типом даних з обмеженням в 255 символів з можливістю введення null значень
	Phone_Kafedra nchar(13) NULL,--подібне до попереднього тільки з обмеженням в 13 символів з можливістю введення null значень
	PRIMARY KEY(ID_Kafedra) -- задаємо даній табличці первиний ключ з стовбців створених раніше
)
GO
CREATE TABLE Table_Grupa -- створюємо таблючку під назвою Table_Grupa
(
	ID_Grupa int NOT NULL,
	ID_Kafedra int NULL,
	Name_Grupe nchar(10) NULL,
	Max_count_students int NULL,
	Pball float NULL,--стовбесь з можливістю введення дробового значення та null значення
	PRIMARY KEY(ID_Grupa),-- задаємо даній табличці первиний ключ з стовбців створених раніше
	FOREIGN KEY(ID_Kafedra) REFERENCES Table_Kafedra (ID_Kafedra)--задаємо даній табличці зовнішній ключ з створених раніше в даній табличці
	-- значення береться з іншой таблючці назву який ми вказуємо після REFERENCES назва і в душках назву стовбця який ми беремо 
)
GO
CREATE TABLE Table_Student -- створюємо таблючку під назвою Table_Student
(
	ID_Student int NOT NULL,
	ID_Grupa int NULL,
	Number int NULL,
	First_name_student nchar(50) NULL,
	Last_name_student nchar(50) NULL,
	Birth_date_student date NULL,--створюємо стовбець в який ми вказуємо дату
	Adress_student nchar(255) NULL,
	Pball_student float NULL,
	PRIMARY KEY(ID_Student),
	FOREIGN KEY(ID_Grupa) REFERENCES Table_Grupa(ID_Grupa)
)
GO

INSERT Table_Kafedra -- INSERT ключове слово для можливості вставлення значень в таблицю
	(ID_Kafedra,ID_Teacher_Zav_Kaf,Name_Kafedra,Phone_Kafedra) --перелік стовбців в які будуть вставлятись дані
	VALUES -- ключове слово після якого вписуємо вставні дані
	(1,1,'1','+380999999999'),-- дані які ми вставляємо в такомуж порядку в якому ми вказали перелік стовбців 
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

select * From Table_Kafedra--вивід всі значення з таблиці
select * from Table_Grupa
select * from Table_Student
GO