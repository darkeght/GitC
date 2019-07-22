select 
     Id,
     Dog,
	 SUM(Vendas) as 'Total Vendas',
	 MONTH(Data) as 'Mês'
from Doginho
where Id BETWEEN 8 and 11
group by Id,Dog,MONTH(Data)
order by 'Total Vendas' desc

