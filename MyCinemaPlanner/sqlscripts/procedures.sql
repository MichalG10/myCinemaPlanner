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

-- 29.12.17r - Distrybutions - Procedures

create procedure addDistribution
@MovieID int,
@DistributorID int,
@Dubb varchar(3),
@Sub varchar(3),
@is3D bit
as
insert into Distributions(MovieID, DistributorID, Dubbing, Subtitle, is3D)
values (@MovieID, @DistributorID, @Dubb, @Sub, @is3D)

create procedure editDistribution
@id int,
@MovieID int,
@DistributorID int,
@Dubb varchar(3),
@Sub varchar(3),
@is3D bit
as
update Distributions
set MovieID = @MovieID, DistributorID = @DistributorID, Dubbing = @Dubb, Subtitle = @Sub, is3D = @is3D
where DistributionID = @id

create procedure deleteDistribution
@id int
as
delete from Distributions
where DistributionID = @id
