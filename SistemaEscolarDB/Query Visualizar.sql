select
		AL.Nome as 'Nome do aluno',
		TU.Materia as 'Matéria',
		TU.Nome as 'Turma',
		SUM(BO.Nota) / 4 as 'Média do aluno',
		(CONVERT(money,COUNT(NULLIF(BO.Frequencia,0)) * 100) / (COUNT(BO.DataAula))) as 'Frequência %',
		IIF(((SUM(BO.Nota) / 4) >= 7), 'Aprovado','Reprovado') as 'Situação por média',
		IIF((CONVERT(money,COUNT(NULLIF(BO.Frequencia,0)) * 100) / (COUNT(BO.DataAula))) >= 75, 'Aprovado', 'Reprovado') as 'Situação por frequencia',
		IIF((CONVERT(money,COUNT(NULLIF(BO.Frequencia,0)) * 100) / (COUNT(BO.DataAula))) >= 75 AND (SUM(BO.Nota) / 4) >= 7, 'Aprovado','Reprovado') as 'Situação geral'
		
	from Alunos AL
	inner join Boletim BO on BO.Aluno = AL.Id
	inner join Turmas TU on BO.Turma = TU.Id
	group by AL.Nome, TU.Materia, TU.Nome
	