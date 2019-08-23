insert into AulaCsharp
(Aluno,Ativo,Idade,UsuInc,UsuAlt,Datinc,DatAlt)
values
(CONCAT('Felipe',GETDATE()),0,27,0,0,GETDATE(),GETDATE())
go
select * from AulaCsharp;