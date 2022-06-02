CREATE DATABASE LAB45VAR22
--ON PRIMARY
--(NAME = LAB81,FILENAME = 'D:\lab_8_dat.mdf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20)
--LOG ON
--(NAME = LAB81_log,FILENAME = 'D:\lab_8_log.ldf',SIZE = 100MB, MAXSIZE = 200, FILEGROWTH = 20)
GO
USE LAB45VAR22
GO
CREATE TABLE Familni_tsinosti
(
	Nazva_tsinosti nvarchar(50) NOT NULL,
	Orient_vart float NULL,
	Max_vart float NULL,
	Min_vart float NULL,
	Kod_in_katalog int NULL,
	Kod as 
	(
	SOUNDEX(Nazva_tsinosti)
	)
	PRIMARY KEY(Nazva_tsinosti),
	CONSTRAINT CHK_2
	CHECK 
	(
		Max_vart >= Min_vart
	)
)
create unique index AK_unik_ind1
	on Familni_tsinosti(Kod_in_katalog)
GO



CREATE TABLE Fam_ders
(
	Prizv nvarchar(50) NOT NULL,
	Im nvarchar(50) NOT NULL,
	Data_nar date NOT NULL,
	Data_sm date NULL,
	Mists_nar nvarchar(50) NULL,
	Mists_sm nvarchar(50) NULL,
	Nom_cred_card nvarchar(50) NULL,
	PRIMARY KEY(Prizv,Im),

	CONSTRAINT CHK_1   
	CHECK 
	(
		Nom_cred_card like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
	)
)
create index іnd1
	on Fam_ders(Nom_cred_card)
GO

Create table Volodin
(
	Kod int NOT NULL,
	Prizv nvarchar(50) NOT NULL,
	Im nvarchar(50) NOT NULL,
	Nazva_tsinosti nvarchar(50) NOT NULL,
	primary key(Kod),
	FOREIGN KEY(Prizv,Im) REFERENCES Fam_ders (Prizv,Im),
	FOREIGN KEY(Nazva_tsinosti) REFERENCES Familni_tsinosti(Nazva_tsinosti),
	
)
GO

CREATE TABLE Sim_suputn
(
	Prizv nvarchar(50) NOT NULL,
	Im nvarchar(50) NOT NULL,
	Data_nar date NOT NULL,
	Data_sm date NULL,
	Mists_nar nvarchar(50) NULL,
	Mists_sm nvarchar(50) NULL,
	Data_od date NOT NULL,
	Pr_im as (Im + ' ' + Prizv+'народ.' + cast(DATEPART(dayofyear,Data_nar) as nvarchar(10)) + 'дня '
	+ cast(year(Data_nar) as nvarchar(10)) +'р. від різдва Христового')
	PRIMARY KEY(Prizv,Im),
	FOREIGN KEY(Prizv,Im) REFERENCES Fam_ders (Prizv,Im)
)
create index іnd2
	on Sim_suputn(Mists_nar)
GO

