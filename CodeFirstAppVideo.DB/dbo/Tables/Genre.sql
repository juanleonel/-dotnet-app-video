CREATE TABLE [dbo].[Genre] (
    [GenreId]     INT           IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED ([GenreId] ASC)
);

