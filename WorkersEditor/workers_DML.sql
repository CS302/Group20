CREATE PROCEDURE select_drivers
AS
BEGIN
	SELECT * FROM Workers.dbo.driver
END
GO

CREATE PROCEDURE select_managers
AS
BEGIN
	SELECT * FROM Workers.dbo.manager
END
GO

CREATE PROCEDURE delete_driver
	@snn int
AS
BEGIN
	DELETE FROM Workers.dbo.driver
	WHERE Workers.dbo.driver.snn = @snn
END
GO

CREATE PROCEDURE insert_driver
	@snn int,
	@name varchar(20),
	@age int,
	@hours int,
	@cartype varchar(30)
AS
BEGIN
	INSERT INTO Workers.dbo.driver(snn, name, age, hours, carType)
	VALUES(@snn, @name, @age, @hours, @cartype)
END
GO