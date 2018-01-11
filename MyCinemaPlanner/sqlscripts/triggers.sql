create trigger TRIG_AddDistribution on Distributions
after INSERT
as
if (select count(d.DistributorID) from Distributions d
	join inserted i on d.MovieID = i.MovieID) >= 2
begin
	rollback
	RAISERROR ('Nie można dodać dystrybucji, dostarczonej już przez innego dystrybutora.', 12, 11);
End

-- aktualizacja 04.01.2018
create trigger TRIG_AddMovie on Movies
after INSERT
as
declare @tytul varchar(50)
set @tytul=(select Title from inserted)
if ((Select count(Title) from Movies where Title in @tytul
begin
rollback
RAISERROR ('Nie można dodać filmu który już wczesniej został dodany', 13, 1);
End

-- aktualizacja 04.01.2018
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

-- Dodane 10.01.2018
create trigger TRIG_AddEmployeeRaport on Employee
after insert
as
declare @imie varchar(200),
@nazwisko varchar(200),
@pesel varchar(200),
@dataUr date,
@adres varchar(200),
@city varchar(200),
@country varchar(200),
@id int,
@dataDodania date,
@suma varchar(2000)
set @id = (select EmployeeID from inserted)
set @imie = (select FirstName from inserted)
set @nazwisko = (select LastName from inserted)
set @dataUr = (select DateofBirth from inserted)
set @pesel = (select Pesel from inserted)
set @adres = (select Adress from inserted)
set @city = (select City from inserted)
set @country = (select Country from inserted)
set @dataDodania = GETDATE()
set @suma=(SELECT CONVERT(varchar, @dataDodania, 101))+'	 ' +(SELECT CONVERT(varchar, @id))+' ' +@imie+ ' ' + @nazwisko + ' ' + (SELECT CONVERT(varchar, @dataUr, 101)) + ' ' +@pesel+ ' ' + @adres + ' '+@city+ ' ' + @country
begin
EXEC WriteToFile 'C:\Users\Michal\Documents\GitHub\myCinemaPlanner\MyCinemaPlanner\bin\Debug\Raporty\Dodane.txt',@suma 
end

-- Dodane 10.01.2018
create trigger TRIG_DeleteEmployeeRaport on Employee
after delete
as
declare @imie varchar(200),
@nazwisko varchar(200),
@pesel varchar(200),
@dataUr date,
@adres varchar(200),
@city varchar(200),
@country varchar(200),
@id int,
@dataUsuniecia date,
@suma varchar(2000)
set @id = (select EmployeeID from deleted)
set @imie = (select FirstName from deleted)
set @nazwisko = (select LastName from deleted)
set @dataUr = (select DateofBirth from deleted)
set @pesel = (select Pesel from deleted)
set @adres = (select Adress from deleted)
set @city = (select City from deleted)
set @country = (select Country from deleted)
set @dataUsuniecia = GETDATE()
set @suma=(SELECT CONVERT(varchar, @dataUsuniecia, 101))+'	 ' +(SELECT CONVERT(varchar, @id))+' ' +@imie+ ' ' + @nazwisko + ' ' + (SELECT CONVERT(varchar, @dataUr, 101)) + ' ' +@pesel+ ' ' + @adres + ' '+@city+ ' ' + @country
begin
EXEC WriteToFile 'C:\Users\Michal\Documents\GitHub\myCinemaPlanner\MyCinemaPlanner\bin\Debug\Raporty\Usuniete.txt',@suma 
end

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

