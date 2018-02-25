CREATE TABLE [dbo].[Teacher]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Account] INT NULL, 
    CONSTRAINT [FK_Teacher_Account] FOREIGN KEY ([Account]) REFERENCES [Account]([Id])
)
