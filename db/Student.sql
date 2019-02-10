CREATE TABLE `student_details` (
	`stid` VARCHAR(50) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
	`surname` VARCHAR(50) NOT NULL,
	`dateOfBirth` VARCHAR(50) NOT NULL,
	`gender` VARCHAR(15) NOT NULL,
	`nationality` VARCHAR(50) NOT NULL,
	`class` VARCHAR(9) NOT NULL,
	`term` VARCHAR(50) NOT NULL,
	`address` VARCHAR(50) NOT NULL,
	`guidanceName` VARCHAR(50) NOT NULL,
	`occupation` VARCHAR(50) NOT NULL,
	`phone` VARCHAR(50) NOT NULL,
	`date_registered` VARCHAR(121) NOT NULL DEFAULT '',
	PRIMARY KEY (`stid`)
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB
;
