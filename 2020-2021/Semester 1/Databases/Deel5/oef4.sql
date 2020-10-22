USE `tennis`;

-- 1
SELECT
	`SPELERSNR`,
    `NAAM`,
    `STRAAT`
FROM
	`spelers`
WHERE
	`STRAAT` LIKE "%weg";

-- 2
SELECT
	`SPELERSNR`,
    `NAAM`,
    `STRAAT`
FROM
	`spelers`
WHERE
	`STRAAT` LIKE "h%e%";

-- 3
SELECT
	`SPELERSNR`,
    `NAAM`
FROM
	`spelers`
WHERE
	`NAAM` NOT LIKE "_i%";

-- 4
SELECT
	`SPELERSNR`,
    `NAAM`
FROM
	`spelers`
WHERE
	`NAAM` LIKE "_e%e_";