--DDL
CREATE TABLE driver(
	snn		int NOT NULL,
	name	varchar(20) NOT NULL,
	age		int NOT NULL,
	hours	int	NULL,
	carType	varchar(30) NULL,
	PRIMARY KEY(snn)
)
GO

CREATE TABLE manager(
	snn		int NOT NULL,
	name	varchar(20) NOT NULL,
	age		int NOT NULL,
	projCount	int NULL,
	PRIMARY KEY(snn)
)
GO