CREATE PROCEDURE [dbo].[AddClass]
	@subject int,
	@type int
AS
BEGIN
	INSERT INTO Class
	VALUES(@subject, @type)

	SELECT SCOPE_IDENTITY() AS Id
END
