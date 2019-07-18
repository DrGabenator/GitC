select 
		Modelo,
		Ano,
		(SUM(NumeroVendas) / COUNT(*)) as 'Média',
		YEAR(DataVenda) as 'Ano vendas'
	from Carros
	group by Modelo,Ano,YEAR(DataVenda)
	order by Ano asc