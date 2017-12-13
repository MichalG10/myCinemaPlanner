create trigger TRIG_AddDistribution on Distributions
after INSERT
as
if (select count(*) from Distributions d, inserted i
	where d.DistributorID = i.DistributorID
	and d.MovieID = i.MovieID) <= 1 
begin
	rollback
	RAISERROR ('Nie można dodać dystrybucji, dostarczonej już przez innego dystrybutora.', 12, 11);
End

create trigger TRIG_AddMovie on Movies
after INSERT
as
declare @tytul varchar(50)
set @tytul=(select Title from inserted)
if @tytul in (Select Title from Movies)
begin
rollback
RAISERROR ('Nie można dodać filmu który już wczesniej został dodany', 13, 1);
End

create trigger TRIG_AddDistributor on Distributors
after insert
as
declare @country varchar(20)
set @country = (select Country from inserted)
if (select count(*) from Distributors where Country = @country) > 5
begin
rollback
RAISERROR('Nie można dodać więcej dystrybutrów, niż 5.', 14, 21);
End