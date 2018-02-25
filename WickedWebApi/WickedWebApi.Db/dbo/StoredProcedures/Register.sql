CREATE PROCEDURE [dbo].[Register]
	@email nvarchar(50),
	@password nvarchar(50),
	@foreignLanguage int
AS
BEGIN
DECLARE @id int
UPDATE
    Account
SET
    Account.Password =@password,
    @id = Account.Id
FROM Account
WHERE
	  [Email]=@email AND [Password] IS NULL


UPDATE
  Student
SET
  Student.ForeignLanguage = @foreignLanguage
FROM (SELECT Top 1 Student.ForeignLanguage 
	  FROM Student
      WHERE Student.Account = @id) al
  RETURN @id;
END