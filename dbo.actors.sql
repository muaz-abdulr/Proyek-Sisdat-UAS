CREATE TABLE [dbo].[actors] (
    [actor_id]   INT          NOT NULL,
    [actor_name] VARCHAR (40) NULL,
    [gender]     VARCHAR (10) NULL,
    [age]        INT          NULL,
    [bio]        TEXT         NULL,
    [apala] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([actor_id] ASC)
);

