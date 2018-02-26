CREATE PROCEDURE [dbo].[AddStudent]
	@accountId int ,
	@groupId int,
	@langId int
AS
BEGIN
	INSERT INTO Student([Account],[Group],[ForeignLanguage])
	VALUES(@accountId, @groupId, @langId)
END
