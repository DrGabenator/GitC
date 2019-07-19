CREATE TABLE [dbo].[Boletim] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [Nota]       INT  NOT NULL,
    [Frequencia] BIT  NOT NULL,
    [Turma]      INT  NOT NULL,
    [Aluno]      INT  NOT NULL,
    [DataAula]   DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_To_Turmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id]),
    CONSTRAINT [FK_Notas_To_Aunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

