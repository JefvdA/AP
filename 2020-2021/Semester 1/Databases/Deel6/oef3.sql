USE `tennis`;

SELECT
	s.`SPELERSNR`,
    t.`TEAMNR`
FROM
	`spelers` s
    INNER JOIN `wedstrijden` w ON w.`SPELERSNR` = s.`SPELERSNR`
    INNER JOIN `teams` t ON t.`TEAMNR` = w.`TEAMNR`