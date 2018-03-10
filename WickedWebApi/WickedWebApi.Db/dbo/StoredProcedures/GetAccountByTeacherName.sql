CREATE PROCEDURE [dbo].[GetAccountByTeacherName]
	@teacherName nvarchar(50)
AS
BEGIN 
	SELECT Id
	From Teacher
	Where Name = @teacherName
End
