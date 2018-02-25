CREATE PROCEDURE [dbo].[AddAppointment]
	@class int,
	@day int,
	@hour int,
	@classroom int,
	@group int,
	@teacher int
AS
BEGIN
	INSERT INTO Appointment
	VALUES(@class, @day, @hour, @classroom, @group, @teacher)
END
