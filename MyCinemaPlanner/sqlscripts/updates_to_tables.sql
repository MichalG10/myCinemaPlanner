-- 4.01.2017 - wymagana aktualizacja tabeli Products do obslugi wspolbieznosci
alter table Products
add RowVersion Rowversion