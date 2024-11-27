use master;
go

drop database if exists webshop;
go

create database webshop;
go

use webshop;
go

create table stavke(
racun int not null,
proizvod int not null,
kolicina decimal (18,2) not null,
cijena decimal(18,2) not null
);

create table proizvod(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
datum_nabave date,
cijena decimal (18,2) not null,
aktivan bit null
);

create table racuni(
sifra int not null primary key identity(1,1),
datum date,
kupac int not null references kupci(sifra),
status bit null
);

create table kupci(
sifra int not null primary key identity(1,1),
ime  varchar(50) not null,
prezime varchar(50) not null,
ulica varchar(80) not null,
mjesto  varchar (50)  not  null
);