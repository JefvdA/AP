USE `tennis`;

-- 1 
SELECT
	s.*,
	b.`BETALINGSNR`,
	b.`BEDRAG`
FROM
	`boetes` b,
	(
		SELECT
			`SPELERSNR`,
			`NAAM`,
			`PLAATS`
		FROM
			`spelers`
		WHERE
			`PLAATS` = "Den Haag"
			OR SUBSTR(`NAAM`, 1, 1) = "C"
	) s;