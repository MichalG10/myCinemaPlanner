create view Distributors_counted_movies as
select d.Name, count(dis.DistributionID) as AmountofMovies
from Distributors as d
left join Distributions dis on dis.DistributorID = d.DistributorID
group by d.Name

-- 10.01.2018 - dodanie widoków związanych z obsługą zakładki Magazynu w oknie Managera
create view [Products_with_OLT] as
select distinct P.ProductID, P.Name, P.UnitPrice, P.AmountInStock, P.MinAmount, 
				P.Category, max(O.WorkDay) as OrderedLastTime from Products P
join Orders O on O.ProductID = P.ProductID
group by P.ProductID, P.Name, P.UnitPrice, P.AmountInStock, P.MinAmount, P.Category

create view [Products_Ordered] as
select o.OrderID, P.Name, O.Amount, 
	   cast(O.Amount*P.UnitPrice*(1-o.Discount) as decimal(8,2)) as PriceInPLN, 
	   o.WorkDay as OrderDate, datediff(DAY, o.WorkDay, getdate()) as DaysOfWaiting
from Orders o
join Products p on p.ProductID = o.ProductID
where o.Realised is NULL

create view [Products_Realized] as
select o.OrderID, P.Name, O.Amount, O.Discount, cast(O.Amount*P.UnitPrice*(1-o.Discount) as decimal(8,2)) as PriceInPLN, 
	   o.Realised as RealizationDate
from Orders o
join Products p on p.ProductID = o.ProductID
where o.Realised is not NULL



