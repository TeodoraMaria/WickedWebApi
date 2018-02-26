CREATE TABLE [dbo].[Account]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NULL, 
    [IsAdmin] BIT NOT NULL
)
