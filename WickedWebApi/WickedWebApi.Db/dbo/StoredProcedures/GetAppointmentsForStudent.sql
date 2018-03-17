  CREATE PROCEDURE [dbo].[GetAppointmentsForStudent]
	@id int
AS
BEGIN
  DECLARE @idGroup INT

  SELECT @idGroup = [Group]
  FROM Student
  WHERE Id = @id;

  SELECT [Id],[Class],[Day],[Hours],[ClassRoom],[Group],[Teacher]
  FROM  Appointment
  WHERE [Group] = @idGroup;

END