
CREATE PROCEDURE [dbo].[GetForeignLanguageByName]
	@foreignLanguage nvarchar(50)
AS
BEGIN
	SELECT * 
	FROM ForeignLanguage
	WHERE Name=@foreignLanguage
END
