CREATE PROCEDURE [dbo].[GetGroupByName]
	@name NVARCHAR(50)
AS
BEGIN

  SELECT [Id],[Name]
  FROM [Group]
  WHERE Name = @name;
  
END