create procedure AddDistributor
@disName varchar(50),
@disEmail varchar(100),
@disPhone varchar(15),
@disAdress varchar(100),
@zipCode varchar(7),
@disCity varchar(15),
@disCountry varchar(20)
as
if DATALENGTH(@disPhone) > 9
begin
	RAISERROR('Dodawanie: Numer telefonu dłuższy niż 9 znaków.', 12, 1)
	return -1
end
insert into Distributors(Name, Email, PhoneNumber, Adress, ZipCode, City, Country)
values(@disName, @disEmail, @disPhone, @disAdress, @zipCode, @disCity, @disCountry)

create procedure EditDistributor
@id int,
@disName varchar(50),
@disEmail varchar(100),
@disPhone varchar(15),
@disAdress varchar(100),
@zipCode varchar(7),
@disCity varchar(15),
@disCountry varchar(20)
as
if DATALENGTH(@disPhone) > 9
begin
	RAISERROR('Edytowanie: Numer telefonu dłuższy niż 9 znaków.', 12, 1)
	return -2
end
update Distributors
set Name = @disName, Email = @disEmail, PhoneNumber = @disPhone,
	Adress = @disAdress, ZipCode = @zipCode, City = @disCity, Country = @disCountry
where DistributorID = @id

create procedure DeleteDistributor
@id int
as
if exists(select * from Distributions where DistributorID = @id)
begin
	RAISERROR('Usuwanie: Nie można usunąć dystrybutora, który dostarcza dystrybucję filmu.', 12, 1)
	return -3
end
delete from Distributors
where DistributorID = @id