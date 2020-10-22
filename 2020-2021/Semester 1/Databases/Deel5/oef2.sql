USE `tennis`;

-- 1
SELECT
	`BETALINGSNR`,
    `BEDRAG`
FROM
	`boetes`
WHERE
	`BEDRAG` IN (50, 75, 100);

-- 2
SELECT
	*
FROM
	`wedstrijden`
WHERE
	`SPELERSNR` NOT IN (8, 27, 112);

-- 3
SELECT
	`SPELERSNR`,
    `NAAM`,
    `STRAAT`
FROM
	`spelers`
WHERE
	LEFT(`STRAAT`, 1) IN ("e", "l", "s");

-- 4
SELECT 
    `SPELERSNR`,
    `JAARTOE`,
    `GEB_DATUM`,
    YEAR(CURDATE()) - `JAARTOE` AS 'Aantal jaren',
    CASE
		WHEN YEAR(CURDATE()) - `JAARTOE` >= 45 THEN "45+"
		WHEN YEAR(CURDATE()) - `JAARTOE` >= 40 THEN "40+"
        WHEN YEAR(CURDATE()) - `JAARTOE` >= 35 THEN "35+"
    END AS 'Duurtijd'
FROM
    `spelers`
WHERE
    YEAR(`GEB_DATUM`) IN (1956 , 1963, 1970);
