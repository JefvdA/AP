USE `tennis`;

-- 1
select
	`SPELERSNR`,
    `NAAM`,
    CONCAT("+31(0)", SUBSTRING(`TELEFOON`, 2))
from
	`spelers`;
    
-- 2
select
	`SPELERSNR`,
    CASE
		WHEN CURRENT_DATE() = `GEB_DATUM` THEN "jarig"
        ELSE "niet jarig"
	END AS `Feest`
from
	`spelers`;