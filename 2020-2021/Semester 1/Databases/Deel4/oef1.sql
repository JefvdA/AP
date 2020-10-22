-- 1
select
	`BETALINGSNR`,
    `BEDRAG`
from
	`boetes`;

-- 2
select
	`SPELERSNR`,
    `TEAMNR`,
    `GEWONNEN` - `VERLOREN`
from
	`wedstrijden`;
    
-- 3
select
	`SPELERSNR`,
    `TEAMNR`,
    `GEWONNEN` - `VERLOREN` as `RESULTAAT`
from
	`wedstrijden`;