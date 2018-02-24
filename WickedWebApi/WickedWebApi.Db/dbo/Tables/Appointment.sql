CREATE TABLE [dbo].[Appointment]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Class] INT NOT NULL, 
    [Day] INT NOT NULL, 
    [Hours] INT NOT NULL, 
    [ClassRoom] NVARCHAR(20) NOT NULL, 
    [Group] INT NOT NULL, 
    [Teacher] INT NOT NULL, 
    CONSTRAINT [FK_Appointment_Class] FOREIGN KEY ([Class]) REFERENCES [Class]([Id]), 
    CONSTRAINT [FK_Appointment_Group] FOREIGN KEY ([Group]) REFERENCES [Group]([Id]), 
    CONSTRAINT [FK_Appointment_Teacher] FOREIGN KEY ([Teacher]) REFERENCES [Teacher]([Id])
)
