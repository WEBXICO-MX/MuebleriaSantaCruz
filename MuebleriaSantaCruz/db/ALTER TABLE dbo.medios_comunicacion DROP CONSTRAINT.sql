/*
   miércoles, 30 de marzo de 201614:45:08
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
ALTER TABLE dbo.medios_comunicacion
	DROP CONSTRAINT FK_MEDIOS_C_REFERENCE_CLIENTES
GO
ALTER TABLE dbo.clientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.medios_comunicacion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
