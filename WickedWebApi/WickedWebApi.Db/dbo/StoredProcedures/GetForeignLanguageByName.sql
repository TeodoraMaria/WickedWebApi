
CREATE PROCEDURE [dbo].[GetForeignLanguageByName]
	@foreignLanguage nvarchar(50)
AS
BEGIN
	SELECT Id 
	FROM ForeignLanguage
	WHERE Name=@foreignLanguage
END
