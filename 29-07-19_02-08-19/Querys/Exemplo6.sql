SELECT 
      A.Nome,
	  SUM(NT.Nota) / COUNT(NT.Nota) as 'Média',
	  IIF(SUM(NT.Nota) / COUNT(NT.Nota) >= 7,'Aprovado','Reprovado')  as 'Status Média',
	  IIF((SUM(CONVERT(MONEY,NT.Presenca)) / CONVERT(MONEY,COUNT(NT.Presenca)) * 100) >= 75,'Aprovado','Reprovado') as 'Status Frequencia'
 FROM Alunos A
INNER JOIN Notas NT ON A.Id = NT.Aluno
GROUP BY A.Nome;

