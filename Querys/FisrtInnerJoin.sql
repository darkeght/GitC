select 
        BL.Nome,
		COUNT(LV.Id) as 'QuantLivros',
		US.Nome as 'UserName'
  from Biblioteca BL
  inner join Livro LV on BL.Id = LV.Biblioteca
  inner join Usuario  US on LV.UserInc = US.Id
  group by BL.Nome,US.Nome