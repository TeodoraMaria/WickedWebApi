CREATE PROCEDURE [dbo].[LogIn]
	@email nvarchar(50),
	@password nvarchar(50)
AS
BEGIN
	SELECT TOP 1 Id
	FROM Account
	WHERE [Email]=@email AND [Password]=@password
	
END

