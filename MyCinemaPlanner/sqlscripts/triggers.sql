﻿create trigger TRIG_AddDistribution on Distributions
after INSERT
as
if (select count(d.DistributorID) from Distributions d
	join inserted i on d.MovieID = i.MovieID) >= 2
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

-- 4.01.2017 - trigger wywoływany kiedy chcemy sprzedać więcej niż jest w magazynie
-- nie ma rollbacka bo załatwia to transakcja
create trigger TRIG_CheckAmountinStock on Usage
after INSERT
as
declare @amount varchar(250)
select @amount = 'Nie ma wystarczającej liczby produktu - ' + 
				 (select p.Name from inserted i join Products p on p.ProductID = i.ProductID)
				 + ' w magazynie.'
if (select p.AmountInStock - i.Amount from inserted i 
	join Products p on p.ProductID = i.ProductID) < 0
begin
	RAISERROR (@amount, 16, 1);
End
