CREATE PROCEDURE [dbo].[Register]
	@email nvarchar(50),
	@password nvarchar(50),
	@foreignLanguage int
AS
BEGIN
DECLARE @id int = -1
UPDATE
    Account
SET
    Account.Password =@password,
    @id = Account.Id
FROM Account
WHERE
	  [Email]=@email AND [Password] IS NULL
	
	if(@id Like -1)RETURN 0;

UPDATE
  Student
SET
  Student.ForeignLanguage = @foreignLanguage
FROM Student
Where Student.Account = @id
	Select @id as Id;
END