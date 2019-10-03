CREATE TABLE [dbo].[PublicSpace] (
    [Id]   INT           NOT NULL,
    [租借人]  NCHAR (10)    NOT NULL,
    [租借地點] NVARCHAR (30) NOT NULL,
    [租借時間] DATETIME      NOT NULL,
	[歸還時間] DATETIME      NOT NULL,
    [用途] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

