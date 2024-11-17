use master;
go

drop database if exists korisnici;
go

create database korisnici;
go

use korisnici;
go

create table korisnici(
sifra int not null primary key identity(1,1),
nadimak varchar(50) not null,
lozinka varchar(30) not null,
mail varchar(50) not null,
uloga varchar(50) not null
);