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


create table identiet(
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
identitet int references identiet(sifra),
tim int references timovi(sifra)
);