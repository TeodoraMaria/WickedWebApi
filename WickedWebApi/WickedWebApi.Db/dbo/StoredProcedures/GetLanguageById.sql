CREATE PROCEDURE [dbo].[GetLanguageById]
	@id int
AS
BEGIN
	SELECT *
	FROM ForeignLanguage
	WHERE Id=@id
END
