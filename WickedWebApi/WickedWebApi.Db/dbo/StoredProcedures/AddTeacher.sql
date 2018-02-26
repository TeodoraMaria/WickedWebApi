CREATE PROCEDURE [dbo].[AddTeacher]
	@name nvarchar(50),
	@account int
AS
BEGIN
	INSERT INTO Teacher
	VALUES(@name, @account)

	SELECT SCOPE_IDENTITY() as Id
END
