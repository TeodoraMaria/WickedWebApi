CREATE TABLE [dbo].[Class]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Subject] INT NULL, 
    [Type] TINYINT NULL, 
    CONSTRAINT [FK_Class_Subject] FOREIGN KEY ([Subject]) REFERENCES [Subject]([Id]) ON DELETE CASCADE
)
