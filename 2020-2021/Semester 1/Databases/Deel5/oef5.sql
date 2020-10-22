USE `tennis`;

-- 1
SELECT 
	`SPELERSNR`
FROM 
	`spelers`
WHERE
	`BONDSNR` IS NOT NULL;
    
-- 2
SELECT
	COUNT(`SPELERSNR`) AS "Actieve bestuursleden"
FROM
	`bestuursleden`
WHERE
	`EIND_DATUM` IS NOT NULL;