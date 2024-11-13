use master;
go
-- brisem postojecu bazu ako postoji
drop database if exists zoo;
go

create database zoo;
go

use zoo;
go

create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30) not null,
maxsize int not null,
mjesto varchar(30) not null
);

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
IBAN varchar(50) not null
);

create table datum(
d_rodenja datetime not null,
d_dolaska datetime not null,
d_smrti datetime,
sifra int not null primary key identity(1,1)
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int not null references djelatnik(sifra),
prostorija int not null references prostorija(sifra),
datum int not null references datum(sifra)
);