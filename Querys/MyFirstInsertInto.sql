insert into AulaCsharp
(Aluno, Idade, Ativo, UsuInc, UsuAlt, DataInc, DataAlt)
values
('Gabriel A.', 25, 1, 1, 1,GETDATE(),GETDATE()),
('Rafael', 29, 1, 1, 1,GETDATE(),GETDATE()),
('Felipe', 27, 1, 1, 1,GETDATE(),GETDATE()),
('Nicholas', 21, 1, 1, 1,GETDATE(),GETDATE()),
('Christian', 28, 1, 1, 1,GETDATE(),GETDATE())
go
select * from dbo.AulaCsharp
