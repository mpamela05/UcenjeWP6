select * from smjerovi

update smjerovi set cijena=1100
where sifra=2;

update smjerovi set 
izvodiseod='2024-12-05',
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime= 'Franjić' where sifra=16;

select * from polaznici where sifra=16;

select * from smjerovi

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values('Dizajn', '1200', '2024-06-06 17:00', '1');
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values('programiranje', '1300', '2024-12-26 17:00', '2');
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values('UI dizajn', '1300', '2024-10-08 17:00', '3');
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values('Grafički dizajn', '1000', '2024-07-20 17:00', '4');
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values('slikarstvo', '800', '2024-05-05 17:00', '5');

select * from smjerovi;
update smjerovi set cijena= cijena * 0.9;
select * from smjerovi;

-- uvecana cijena
select * from smjerovi;
update smjerovi set cijena = cijena * 1.35;
select * from smjerovi;

-- smanjena cijena
select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;

update grupe set smjer=8 where sifra=1; 

-- delete 

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;

select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;
