CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Account] INT NOT NULL,
	 
	 [Group] INT NOT NULL, 
    [ForeignLanguage] INT NULL, 
    CONSTRAINT [FK_Student_Account] FOREIGN KEY ([Account]) REFERENCES [Account]([Id]),
	 CONSTRAINT [FK_Student_Group] FOREIGN KEY ([Group]) REFERENCES [Group]([Id])
)
