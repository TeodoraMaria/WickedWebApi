CREATE PROCEDURE [dbo].[AddAppointment]
	@class int,
	@day nvarchar(50),
	@hour nvarchar(50),
	@classroom nvarchar(50),
	@group int,
	@teacher int
AS
BEGIN
	INSERT INTO [Appointment]
	VALUES(@class, @day, @hour, @classroom, @group, @teacher)
END
