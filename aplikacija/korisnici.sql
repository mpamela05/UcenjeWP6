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
lozinka varchar(32) not null,
mail varchar(50) not null,
uloga varchar(50) not null
);

insert into korisnici values ('fl0rest', HashBytes('MD5', 'lozinka'), 'davortoth3@gmail.com', 'administrator')
select lozinka from korisnici;
