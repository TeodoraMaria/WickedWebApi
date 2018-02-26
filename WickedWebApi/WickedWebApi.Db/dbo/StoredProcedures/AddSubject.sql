CREATE PROCEDURE [dbo].[AddSubject]
	@name nvarchar(50)
AS
BEGIN
	INSERT INTO [Subject]
	VALUES (@name)

	SELECT SCOPE_IDENTITY() AS Id
END
