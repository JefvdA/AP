create database if not exists `AP`;

create table if not exists `AFDELING`
(
	`AFDNR` char(5) primary key,
    `BUDGET` decimal(8,2) not null,
    `LOCATIE` varchar(30),
    `ISACTIEF` tinyint default 0,
    `GEMPUNTEN` decimal(4,2)
);

/*
insert into AFDELING (AFDNR, BUDGET, LOCATIE, ISACTIEF, GEMPUNTEN)
values(12345, 2000.25, 'Capus Ellermanstraat', 0, 12.43);
*/

create table if not exists `tblOpleidingen`
(
	`Code` varchar(10) primary key,
    `Omschrijving` text,
    `Duur` tinyint unsigned
);

create table if not exists `tblAfdelingen`
(
	`Nr` int unsigned auto_increment primary key,
    `Naam` varchar(100),
    `Replicatiecode` char(36)
)auto_increment=10;

create table if not exists `tblMedewerkers`
(
	`Nr` int unsigned auto_increment primary key,
    `Naam` varchar(100),
    `Adres` tinytext,
    `AfdelingNr` int unsigned,
    foreign key (`AfdelingNr`)
    references `tblAfdelingen`(`Nr`)
)auto_increment=1;

create table if not exists `tblGevolgdeOpleiding`
(
	`MedewerkerNr` int unsigned primary key,
    foreign key (`MedewerkerNr`)
    references `tblMedewerkers`(`Nr`),
    `Opleidingscode` varchar(10),
    foreign key (`Opleidingscode`)
    references `tblOpleidingen`(`Code`),
    `Datum` date,
    `Voltooid` datetime
);

select * from ap.tblGevolgdeOpleiding;


