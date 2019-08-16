select 
		Dog,
		SUM(Vendas) as 'Total',
		MONTH(DataVenda) as 'Mês da venda'
	from FoodTruckZezinho
	group by Dog,MONTH(DataVenda)
	order by Total desc