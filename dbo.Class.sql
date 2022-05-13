CREATE TABLE [dbo].[Class] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NULL,
    [Email]        NVARCHAR (MAX) NULL,
    [Subscription] NVARCHAR (MAX) NULL,
    [Assigned]     DATETIME2 (7)  NOT NULL,
    [Expired]      DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED ([ID] ASC)
);

