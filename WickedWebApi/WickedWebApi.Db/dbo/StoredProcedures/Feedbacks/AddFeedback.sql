CREATE PROCEDURE [dbo].[AddFeedback]
	@actualClassId int,
	@usefulness int,
	@novelty int,
	@highScientificLevel int,
	@rigorousScientificLevel int,
	@attractivenes int,
	@clearness int,
	@correctness int,
	@interactivity int,
	@comprehension int,
	@comment nvarchar(250)
AS
BEGIN
	INSERT INTO [dbo].[Feedback]
           ([ActualClass]
           ,[Usefulness]
           ,[Novelty]
           ,[HighScientificLevel]
           ,[RigorousScientificLevel]
           ,[Attractiveness]
           ,[Clearness]
           ,[Correctness]
           ,[Interactivity]
           ,[Comprehension]
		   ,[Comment])
     VALUES
           (@actualClassId, 
		   @usefulness, 
		   @novelty, 
		   @highScientificLevel, 
		   @rigorousScientificLevel,
		   @attractivenes, 
		   @clearness, 
		   @correctness,
		   @interactivity,
		   @comprehension,
		   @comment);

	SELECT SCOPE_IDENTITY();
END

