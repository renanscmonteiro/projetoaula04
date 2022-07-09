# Projeto C# Console Application / SQL Server
Sistema criado para acesso ao SQL Server com Dapper.

## Requisitos necessários:

* VisualStudio2022
* SQl Server

## Script do banco de dados
```sql
	CREATE TABLE [dbo].[MENSAGEM] (
		[IDMENSAGEM] UNIQUEIDENTIFIER NOT NULL,
		[EMAIL]      NVARCHAR (100)   NOT NULL,
		[ASSUNTO]    NVARCHAR (100)   NOT NULL,
		[TEXTO]      NVARCHAR (MAX)   NOT NULL
	);
```
