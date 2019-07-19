CREATE TABLE [dbo].[Alunos] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (200) NOT NULL,
    [Ativo] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

