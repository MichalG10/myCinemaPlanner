create view Distributors_counted_movies as
select d.Name, count(dis.DistributionID) as AmountofMovies
from Distributors as d
left join Distributions dis on dis.DistributorID = d.DistributorID
group by d.Name