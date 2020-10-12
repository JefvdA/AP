create database if not exists `Learning` default charset utf8mb4;

create table if not exists `tblLanguages` 
(
	`Id` int unsigned primary key,
    `Name` varchar(25)
);

create table if not exists `tblCourseDefinitions`
(
	`Id` int unsigned primary key,
    `LanguageId` int unsigned,
    foreign key(`LanguageId`)
    references `tblLanguages`(`Id`),
    `Name` varchar(100),
    `ReplicationKey` varchar(36)
);

select * from learning.tblcoursedefinitions;
select * from learning.tbllanguages;