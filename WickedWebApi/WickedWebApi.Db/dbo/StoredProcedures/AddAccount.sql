CREATE PROCEDURE [dbo].[AddAccount]
	@email nvarchar(50),
	@password nvarchar(50),
	@isAdmin int
AS
BEGIN
	INSERT INTO Account([Email], [Password], [IsAdmin])
	VALUES(@email, @password, @isAdmin)

	SELECT SCOPE_IDENTITY() as Id
END
