CREATE PROCEDURE [dbo].[GetAllFeedbacksForActualClass]
	@actualClassId int 
AS
BEGIN
	SELECT * FROM Feedback
	WHERE ActualClass = @actualClassId
END
