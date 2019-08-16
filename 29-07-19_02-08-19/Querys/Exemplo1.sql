 select 
        a.Nome,
		IIF(((select count(*) from Notas n where n.Aluno = a.Id and n.Presenca = 1) * 100.00)
		/ ((select count(*) from Notas n where n.Aluno = a.Id)) >= 75,'Aprovado','Reprovado') as 'Status Frequencia'
   from Alunos a