CREATE TABLE [dbo].[Video] (
    [VideoId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]   NVARCHAR (MAX) NULL,
    [GenreId] INT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Videos] PRIMARY KEY CLUSTERED ([VideoId] ASC),
    CONSTRAINT [FK_Video_Genre] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genre] ([GenreId])
);

