USE Lab_11
GO


DECLARE @d int
select @d = 1
select * from ��������
where ����� = @d
GO

DECLARE @c1 float,@c2 float
select @c1 = 1000000,@c2 = 1500000
select * from ��������
where ������� >= @c1 and ������� <= @c2
GO


DECLARE @p1 float,@p2 float
select @p1 = 400,@p2 = 600
select * from ��������
where [������� �������] >= @p1 and [������� �������] <= @p2
GO

DECLARE @r int
select @r = 2000
select * from ��������
where year([г� �������]) = @r
GO

DECLARE @a int
select @a= 1
select [��� ����], [��� �볺���], ����� from [����� ����] � inner join �������� �
on �.[��� ����] = �.[��� ���������]
where �.[��� ����] = @a and �.����� is not null
GO

DECLARE @a int
select @a= 2
select [��� ����], [��� �볺���], ����� from [����� ����] � inner join �������� �
on �.[��� ����] = �.[��� ���������]
where �.[��� �볺���] = @a and �.����� is not null
GO


CREATE PROC Proc_For_Lab_12_1
(@d INT = 1)
AS
select ��������.[��� ���������],��������.[г� �������],����.[����� ����],��������.�������,��������.[������� �������],[����� ����].[����� �����], [����� ����].[����� �����] from ��������,[����� ����],[����� ����],����
where ����� = @d and [����� ����].[��� �����] = [����� ����].[��� �����] and [����� ����].[��� �����] = ��������.[��� ���������] and ����.[��� ����] = ��������.���
GO

EXEC Proc_For_Lab_12_1
GO


CREATE PROC Proc_For_Lab_12_2
(@�1 float = 1000000, @c2 float = 1500000)
AS
select ��������.[��� ���������],��������.[г� �������],����.[����� ����],��������.�������,��������.[������� �������],[����� ����].[����� �����], [����� ����].[����� �����] from ��������,[����� ����],[����� ����],����
where ������� >= @�1 and ������� <= @c2 and [����� ����].[��� �����] = [����� ����].[��� �����] and [����� ����].[��� �����] = ��������.[��� ���������] and ����.[��� ����] = ��������.���
GO

EXEC Proc_For_Lab_12_2
GO

CREATE PROC Proc_For_Lab_12_3
(@p1 float = 400, @p2 float = 600)
AS
select * from ��������
where [������� �������] >= @p1 and [������� �������] <= @p2
GO


DROP PROC Proc_For_Lab_12_3
GO
EXEC Proc_For_Lab_12_3
GO

CREATE PROC Proc_For_Lab_12_4
(@r int = 2000)
AS
select * from ��������
where year([г� �������]) = @r
GO

EXEC Proc_For_Lab_12_4
GO



CREATE PROC Proc_For_Lab_12_5
(@a int = 1)
AS
select [��� ����], [��� �볺���], ����� from [����� ����] � inner join �������� �
on �.[��� ����] = �.[��� ���������]
where �.[��� ����] = @a and �.����� > 0
GO

EXEC Proc_For_Lab_12_5
GO



CREATE PROC Proc_For_Lab_12_6
(@a int = 2)
AS
select [��� ����], [��� �볺���], ����� from [����� ����] � inner join �������� �
on �.[��� ����] = �.[��� ���������]
where �.[��� �볺���] = @a and �.����� > 0
GO

EXEC Proc_For_Lab_12_6
GO

DROP TRIGGER my_trig_1
GO


CREATE TRIGGER my_trig_1
ON [����� ����]
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
	select @insK = [��� �볺���]
	FROM INSERTED

	print(@insK)
	if(@d <= all 
	(
	SELECT COUNT([��� �볺���]) FROM [����� ����]
	GROUP BY [��� �볺���]
	having [��� �볺���] = @insK
	) and @d2 > all 
	(
	SELECT COUNT([��� �볺���]) FROM [����� ����]
	GROUP BY [��� �볺���]
	having [��� �볺���] = @insK
	)
	)
	BEGIN
	update [����� ����]
	set [��� ������] = 1
	WHERE [��� �������] = (select [��� �������] from inserted)
	
	END

	if(@d2 <= all 
	(
	SELECT COUNT([��� �볺���]) FROM [����� ����]
	GROUP BY [��� �볺���]
	having [��� �볺���] = @insK
	) and @d3 > all 
	(
	SELECT COUNT([��� �볺���]) FROM [����� ����]
	GROUP BY [��� �볺���]
	having [��� �볺���] = @insK
	)
	)
	BEGIN
	update [����� ����]
	set [��� ������] = 2
	WHERE [��� �������] = (select [��� �������] from inserted)
	END

	if(@d3 <= all 
	(
	SELECT COUNT([��� �볺���]) FROM [����� ����]
	GROUP BY [��� �볺���]
	having [��� �볺���] = @insK
	)
	)
	BEGIN
	update [����� ����]
	set [��� ������] = 3
	WHERE [��� �������] = (select [��� �������] from inserted)

	END

	update [����� ����]
	set [����� ����].ֳ�� = (select [������� �������] from �������� where [��� ���������] = (select [��� ����] from inserted))
	WHERE [��� �������] = (select [��� �������] from inserted)
	END
END
GO

DROP TRIGGER my_trig_2
GO


CREATE TRIGGER my_trig_2
ON [����� ����]
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
	select @insK = [��� �볺���]
	FROM INSERTED

	if (((select [��� ������] from inserted))IS NOT NULL )
	BEGIN
	update [����� ����]
	set [����� ����].������ = (select [������� ������].����� from [������� ������] where [������� ������].[��� ������] = 
	(select [��� ������] from [����� ����] WHERE [��� �������] = (select [��� �������] from inserted)))
	WHERE [��� �������] = (select [��� �������] from inserted)
	END
	if (((select [��� ������] from inserted))IS NOT NULL )
	BEGIN
	update [����� ����]
	set [����� ����].����� = (select Top(1) [������� �������].����� from [������� �������] where [������� �������].[��� ������] = (select [��� ������] from inserted))
	WHERE [��� �������] = (select [��� �������] from inserted)
	END
	END
END
GO

ALTER TABLE [����� ����] DROP COLUMN [��������� ����];
GO

ALTER TABLE [����� ����] ADD [��������� ����] AS (ֳ�� * [ʳ������ ���] * (1 - ������) + �����);
GO

