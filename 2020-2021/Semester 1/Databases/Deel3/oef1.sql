create database if not exists `Learning` default charset utf8mb4;
use `Learning`;

create table if not exists `tblLanguages` 
(
	`Id` int unsigned primary key,
    `Name` varchar(25) charset latin1
);

create table if not exists `tblCourseDefinitions`
(
	`Id` mediumint unsigned primary key,
    `LanguageId` int unsigned,
    foreign key (`LanguageId`)
    references `tblLanguages`(`Id`),
    `Name` varchar(100),
    `ReplicationKey` varchar(32)
);