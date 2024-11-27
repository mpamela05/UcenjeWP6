use master;
go

drop database if exists marvel;
go

create database marvel collate Croatian_CI_AS;
go

use marvel;
go

create table identitet(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) null,
godine int null,
god_rodjenja int null,
god_smrti int null
);


create table timovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
mjesto varchar(50) not null
);


create table heroji(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
moc varchar(250) not null,
mjesto varchar(100),
osobnost varchar(100) not null,
g_dolaska int not null,
identitet int references identitet(sifra),
tim int references timovi(sifra)
);

insert into identitet
values('Peter','Parker', 23, 2001, null), 
('Tony', 'Stark', 50, 1970, 2023), 
('Clint', 'Barton', 50, 1970,null), 
('Thor', 'Odinson', 1052, 0965, null), 
('Natalia', 'Romanoff', 39, 1984, 2023),
(' Robert Bruce', 'Banner', 55, 1969, null), 
('Vision', 'null', 3, 2015, 2018), 
('Nicholas Joseph', 'Fury', 74, 1950,null), 
('89P13', null, 5, null, null), 
('Peter', 'Quill', 44, 1980, null),
('Groot', null, 10, 2014, null), 
('Drax', null, null, null, null), 
('Gamora', null, null, null, 2018), 
('Nebula', null, null, null, null), 
('Mantis', null, null, null, null);
select * from identitet

insert into timovi (naziv, mjesto)
values ('Avengers', 'Zemlja'), ('Guardians of the Galaxy','Offworld'), ('S.H.I.E.L.D', 'Zemlja');
select * from timovi

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Spider Man', 'nadljudska snaga, izdržljivost, brzina, regeneracija, mogućnost ispaljivanja paukovih mreža, penjanje po raznim površinama',
'New York', 'hrabar,brizan,lojalan,drag', 2016, 1, 1);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Iron Man', 'mocno oklopno odijelo, projektili, mogucnost letenja', 'New York', 'hrabar, inteligentan, ponosan, ekscentirican', 2007, 2, 1);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Hawkeye', 'Ekspert streličarstvo', 'New York', 'Strpljiv, taktičar', 1964, 3, 3);

 insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Thor', 'Bog groma', 'Asgard', 'Plemenit, moćan', 1962, 4, 1);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Hulk', 'Nevjerojatna snaga', 'New York', 'Impulzivna, snažna', 1962, 5, 1);

 insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Vision', 'Superinteligencija, laserski zraci', 'Sokovia', 'Mirna, logična', 1968, 6, 1);

 insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Natasha Romanoff', 'Vješte borilačke vještine, špijunske vještine', 'Rusija', 'Inteligentna, strateginja', 1964, 7, 1);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Nick Fury', 'Vješt strateški um, vođstvo', 'New York', 'Ozbiljan, iskusan', 1963, 8, 3);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Rocket', 'Genijalac, majstor oružja', 'Planet X', 'Sarkastičan, lojalan', 2014, 9, 2);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Star-Lord', 'Vođa, vješt pilot', 'Zemlja', 'Humorističan, avanturist', 2014, 10, 2);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Groot', 'Super snaga, regeneracija', 'Planet X', 'Jednostavan, prijateljski', 2014, 11, 2);

insert into  heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Drax Razarač', 'Super snaga, neuništivost', 'Planet X', 'Naivan, osvetoljubiv', 2014, 12, 2);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values('Gamora', 'Vješte borilačke vještine, atletičar', 'Zeleni planet', 'Hladna, odlučna', 2014, 13, 2);
insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Nebula', 'Kibernetička nadogradnja, vještina borbe', 'Titan', 'Okrutna, osvetoljubiva', 2014, 14, 2);

insert into heroji (ime, moc, mjesto, osobnost, g_dolaska, identitet, tim)
values ('Mantis', 'Empatija, borilačke vještine', 'Cerberus', 'Naivna, empatična', 2014, 15, 2);


create table korisnici(
sifra int not null primary key identity(1,1),
nadimak varchar(50) not null,
lozinka varchar(32) not null,
mail varchar(50) not null,
uloga varchar(50) not null
);

insert into korisnici values ('fl0rest', HashBytes('MD5', 'lozinka'), 'davortoth3@gmail.com', 'administrator')
select lozinka from korisnici;
