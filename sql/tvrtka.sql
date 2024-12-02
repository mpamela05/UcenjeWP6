use master;
go

drop database if exists tvrtka;
go

create database tvrtka collate Croatian_CI_AS;
go

use tvrtka;
go

create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodenja date not null,
placa decimal(18,2) null,
invalid bit not null
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenici int not null references zaposlenici(sifra),
redni_broj decimal not null,
putanja char(11)
);

insert into zaposlenici (ime, prezime, datum_rodenja, placa)
values ('Jana', 'Horvat', '1987-08-20', 1300);

insert into zaposlenici (ime, prezime, datum_rodenja, placa)
values ('Marko', 'Kova?', '1993-03-23', 1150);

insert into zaposlenici (ime, prezime, datum_rodenja, placa)
values ('Josipa', 'Mari?', '1990-01-13', 1100);

insert into slike 