ALTER TABLE Movies
ADD Duration time default '00:00:00';

Update Movies
set Duration = '00:00:00';