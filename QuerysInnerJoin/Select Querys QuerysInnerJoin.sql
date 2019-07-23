--Trazer somente as marcas que Felipe cadastrou
select Nome from Marcas where UsuInc = 1;

--Trazer somente as marcas que Giomar cadastrou
select Nome from Marcas where UsuInc = 2;

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select COUNT(UsuInc) as 'Quantidade de marcas registradas' from Marcas where UsuInc = 1 order by [Quantidade de marcas registradas] desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select COUNT(UsuInc) as 'Quantidade de marcas registradas' from Marcas where UsuInc = 2 order by [Quantidade de marcas registradas] asc;

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select COUNT(UsuInc) as 'Quantidade de marcas registradas' from Marcas where UsuInc = 1 or UsuInc = 2;

--Trazer somente os carros que Felipe cadastrou
select Modelo from Carros where UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou
select Modelo from Carros where UsuInc = 2;

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select COUNT(UsuInc) as 'Quantidade de carros registrados' from Carros where UsuInc = 1 order by [Quantidade de carros registrados] desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select COUNT(UsuInc) as 'Quantidade de carros registrados' from Carros where UsuInc = 2 order by [Quantidade de carros registrados] asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select COUNT(UsuInc) as 'Quantidade de carros registrados' from Carros where UsuInc = 1 or UsuInc = 2;

--Trazer somente os carros das marcas que Felipe cadastrou
select Modelo from Carros inner join Marcas MA on Carros.Marca = MA.Id where MA.UsuInc = 1;

--Trazer somente os carros das marcas que Giomar cadastrou
select Modelo from Carros inner join Marcas MA on Carros.Marca = MA.Id where MA.UsuInc = 2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select COUNT(MA.UsuInc) as 'Quantidade de carros das marcas' from Carros inner join Marcas MA on Carros.Marca = MA.Id where MA.UsuInc = 1 order by [Quantidade de carros das marcas] desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select COUNT(MA.UsuInc) as 'Quantidade de carros das marcas' from Carros inner join Marcas MA on Carros.Marca = MA.Id where MA.UsuInc = 2 order by [Quantidade de carros das marcas] asc;

--Trazer o valor total de vendas 2019 isolado
select SUM(Valor * Quantidade) as 'Valor total de vendas em 2019' from Vendas where YEAR(DatInc) = 2019;

--Trazer a quantidade total de vendas 2019 isolado
select SUM(Quantidade) as 'Quantidade total de vendas em 2019' from Vendas where YEAR(DatInc) = 2019; 

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select SUM(Valor * Quantidade) as 'Valor total de vendas por ano', YEAR(DatInc) as 'Ano' from Vendas group by YEAR(DatInc) order by [Valor total de vendas por ano] desc;

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select COUNT(Valor) as 'Quantidade de vendas por ano', YEAR(DatInc) as 'Ano' from Vendas group by YEAR(DatInc) order by [Quantidade de vendas por ano] desc;

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
--		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select COUNT(Valor) as 'Quantidade total de vendas', MONTH(DatInc) as 'Mês', YEAR(DatInc) as 'Ano' from Vendas group by YEAR(DatInc), MONTH(DatInc) order by [Quantidade total de vendas] desc;

--Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select SUM(Valor * Quantidade) as 'Maior valor de vendas',  MONTH(DatInc) as 'Mês', YEAR(DatInc) as 'Ano' from Vendas group by YEAR(DatInc), MONTH(DatInc) order by [Maior valor de vendas] desc;

--Trazer o valor total de vendas que Felipe realizou
select SUM(Valor * Quantidade) as 'Valor total de vendas de Felipe' from Vendas where UsuInc = 1;

--Trazer o valor total de vendas que Giomar realizou
select SUM(Valor * Quantidade) as 'Valor total de vendas de Giomar' from Vendas where UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe realizou
select SUM(Quantidade) as 'Quantidade total de vendas de Felipe' from Vendas where UsuInc = 1;

--Trazer a quantidade de vendas que Giomar realizou
select SUM(Quantidade) as 'Quantidade total de vendas de Giomar' from Vendas where UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(Quantidade) as 'Quantidade total de vendas' from Vendas order by [Quantidade total de vendas];

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(Valor * Quantidade) as 'Valor total de vendas' from Vendas order by [Valor total de vendas];

--Trazer  a marca mais vendida de todos os anos
--		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select MA.Nome, SUM(VE.Quantidade) as 'Quantidade vendida' from Vendas VE inner join Carros CA on VE.Carro = CA.Id inner join Marcas MA on CA.Marca = MA.Id group by MA.Nome order by [Quantidade vendida] desc;

--Trazer o valor total da marca mais vendida de todos os anos
select MA.Nome, SUM(VE.Valor * VE.Quantidade) as 'Valor total' from Vendas VE inner join Carros CA on VE.Carro = CA.Id inner join Marcas MA on CA.Marca = MA.Id group by MA.Nome order by [Valor total] desc;

--Trazer a quantidade do carro mais vendido de todos os anos
select CA.Modelo, SUM(VE.Quantidade) as 'Quantidade total' from Vendas VE inner join Carros CA on VE.Carro = CA.Id inner join Marcas MA on CA.Marca = MA.Id group by CA.Modelo order by [Quantidade total] desc;

--Trazer o valor do carro mais vendido de todos os anos
select CA.Modelo, SUM(VE.Quantidade * VE.Valor) as 'Valor total' from Vendas VE inner join Carros CA on VE.Carro = CA.Id inner join Marcas MA on CA.Marca = MA.Id group by CA.Modelo order by [Valor total] desc;