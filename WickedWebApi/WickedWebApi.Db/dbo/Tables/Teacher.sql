CREATE TABLE [dbo].[Teacher]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Account] INT NOT NULL, 
    CONSTRAINT [FK_Teacher_Account] FOREIGN KEY ([Account]) REFERENCES [Account]([Id])
)
