CREATE PROCEDURE [dbo].[AddActualClass]
	@id int ,
	@date DATE
AS
BEGIN
	INSERT INTO dbo.[ActualClass](Class, Date)
	VALUES (@id,@date)

	SELECT SCOPE_IDENTITY() as Id
END
