--Quantidade de alocações em 2018
select 
	CA.Nome,
	SUM(LO.Alocados) as 'Quantidade alocações em 2018'
	
	from Locacoes LO
	inner join Carros CA on LO.Carro = CA.Id
	where YEAR(LO.DataAloc) = 2018
	group by CA.Nome
	order by 'Quantidade alocações em 2018' desc

--Quantidade de alocações em 2019	
select 
	CA.Nome,
	SUM(LO.Alocados) as 'Quantidade alocações em 2019'
	
	from Locacoes LO
	inner join Carros CA on LO.Carro = CA.Id
	where YEAR(LO.DataAloc) = 2019
	group by CA.Nome
	order by 'Quantidade alocações em 2019' desc

--Meses em 2018
select
	CA.Nome,
	SUM(LO.Alocados) as 'Quantidade de alocações por mês',
	MONTH(LO.DataAloc) as 'Mês'
	
	from Locacoes LO
	inner join Carros CA on LO.Carro = CA.Id
	where MONTH(LO.DataAloc) between 1 and 12 -- coloque aqui os meses desejado
	and YEAR(LO.DataAloc) = 2018 -- coloque aqui o ano desejado
	group by CA.Nome, LO.DataAloc
	order by 'Quantidade de alocações por mês' desc

--Meses em 2019
select
	CA.Nome,
	SUM(LO.Alocados) as 'Quantidade de alocações por mês',
	MONTH(LO.DataAloc) as 'Mês'
	
	from Locacoes LO
	inner join Carros CA on LO.Carro = CA.Id
	where MONTH(LO.DataAloc) between 1 and 12 -- coloque aqui os meses desejado
	and YEAR(LO.DataAloc) = 2019 -- coloque aqui o ano desejado
	group by CA.Nome, LO.DataAloc
	order by 'Quantidade de alocações por mês' desc

--Carro mais alocado de todos os registros
select
	CA.Nome,
	COUNT(LO.Alocados) as 'Mais alocado'

	from Locacoes LO
	inner join Carros CA on LO.Carro = CA.Id
	group by CA.Nome
	order by 'Mais alocado' desc