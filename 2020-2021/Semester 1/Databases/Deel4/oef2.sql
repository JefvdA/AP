use `tennis`;

-- 1
select
	`SPELERSNR`,
    `TEAMNR`,
    CASE
		WHEN (`GEWONNEN`) > (`VERLOREN`) THEN "Gewonnen"
        ELSE "Verloren"
	END AS `RESULTAAT`
from
	`wedstrijden`;
    
-- 2
select
	`SPELERSNR`,
    `JAARTOE`,
    CASE
		WHEN `JAARTOE` < 1980 THEN "Ouderen"
        WHEN `JAARTOE` < 1983 THEN "Jongeren"
        ELSE "Kinderen"
	END AS `GROEP`
from
	`spelers`;

-- 3
select
	`SPELERSNR`,
    `JAARTOE`,
    CASE
		WHEN `JAARTOE` < 1980 AND `BONDSNR` IS NULL THEN "Ouderen recreatief"
        WHEN `JAARTOE` < 1980 THEN "Ouderen wedstrijd"
        WHEN `JAARTOE` < 1983 THEN "Jongeren"
        ELSE "Kinderen"
	END AS `GROEP`
from
	`spelers`;