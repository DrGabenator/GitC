select 
		Aluno,
		Idade,
		IIF(Ativo = 1, 'Ativo', 'Inativo') as 'Status'
	from AulaCsharp
  where Id in
	(select Id 
	  from AulaCsharp 
	where Idade > 27)
order by Idade asc