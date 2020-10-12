/*
rename table `bestuursleden`to `tblBestuursleden`;
rename table `boetes` to `tblBoetes`;
rename table `spelers` to `tblSpelers`;
rename table `teams` to `tblTeams`;
rename table `wedstrijden` to `tblWedstrijden`;


alter table `tblBoetes` 
	add	`REDEN` varchar(255);

alter table `tblSpelers` 
	add `VOORNAAM` varchar(50);

alter table `tblBoetes` 
	add `PAYMENTDATE` date
		after `BEDRAG`;

alter table `tblspelers`
	drop `VOORLETTERS`;

alter table `tblboetes`
	change `PAYMENTDATE` `BETALINGSDATUM` date;
*/

alter table `tblspelers`
	change `NAAM` `NAAM` varchar(50) not null;