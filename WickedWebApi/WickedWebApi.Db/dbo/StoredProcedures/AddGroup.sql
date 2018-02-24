CREATE PROCEDURE [dbo].[AddGroup]
	@name nvarchar(50)
AS
BEGIN
	INSERT INTO [Group]([Name])
	VALUES (@name)

	SELECT SCOPE_IDENTITY() as Id
END
