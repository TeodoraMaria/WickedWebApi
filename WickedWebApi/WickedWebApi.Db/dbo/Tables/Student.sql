CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Account] INT NOT NULL,
	 
	 [Group] INT NOT NULL, 
    CONSTRAINT [FK_Student_Account] FOREIGN KEY ([Account]) REFERENCES [Account]([Id]),
	 CONSTRAINT [FK_Student_Group] FOREIGN KEY ([Group]) REFERENCES [Group]([Id])
)
