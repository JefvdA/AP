create database if not exists `Planes`;

create table if not exists `tblManufactures`
(
	`Id` int(4) unique auto_increment primary key,
    `Name` varchar(70) unique
)auto_increment=101;

create table if not exists `tblPlaneDefenitions`
(
	`Id` int(7) auto_increment primary key,
    `ManufactureId` int(4) not null,
    foreign key(`Id`)
    references `tblManufactures`(`Id`),
    `Name` varchar(100) not null,
    `DesignData` date not null,
    `IsMilitary` tinyint,
    `NumberOfEngines` int unsigned,
    `Weight` decimal(5,2)
);

select * from planes.tblmanufactures;
select * from planes.tblplanedefenitions;