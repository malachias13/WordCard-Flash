CREATE TABLE [dbo].[CardTables] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [word]       NVARCHAR (20)  NOT NULL,
    [definition] NVARCHAR (MAX) NULL
);

