CREATE TABLE [dbo].[Turmas] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]    VARCHAR (100) NOT NULL,
    [Materia] VARCHAR (50)  NOT NULL,
    [Ativo]   BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

