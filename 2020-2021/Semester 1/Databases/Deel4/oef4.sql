USE `tennis`;

-- 1
SELECT
	MAX(`GEWONNEN` - `VERLOREN`) AS  "Maximaal"
FROM
	`wedstrijden`;
    
-- 2
SELECT
	COUNT(`WEDSTRIJDNR`) AS "Aantal"
FROM
	`wedstrijden`;