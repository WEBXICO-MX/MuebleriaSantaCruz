/*
   miércoles, 30 de marzo de 201613:21:31
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
ALTER TABLE dbo.estados_civiles SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.personas ADD CONSTRAINT
	FK_personas_estados_civiles FOREIGN KEY
	(
	estado_civil_id
	) REFERENCES dbo.estados_civiles
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.personas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
