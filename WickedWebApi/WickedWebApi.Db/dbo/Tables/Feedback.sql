CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [ActualClass] INT NOT NULL, 
    [Usefulness] INT NOT NULL, 
    [Novelty] INT NOT NULL, 
    [HighScientificLevel] INT NOT NULL, 
    [RigorousScientificLevel] INT NOT NULL, 
    [Attractiveness] INT NOT NULL, 
    [Clearness] INT NOT NULL, 
    [Correctness] INT NOT NULL, 
    [Interactivity] INT NOT NULL, 
    [Comprehesion] INT NOT NULL, 
    [Comment] NVARCHAR(250) NULL
	CONSTRAINT [FK_Feedback_ActualClass] FOREIGN KEY ([ActualClass]) REFERENCES [ActualClass]([Id])
)
