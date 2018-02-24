CREATE PROCEDURE [dbo].[CheckEmail]
	@email nvarchar(50)
AS
BEGIN
	SELECT *
	FROM Account
	WHERE Email=@email
END
