select
       a.Nome,
	   SUM(iif(n.Presenca=1,100,null)) / COUNT(n.Presenca) ,
	   SUM(n.Nota) / COUNT(n.Nota) as '´Média',
	   IIF((SUM(n.Nota) / COUNT(n.Nota) >= 7),'Aprovado','Reprovado') as 'Status Média',
	  IIF(SUM(iif(n.Presenca=1,100,null)) / COUNT(n.Presenca) >= 75,'Aprovado','Reprovado') as 'Status Frequencia'
  from Alunos a
  inner join Notas n on a.Id = n.Aluno
  group by a.Nome;


 
