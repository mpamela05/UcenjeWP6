create database zoo;

use zoo;

create table zivotinja(
sifra int,
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int
);

create table prostorija(
sifra int,
dimenzije varchar(30),
maxsize int,
mjesto varchar(30)
);

create table djelatnik(
sifra int,
ime varchar(5),
prezime varchar(50),
IBAN varchar(50)
);


create table datum(
d_rodenja datetime,
d_dolaska datetime,
d_smrti datetime,
sifra int
);