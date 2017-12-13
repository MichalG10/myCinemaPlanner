use myCinemaPlannerDB

alter table Movies
add constraint Check_Director check (DATALENGTH(Director) > 0)

alter table Movies
add constraint Check_Title check (DATALENGTH(Title) > 0)

alter table Movies
add constraint Check_Studio check (DATALENGTH(Studio) > 0)

alter table Movies
add constraint Check_Genre check (DATALENGTH(Genre) > 0)

alter table Movies
add constraint Check_Rating check (1.0 <= Rating and Rating <= 10.0)

