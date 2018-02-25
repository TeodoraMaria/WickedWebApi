CREATE PROCEDURE [dbo].[Register]
	@email nvarchar(50),
	@password nvarchar(50),
	@foreignLanguage nvarchar(50)
AS
DECLARE
@id INTEGER
BEGIN

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
  Student.ForeignLanguage = (SELECT * FROM [dbo].[GetForeignLanguage](@foreignLanguage))
FROM (SELECT Top 1 Student.ForeignLanguage From Student
      INNER JOIN  Account on Student.Account = Account.Id
      WHERE Account.Id = @id) al

  RETURN @id;
END