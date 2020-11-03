USE	`tennis`;

/*
-- 2
SELECT
	b.`BETALINGSNR`,
    b.`BEDRAG`,
    s.`NAAM`
FROM
	`boetes` b,
    `spelers` s
WHERE
	s.`SPELERSNR` = b.`SPELERSNR`;

-- 2
SELECT
	s.`SPELERSNR`,
    s.`NAAM`,
    w.*
FROM
	`spelers` s, `wedstrijden` w
WHERE
	w.`SPELERSNR` = s.`SPELERSNR`;

-- 3
SELECT
	b.`BETALINGSNR`,
    b.`BEDRAG`,
    s.`NAAM`,
    s.`PLAATS`
FROM
	`boetes` b, `spelers` s
WHERE
	b.`SPELERSNR` = s.`SPELERSNR`
	AND s.`PLAATS` = "Den Haag";

-- 4
SELECT
	w.`WEDSTRIJDNR`,
    s.`NAAM`,
    t.`DIVISIE`,
    CASE
		WHEN (w.`GEWONNEN` - w.`VERLOREN`) > 0 THEN "GEWONNEN"
		WHEN (w.`GEWONNEN` - w.`VERLOREN`) < 0 THEN "VERLOREN"
	END AS "Resultaat"
FROM
	`wedstrijden` w, `spelers` s, `teams` t
WHERE
	w.`SPELERSNR` = s.`SPELERSNR` AND w.`TEAMNR` = t.`TEAMNR`;
*/