USE  `tennis`;

/*
-- 1
SELECT
	s.*,
    b.`FUNCTIE`,
	CASE
		WHEN b.`EIND_DATUM` IS NOT NULL THEN "Actief"
        ELSE "Niet actief"
	END AS "Actief?"
FROM
	`spelers` s
    INNER JOIN `bestuursleden` b ON s.`SPELERSNR` = b.`SPELERSNR`
WHERE
	b.`FUNCTIE` = "voorzitter"
    OR b.`FUNCTIE` = "penningmeester";

-- 2
SELECT
	s.`SPELERSNR`,
    s.`NAAM`,
    CONCAT(w.`GEWONNEN`, " - ", w.`VERLOREN`) AS "Uitslag"
FROM
	`spelers` s
    INNER JOIN `teams` t ON t.`SPELERSNR` = s.`SPELERSNR`
    INNER JOIN `wedstrijden` w ON w.`SPELERSNR` = t.`SPELERSNR`;

-- 3
SELECT
    CONCAT(SUBSTRING(s.`NAAM` , INSTR(s.`NAAM`, ",") + 1), " ", SUBSTRING_INDEX(s.`NAAM`, ",", 1)),
    w.*
FROM
	`spelers` s
    INNER JOIN `wedstrijden` w ON w.`SPELERSNR` = s.`SPELERSNR`
WHERE
	w.`GEWONNEN` > w.`VERLOREN` AND
	MONTH(s.`GEB_DATUM`) IN (8, 9, 10);
*/