/*
   miércoles, 30 de marzo de 201613:19:21
   Usuario: 
   Servidor: localhost
   Base de datos: MuebleriaCASACRUZ
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.personas ADD
	estado_civil_id int NULL
GO
ALTER TABLE dbo.personas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
