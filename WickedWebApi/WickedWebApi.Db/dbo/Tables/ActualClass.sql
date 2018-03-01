CREATE TABLE [dbo].[ActualClass]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Class] INT NOT NULL, 
    [Date] DATETIME NOT NULL
	CONSTRAINT [FK_ActualClass_Class] FOREIGN KEY ([Class]) REFERENCES [Class]([Id]) DEFAULT GetDate()
)
