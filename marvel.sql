use master;
go

drop database if exists marvel;
go

create database marvel;
go

use marvel;
go


create table mjesto(
sifra int not null primary key identity(1,1),
planet varchar(60) not null,
grad varchar(50) not null
);


create table identitet(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50)  not null,
godine int not null,
god_rodjenja date not null,
god_smrti date null
);


create table timovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
baza varchar(50) not null, 
mjesto varchar(50) not null,
identitet varchar(50) not null
);


create table heroji(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
moc varchar(50) not null,
mjesto int references mjesto(sifra),
osobnost varchar(100) not null,
g_dolaska date not null,
identitet int references identitet(sifra),
tim int references timovi(sifra)
);

insert into mjesto values ('Zemlja', 'New Zork'), ('Zemlja', 'Iowa'), ('Asgard', ''), ('Zemlja', 'Daiton'), ('Zemlja', 'Volgograd'), ('Zemlja', 'Hustville'), ('Zemlja', ''), ('Zemlja', 'St.Charles'), ('Planet_X', ''),
('', 'Mount Kyles'), ('Zemlja', ''), ('The Benatar', '');
select * from mjesto

insert into identitet values ('Peter','Parker', '23', '2001', ''), ('Tony', 'Stark', '50', '1970', '2023'), ('Clint', 'Barton', '50', '1970',''), 
('Thor', 'Odinson', '1052', '0965', ''), ('Natalia', 'Romanoff', '39', '1984', '2023'),
(' Robert Bruce', 'Banner', '55', '1969', ''), ('Vision', '', '3', '2015', '2018'), ('Nicholas Joseph', 'Fury', '74', '1950',''), 
('89P13', '', '','',''), ('Peter', 'Quill', '44', '1980', ''),
('Groot', '', '10', '2014', ''), ('Drax', '', '', '', ''), ('Gamora', '', '', '', '2018'), ('Nebula', '', '', '', ''), ('Mantis', '', '', '', '');
select * from identitet

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Peter Parker');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Tony Stark');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Clint Barton');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Asgard', 'Thor Odinson');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Rober Bruce Banner');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Vision');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Natalia Romanoff ');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Avengers', 'New York', 'Zemlja', 'Nicholas Joseph Fury');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', '89P13');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Peter Quill');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Groot');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Drax');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Gamora');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Nebula');

insert into timovi (naziv, baza, mjesto, identitet)
values ('Guardians of the Galaxy', 'Andromeda galaxy', '', 'Mantis');
select * from timovi

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Spider Man', 'nadljudska snaga, izdržljivost, brzina, regeneracija, mogućnost ispaljivanja paukovih mreža, penjanje po raznim površinama',
'New York', 'hrabar,brizan,lojalan,drag', '2016', 'Peter Parker', 'Avengers');

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Iron Man', 'mocno oklopno odijelo, projektili, mogucnost letenja', 'New York', 'hrabar, inteligentan, ponosan, ekscentirican', '2007', 'Tony Stark', 'Avengers');