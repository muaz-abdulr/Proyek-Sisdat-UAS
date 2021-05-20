create table watchlist
(watchlistID int not null,
film_id int,
film_title varchar(40),
description text,
watchschedule varchar(10),
constraint PK_watchlist PRIMARY KEY (watchlistID),
FOREIGN KEY (film_id) REFERENCES films(film_id));