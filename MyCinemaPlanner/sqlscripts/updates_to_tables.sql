-- 4.01.2017 - wymagana aktualizacja tabeli Products do obslugi wspolbieznosci
alter table Products
add RowVersion Rowversion

-- 5.01.2017 - aktualizacja tabeli Orders - dodanie dnia wydania zamowienia
alter table Orders
add WorkDay date default getdate()

-- aktualizacja tabeli Usage o dodanie klucza głównego, bez niego nie będzie można dodawać zamówień
alter table Usage
add UsageID int not null identity(1,1) primary key

-- 10.01.2018 - aktualizacja tabeli Orders - dodanie dnia realizacji zamówienia
alter table Orders
add Realised date default getdate()