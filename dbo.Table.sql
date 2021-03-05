CREATE TABLE [dbo].[Buyers]
(
	[Id buyers] INT NOT NULL PRIMARY KEY, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Patronymic] NVARCHAR(50) NULL, 
    [Mail] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL
)
