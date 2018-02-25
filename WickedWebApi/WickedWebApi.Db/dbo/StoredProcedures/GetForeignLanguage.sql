
CREATE PROCEDURE [dbo].[GetForeignLanguage]
	@foreignLanguage nvarchar(50)
AS
DECLARE
@id int = (SELECT Top 1 Id From ForeignLanguage WHERE Name LIKE @foreignLanguage);
BEGIN
  if(@id IS NULL )
  BEGIN
    Exec dbo.InsertForeignLanguage @foreignLanguage;
    SET @id = (SELECT * From dbo.GetForeignLanguage (@foreignLanguage));
  END
  RETURN @id;
END
