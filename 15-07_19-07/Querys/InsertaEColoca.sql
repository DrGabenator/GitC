insert into dbo.Diario1
(Aluno,Materia,Nota1,Nota2,Nota3,Nota4,Nota5,Nota6)
values
('Felipe','Java',5,5,5,5,5,5)
select * from Diario1;


select
		Aluno,
		Materia,
		((([Nota1]+[Nota2]+[Nota3]+[Nota4]+[Nota5]+[Nota6])/6)) as 'Media',
		IIF(((([Nota1]+[Nota2]+[Nota3]+[Nota4]+[Nota5]+[Nota6])/6)) >= 5,'Aprovado','Reprovado') as 'Status'
from Diario1