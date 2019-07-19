CREATE TABLE [dbo].[Locacoes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Livro] INT NOT NULL, 
    [Usuario] INT NOT NULL,
	[Tipo] INT NOT NULL,
	[Devolucao] DATETIME NOT NULL,
    [Ativo] BIT NOT NULL, 
	[UsuInc] INT NOT NULL,
	[UsuAlt] INT NOT NULL,
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Locacoes_To_Livros] FOREIGN KEY ([Livro]) REFERENCES [Livros]([Id]),
	CONSTRAINT [FK_Locacoes_To_UsuarioLoc] FOREIGN KEY ([Usuario]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Locacoes_To_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Locacoes_To_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
