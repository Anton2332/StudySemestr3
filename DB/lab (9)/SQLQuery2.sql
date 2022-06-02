USE Lab_11
GO


DECLARE @d int
select @d = 1
select * from Автомобіл
where Марка = @d
GO

DECLARE @c1 float,@c2 float
select @c1 = 1000000,@c2 = 1500000
select * from Автомобіл
where Вартість >= @c1 and Вартість <= @c2
GO


DECLARE @p1 float,@p2 float
select @p1 = 400,@p2 = 600
select * from Автомобіл
where [Вартість прокату] >= @p1 and [Вартість прокату] <= @p2
GO

DECLARE @r int
select @r = 2000
select * from Автомобіл
where year([Рік випуску]) = @r
GO

DECLARE @a int
select @a= 1
select [Код авто], [Код клієнту], Штраф from [Видані авто] в inner join Автомобіл а
on в.[Код авто] = а.[Код автомобіля]
where в.[Код авто] = @a and в.Штраф is not null
GO

DECLARE @a int
select @a= 2
select [Код авто], [Код клієнту], Штраф from [Видані авто] в inner join Автомобіл а
on в.[Код авто] = а.[Код автомобіля]
where в.[Код клієнту] = @a and в.Штраф is not null
GO


CREATE PROC Proc_For_Lab_12_1
(@d INT = 1)
AS
select Автомобіл.[Код автомобіля],Автомобіл.[Рік випуску],Типи.[Назва типу],Автомобіл.Вартість,Автомобіл.[Вартість прокату],[Марка авто].[Назва марки], [Моделі авто].[Назва моделі] from Автомобіл,[Марка авто],[Моделі авто],Типи
where Марка = @d and [Марка авто].[Код моделі] = [Моделі авто].[Код моделі] and [Марка авто].[Код марки] = Автомобіл.[Код автомобіля] and Типи.[Код типу] = Автомобіл.Тип
GO

EXEC Proc_For_Lab_12_1
GO


CREATE PROC Proc_For_Lab_12_2
(@с1 float = 1000000, @c2 float = 1500000)
AS
select Автомобіл.[Код автомобіля],Автомобіл.[Рік випуску],Типи.[Назва типу],Автомобіл.Вартість,Автомобіл.[Вартість прокату],[Марка авто].[Назва марки], [Моделі авто].[Назва моделі] from Автомобіл,[Марка авто],[Моделі авто],Типи
where Вартість >= @с1 and Вартість <= @c2 and [Марка авто].[Код моделі] = [Моделі авто].[Код моделі] and [Марка авто].[Код марки] = Автомобіл.[Код автомобіля] and Типи.[Код типу] = Автомобіл.Тип
GO

EXEC Proc_For_Lab_12_2
GO

CREATE PROC Proc_For_Lab_12_3
(@p1 float = 400, @p2 float = 600)
AS
select * from Автомобіл
where [Вартість прокату] >= @p1 and [Вартість прокату] <= @p2
GO


DROP PROC Proc_For_Lab_12_3
GO
EXEC Proc_For_Lab_12_3
GO

CREATE PROC Proc_For_Lab_12_4
(@r int = 2000)
AS
select * from Автомобіл
where year([Рік випуску]) = @r
GO

EXEC Proc_For_Lab_12_4
GO



CREATE PROC Proc_For_Lab_12_5
(@a int = 1)
AS
select [Код авто], [Код клієнту], Штраф from [Видані авто] в inner join Автомобіл а
on в.[Код авто] = а.[Код автомобіля]
where в.[Код авто] = @a and в.Штраф > 0
GO

EXEC Proc_For_Lab_12_5
GO



CREATE PROC Proc_For_Lab_12_6
(@a int = 2)
AS
select [Код авто], [Код клієнту], Штраф from [Видані авто] в inner join Автомобіл а
on в.[Код авто] = а.[Код автомобіля]
where в.[Код клієнту] = @a and в.Штраф > 0
GO

EXEC Proc_For_Lab_12_6
GO

DROP TRIGGER my_trig_1
GO


CREATE TRIGGER my_trig_1
ON [Видані авто]
for INSERT
AS
BEGIN
	DECLARE @d int,@d2 int,@d3 int
	select @d = 3,@d2 = 5, @d3 = 10
	if @@ROWCOUNT = 0
	return
	declare @c int
	select @c = 1
	if @@ROWCOUNT = @c
	BEGIN
	declare @insK int
	select @insK = [Код клієнту]
	FROM INSERTED

	print(@insK)
	if(@d <= all 
	(
	SELECT COUNT([Код клієнту]) FROM [Видані авто]
	GROUP BY [Код клієнту]
	having [Код клієнту] = @insK
	) and @d2 > all 
	(
	SELECT COUNT([Код клієнту]) FROM [Видані авто]
	GROUP BY [Код клієнту]
	having [Код клієнту] = @insK
	)
	)
	BEGIN
	update [Видані авто]
	set [Код скидки] = 1
	WHERE [Код прокату] = (select [Код прокату] from inserted)
	
	END

	if(@d2 <= all 
	(
	SELECT COUNT([Код клієнту]) FROM [Видані авто]
	GROUP BY [Код клієнту]
	having [Код клієнту] = @insK
	) and @d3 > all 
	(
	SELECT COUNT([Код клієнту]) FROM [Видані авто]
	GROUP BY [Код клієнту]
	having [Код клієнту] = @insK
	)
	)
	BEGIN
	update [Видані авто]
	set [Код скидки] = 2
	WHERE [Код прокату] = (select [Код прокату] from inserted)
	END

	if(@d3 <= all 
	(
	SELECT COUNT([Код клієнту]) FROM [Видані авто]
	GROUP BY [Код клієнту]
	having [Код клієнту] = @insK
	)
	)
	BEGIN
	update [Видані авто]
	set [Код скидки] = 3
	WHERE [Код прокату] = (select [Код прокату] from inserted)

	END

	update [Видані авто]
	set [Видані авто].Ціна = (select [Вартість прокату] from Автомобіл where [Код автомобіля] = (select [Код авто] from inserted))
	WHERE [Код прокату] = (select [Код прокату] from inserted)
	END
END
GO

DROP TRIGGER my_trig_2
GO


CREATE TRIGGER my_trig_2
ON [Видані авто]
after update
AS
BEGIN
	DECLARE @d int,@d2 int,@d3 int
	select @d = 3,@d2 = 5, @d3 = 10
	if @@ROWCOUNT = 0
	return
	declare @c int
	select @c = 1
	if @@ROWCOUNT = @c
	BEGIN
	declare @insK int
	select @insK = [Код клієнту]
	FROM INSERTED

	if (((select [Код скидки] from inserted))IS NOT NULL )
	BEGIN
	update [Видані авто]
	set [Видані авто].Скидка = (select [Система скидок].Сотих from [Система скидок] where [Система скидок].[Код скидки] = 
	(select [Код скидки] from [Видані авто] WHERE [Код прокату] = (select [Код прокату] from inserted)))
	WHERE [Код прокату] = (select [Код прокату] from inserted)
	END
	if (((select [Код штрафу] from inserted))IS NOT NULL )
	BEGIN
	update [Видані авто]
	set [Видані авто].Штраф = (select Top(1) [Система штрафів].Штраф from [Система штрафів] where [Система штрафів].[Код штрафу] = (select [Код штрафу] from inserted))
	WHERE [Код прокату] = (select [Код прокату] from inserted)
	END
	END
END
GO

ALTER TABLE [Видані авто] DROP COLUMN [Остаточна сума];
GO

ALTER TABLE [Видані авто] ADD [Остаточна сума] AS (Ціна * [Кількість днів] * (1 - Скидка) + Штраф);
GO

