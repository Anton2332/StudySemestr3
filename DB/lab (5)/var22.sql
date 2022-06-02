


--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++--

--Завдання 1___________________________________________
use ships
select * from Classes
where country = 'Japan'
order by type desc
GO


--Завдання 2_____________________________________________
use inc_out
select * from Outcome_o
where day(date) = 14
GO

--Завдання 3_____________________________________________
use aero
select p.name,pt.date from Passenger p , Pass_in_trip pt
where p.ID_psg = pt.ID_psg
GO

--Завдання 4____________________________________________
use computer
select maker from Product 
where type = 'PC' 
group by maker 
having maker != all 
(
select maker from Product
where type = 'Laptop'
group by maker
)
GO

select * from Product
GO

--Завдання 5___________________________________________

use computer
select maker from Product 
where type = 'Laptop' and 
maker != all 
(
select maker from Product
where type = 'Printer'
)
group by maker
GO
select * from Product 
GO

--Завдання 6___________________________________________
use inc_out
select cast(day(date) as nvarchar(10))+ '.' + cast(MONTH(date) as nvarchar(10)) + '.' + cast(YEAR(date) as nvarchar(10)) from Income
GO

--Завдання 7___________________________________________
use computer
select p.maker, pr.price from Product p , Printer pr
where p.model = pr.model and pr.color = 'n'
order by price
GO

--Завдання 8___________________________________________
use computer
select Product.maker, avg(PC.hd) from Product , PC
where type = 'PC' and maker = any 
(select maker from Product
where type = 'Printer') and Product.model = PC.model
group by maker

GO

--Завдання 9__________________________________________
--use ships 
--declare @flag int;
--set @flag = 0
--select * from Ships s inner join Classes c ON (s.class = c.class)

--set @flag = @flag + (case when s.class = 'Kongo' then 1 else 0 end)
--GO

--Завдання 10___________________________________________
use computer
select 'PC' as type,model , min(price) as min_price from PC
group by model
union
select 'Laptop' as type,model , min(price) as min_price from Laptop
group by model
union
select 'Printer' as type,model , min(price) as min_price from Printer
group by model
GO

