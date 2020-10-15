use tennis3;

/*
update `boetes` set
	`BEDRAG` = `BEDRAG` * 1.05 where `BETALINGSNR` > 0;


update `boetes` set
	`BEDRAG` = 120 where `DATUM` >= '2020-01-01' and `DATUM` <= '2020-12-31' and `BETALINGSNR` > 0;
*/

select * from `boetes`;