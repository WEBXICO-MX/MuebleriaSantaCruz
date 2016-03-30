/*
   miércoles, 30 de marzo de 201614:46:07
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
EXECUTE sp_rename N'dbo.medios_comunicacion.cliente_id', N'Tmp_persona_id', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.medios_comunicacion.Tmp_persona_id', N'persona_id', 'COLUMN' 
GO
ALTER TABLE dbo.medios_comunicacion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
