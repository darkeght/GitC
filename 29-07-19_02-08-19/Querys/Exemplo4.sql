select 
       al.Nome,
	   SUM(nt.Nota) / COUNT(fr.Ativo) as '´Média',
	   IIF((SUM(nt.Nota) / COUNT(nt.Nota) >= 7),'Aprovado','Reprovado') as 'Status Média',
	   IIF(((SUM(CONVERT(money,fr.Ativo)) / CONVERT(money,COUNT(fr.Ativo)) * 100) >= 75),'Aprovado','Reprovado') as 'Status Frequencia'
  from Alunos al
inner join Frequencia fr on al.Id = fr.Aluno
inner join Notas nt on al.Id = nt.Aluno
group by al.Nome
