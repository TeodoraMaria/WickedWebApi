
CREATE PROCEDURE [dbo].[InsertForeignLanguage]
	@foreignLanguage nvarchar(50)
AS
BEGIN
  INSERT INTO ForeignLanguage (Name) VALUES (@foreignLanguage);

  SELECT SCOPE_IDENTITY()
END