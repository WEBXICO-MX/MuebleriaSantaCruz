/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     01/03/2016 12:50:31                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('asentamientos') and o.name = 'FK_ASENTAMI_REFERENCE_MUNICIPI')
alter table asentamientos
   drop constraint FK_ASENTAMI_REFERENCE_MUNICIPI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('asentamientos') and o.name = 'FK_ASENTAMI_REFERENCE_TIPOS_AS')
alter table asentamientos
   drop constraint FK_ASENTAMI_REFERENCE_TIPOS_AS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('clientes') and o.name = 'FK_CLIENTES_REFERENCE_PERSONAS')
alter table clientes
   drop constraint FK_CLIENTES_REFERENCE_PERSONAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('clientes') and o.name = 'FK_CLIENTES_REFERENCE_OCUPACIO')
alter table clientes
   drop constraint FK_CLIENTES_REFERENCE_OCUPACIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('clientes') and o.name = 'FK_CLIENTES_REFERENCE_TIPOS_ID')
alter table clientes
   drop constraint FK_CLIENTES_REFERENCE_TIPOS_ID
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('empleados') and o.name = 'FK_EMPLEADO_REFERENCE_PUESTOS')
alter table empleados
   drop constraint FK_EMPLEADO_REFERENCE_PUESTOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('empleados') and o.name = 'FK_EMPLEADO_REFERENCE_PERSONAS')
alter table empleados
   drop constraint FK_EMPLEADO_REFERENCE_PERSONAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grupos_seguridad_modulos') and o.name = 'FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD')
alter table grupos_seguridad_modulos
   drop constraint FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grupos_seguridad_modulos') and o.name = 'FK_GRUPOS_S_REFERENCE_MODULOS')
alter table grupos_seguridad_modulos
   drop constraint FK_GRUPOS_S_REFERENCE_MODULOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grupos_seguridad_usuarios') and o.name = 'FK_GRUPOS_S_REFERENCE_USUARIOS')
alter table grupos_seguridad_usuarios
   drop constraint FK_GRUPOS_S_REFERENCE_USUARIOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grupos_seguridad_usuarios') and o.name = 'FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD')
alter table grupos_seguridad_usuarios
   drop constraint FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('medios_comunicacion') and o.name = 'FK_MEDIOS_C_REFERENCE_CLIENTES')
alter table medios_comunicacion
   drop constraint FK_MEDIOS_C_REFERENCE_CLIENTES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('medios_comunicacion') and o.name = 'FK_MEDIOS_C_REFERENCE_TIPOS_ME')
alter table medios_comunicacion
   drop constraint FK_MEDIOS_C_REFERENCE_TIPOS_ME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('municipios') and o.name = 'FK_MUNICIPI_REFERENCE_ESTADOS')
alter table municipios
   drop constraint FK_MUNICIPI_REFERENCE_ESTADOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('productos') and o.name = 'FK_PRODUCTO_REFERENCE_TIPOS_PR')
alter table productos
   drop constraint FK_PRODUCTO_REFERENCE_TIPOS_PR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('rutas') and o.name = 'FK_RUTAS_REFERENCE_SUCURSAL')
alter table rutas
   drop constraint FK_RUTAS_REFERENCE_SUCURSAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tipos_productos') and o.name = 'FK_TIPOS_PR_REFERENCE_LINEAS_P')
alter table tipos_productos
   drop constraint FK_TIPOS_PR_REFERENCE_LINEAS_P
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('asentamientos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index asentamientos.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('asentamientos')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index asentamientos.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('asentamientos')
            and   type = 'U')
   drop table asentamientos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('clasificaciones_clientes')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index clasificaciones_clientes.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('clasificaciones_clientes')
            and   type = 'U')
   drop table clasificaciones_clientes
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('clasificaciones_contrato')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index clasificaciones_contrato.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('clasificaciones_contrato')
            and   type = 'U')
   drop table clasificaciones_contrato
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('clientes')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index clientes.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('clientes')
            and   type = 'U')
   drop table clientes
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('conceptos_pago')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index conceptos_pago.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('conceptos_pago')
            and   type = 'U')
   drop table conceptos_pago
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('empleados')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index empleados.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('empleados')
            and   type = 'U')
   drop table empleados
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('estados')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index estados.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('estados')
            and   type = 'U')
   drop table estados
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('grupos_seguridad')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index grupos_seguridad.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('grupos_seguridad')
            and   type = 'U')
   drop table grupos_seguridad
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('grupos_seguridad_modulos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index grupos_seguridad_modulos.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('grupos_seguridad_modulos')
            and   type = 'U')
   drop table grupos_seguridad_modulos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('grupos_seguridad_usuarios')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index grupos_seguridad_usuarios.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('grupos_seguridad_usuarios')
            and   type = 'U')
   drop table grupos_seguridad_usuarios
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('lineas_productos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index lineas_productos.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('lineas_productos')
            and   type = 'U')
   drop table lineas_productos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('medios_comunicacion')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index medios_comunicacion.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('medios_comunicacion')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index medios_comunicacion.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('medios_comunicacion')
            and   type = 'U')
   drop table medios_comunicacion
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('modulos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index modulos.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('modulos')
            and   type = 'U')
   drop table modulos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('municipios')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index municipios.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('municipios')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index municipios.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('municipios')
            and   type = 'U')
   drop table municipios
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ocupaciones')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index ocupaciones.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ocupaciones')
            and   type = 'U')
   drop table ocupaciones
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('personas')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index personas.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('personas')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index personas.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('personas')
            and   type = 'U')
   drop table personas
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('productos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index productos.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('productos')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index productos.index_2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('productos')
            and   name  = 'index_3'
            and   indid > 0
            and   indid < 255)
   drop index productos.index_3
go

if exists (select 1
            from  sysobjects
           where  id = object_id('productos')
            and   type = 'U')
   drop table productos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('proveedores')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index proveedores.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('proveedores')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index proveedores.index_2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('proveedores')
            and   name  = 'index_3'
            and   indid > 0
            and   indid < 255)
   drop index proveedores.index_3
go

if exists (select 1
            from  sysobjects
           where  id = object_id('proveedores')
            and   type = 'U')
   drop table proveedores
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('puestos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index puestos.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('puestos')
            and   type = 'U')
   drop table puestos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('rutas')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index rutas.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('rutas')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index rutas.index_2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('rutas')
            and   name  = 'index_3'
            and   indid > 0
            and   indid < 255)
   drop index rutas.index_3
go

if exists (select 1
            from  sysobjects
           where  id = object_id('rutas')
            and   type = 'U')
   drop table rutas
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('sucursales')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index sucursales.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('sucursales')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index sucursales.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sucursales')
            and   type = 'U')
   drop table sucursales
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_asentamientos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index tipos_asentamientos.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipos_asentamientos')
            and   type = 'U')
   drop table tipos_asentamientos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_identificacion')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index tipos_identificacion.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipos_identificacion')
            and   type = 'U')
   drop table tipos_identificacion
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_medios_comunicacion')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index tipos_medios_comunicacion.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipos_medios_comunicacion')
            and   type = 'U')
   drop table tipos_medios_comunicacion
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_productos')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index tipos_productos.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_productos')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index tipos_productos.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipos_productos')
            and   type = 'U')
   drop table tipos_productos
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('usuarios')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index usuarios.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('usuarios')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index usuarios.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('usuarios')
            and   type = 'U')
   drop table usuarios
go

/*==============================================================*/
/* Table: asentamientos                                         */
/*==============================================================*/
create table asentamientos (
   id                   int                  not null,
   tipo_asentamiento_id int                  null,
   municipio_id         int                  null,
   nombre               varchar(50)          null,
   cp                   varchar(5)           null,
   activo               bit                  null,
   constraint PK_ASENTAMIENTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on asentamientos (
nombre ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on asentamientos (
cp ASC
)
go

/*==============================================================*/
/* Table: clasificaciones_clientes                              */
/*==============================================================*/
create table clasificaciones_clientes (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_CLASIFICACIONES_CLIENTES primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on clasificaciones_clientes (
id ASC
)
go

/*==============================================================*/
/* Table: clasificaciones_contrato                              */
/*==============================================================*/
create table clasificaciones_contrato (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_CLASIFICACIONES_CONTRATO primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on clasificaciones_contrato (
id ASC
)
go

/*==============================================================*/
/* Table: clientes                                              */
/*==============================================================*/
create table clientes (
   persona_id           int                  not null,
   ocupacion_id         int                  null,
   tipo_identificacion_id int                  null,
   fecha_registro       datetime             null,
   activo               bit                  null,
   constraint PK_CLIENTES primary key (persona_id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on clientes (
persona_id ASC
)
go

/*==============================================================*/
/* Table: conceptos_pago                                        */
/*==============================================================*/
create table conceptos_pago (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_CONCEPTOS_PAGO primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on conceptos_pago (
id ASC
)
go

/*==============================================================*/
/* Table: empleados                                             */
/*==============================================================*/
create table empleados (
   persona_id           int                  not null,
   puesto_id            int                  null,
   fecha_registro       datetime             null,
   activo               bit                  null,
   constraint PK_EMPLEADOS primary key (persona_id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on empleados (
persona_id ASC
)
go

/*==============================================================*/
/* Table: estados                                               */
/*==============================================================*/
create table estados (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_ESTADOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on estados (
id ASC
)
go

/*==============================================================*/
/* Table: grupos_seguridad                                      */
/*==============================================================*/
create table grupos_seguridad (
   id                   int                  not null,
   nombre               varchar(50)          null,
   fecha_reg            datetime             null,
   fecha_mod            datetime             null,
   activo               bit                  null,
   constraint PK_GRUPOS_SEGURIDAD primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on grupos_seguridad (
id ASC
)
go

/*==============================================================*/
/* Table: grupos_seguridad_modulos                              */
/*==============================================================*/
create table grupos_seguridad_modulos (
   grupo_seguridad_id   int                  not null,
   modulo_id            int                  not null,
   fecha_reg            datetime             null,
   fecha_mod            datetime             null,
   activo               bit                  null,
   constraint PK_GRUPOS_SEGURIDAD_MODULOS primary key (grupo_seguridad_id, modulo_id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on grupos_seguridad_modulos (
grupo_seguridad_id ASC,
modulo_id ASC
)
go

/*==============================================================*/
/* Table: grupos_seguridad_usuarios                             */
/*==============================================================*/
create table grupos_seguridad_usuarios (
   grupo_seguridad_id   int                  not null,
   usuario_id           int                  not null,
   fecha_reg            datetime             null,
   fecha_mod            datetime             null,
   activo               bit                  null,
   constraint PK_GRUPOS_SEGURIDAD_USUARIOS primary key (grupo_seguridad_id, usuario_id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on grupos_seguridad_usuarios (
grupo_seguridad_id ASC,
usuario_id ASC
)
go

/*==============================================================*/
/* Table: lineas_productos                                      */
/*==============================================================*/
create table lineas_productos (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_LINEAS_PRODUCTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on lineas_productos (
id ASC
)
go

/*==============================================================*/
/* Table: medios_comunicacion                                   */
/*==============================================================*/
create table medios_comunicacion (
   id                   int                  not null,
   tipo_medio_comunicacion_id int                  null,
   cliente_id           int                  null,
   valor                varchar(50)          null,
   activo               bit                  null,
   constraint PK_MEDIOS_COMUNICACION primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on medios_comunicacion (
cliente_id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on medios_comunicacion (
id ASC
)
go

/*==============================================================*/
/* Table: modulos                                               */
/*==============================================================*/
create table modulos (
   id                   int                  not null,
   nombre               varchar(50)          null,
   fecha_reg            datetime             null,
   fecha_mod            datetime             null,
   activo               bit                  null,
   constraint PK_MODULOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on modulos (
id ASC
)
go

/*==============================================================*/
/* Table: municipios                                            */
/*==============================================================*/
create table municipios (
   id                   int                  not null,
   estado_id            int                  null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_MUNICIPIOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on municipios (
estado_id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on municipios (
id ASC
)
go

/*==============================================================*/
/* Table: ocupaciones                                           */
/*==============================================================*/
create table ocupaciones (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_OCUPACIONES primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on ocupaciones (
id ASC
)
go

/*==============================================================*/
/* Table: personas                                              */
/*==============================================================*/
create table personas (
   id                   int                  not null,
   nombre               varchar(50)          null,
   ap_paterno           varchar(50)          null,
   ap_materno           varchar(50)          null,
   fecha_nacimiento     date                 null,
   sexo                 varchar(1)           null,
   constraint PK_PERSONAS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on personas (
id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on personas (
nombre ASC,
ap_paterno ASC,
ap_materno ASC
)
go

/*==============================================================*/
/* Table: productos                                             */
/*==============================================================*/
create table productos (
   id                   int                  not null,
   tipo_producto_id     int                  null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_PRODUCTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_3                                               */
/*==============================================================*/
create index index_3 on productos (
tipo_producto_id ASC
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on productos (
nombre ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on productos (
id ASC
)
go

/*==============================================================*/
/* Table: proveedores                                           */
/*==============================================================*/
create table proveedores (
   id                   int                  not null,
   nombre_comercial     varchar(100)         null,
   razon_social         varchar(100)         null,
   activo               bit                  null,
   constraint PK_PROVEEDORES primary key (id)
)
go

/*==============================================================*/
/* Index: index_3                                               */
/*==============================================================*/
create index index_3 on proveedores (
razon_social ASC
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on proveedores (
nombre_comercial ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on proveedores (
id ASC
)
go

/*==============================================================*/
/* Table: puestos                                               */
/*==============================================================*/
create table puestos (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_PUESTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on puestos (
id ASC
)
go

/*==============================================================*/
/* Table: rutas                                                 */
/*==============================================================*/
create table rutas (
   id                   int                  not null,
   sucursal_id          int                  null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_RUTAS primary key (id)
)
go

/*==============================================================*/
/* Index: index_3                                               */
/*==============================================================*/
create index index_3 on rutas (
nombre ASC
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on rutas (
sucursal_id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on rutas (
id ASC
)
go

/*==============================================================*/
/* Table: sucursales                                            */
/*==============================================================*/
create table sucursales (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_SUCURSALES primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on sucursales (
nombre ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on sucursales (
id ASC
)
go

/*==============================================================*/
/* Table: tipos_asentamientos                                   */
/*==============================================================*/
create table tipos_asentamientos (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_TIPOS_ASENTAMIENTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on tipos_asentamientos (
id ASC
)
go

/*==============================================================*/
/* Table: tipos_identificacion                                  */
/*==============================================================*/
create table tipos_identificacion (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_TIPOS_IDENTIFICACION primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on tipos_identificacion (
id ASC
)
go

/*==============================================================*/
/* Table: tipos_medios_comunicacion                             */
/*==============================================================*/
create table tipos_medios_comunicacion (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_TIPOS_MEDIOS_COMUNICACION primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on tipos_medios_comunicacion (
id ASC
)
go

/*==============================================================*/
/* Table: tipos_productos                                       */
/*==============================================================*/
create table tipos_productos (
   id                   int                  not null,
   linea_producto_id    int                  null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_TIPOS_PRODUCTOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on tipos_productos (
linea_producto_id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on tipos_productos (
id ASC
)
go

/*==============================================================*/
/* Table: usuarios                                              */
/*==============================================================*/
create table usuarios (
   id                   int                  not null,
   nombre_completo      varchar(50)          null,
   login                varchar(15)          null,
   password             varchar(15)          null,
   fecha_reg            datetime             null,
   fecha_mod            datetime             null,
   activo               bit                  null,
   constraint PK_USUARIOS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on usuarios (
login ASC,
password ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on usuarios (
id ASC
)
go

alter table asentamientos
   add constraint FK_ASENTAMI_REFERENCE_MUNICIPI foreign key (municipio_id)
      references municipios (id)
go

alter table asentamientos
   add constraint FK_ASENTAMI_REFERENCE_TIPOS_AS foreign key (tipo_asentamiento_id)
      references tipos_asentamientos (id)
go

alter table clientes
   add constraint FK_CLIENTES_REFERENCE_PERSONAS foreign key (persona_id)
      references personas (id)
go

alter table clientes
   add constraint FK_CLIENTES_REFERENCE_OCUPACIO foreign key (ocupacion_id)
      references ocupaciones (id)
go

alter table clientes
   add constraint FK_CLIENTES_REFERENCE_TIPOS_ID foreign key (tipo_identificacion_id)
      references tipos_identificacion (id)
go

alter table empleados
   add constraint FK_EMPLEADO_REFERENCE_PUESTOS foreign key (puesto_id)
      references puestos (id)
go

alter table empleados
   add constraint FK_EMPLEADO_REFERENCE_PERSONAS foreign key (persona_id)
      references personas (id)
go

alter table grupos_seguridad_modulos
   add constraint FK_GRUPOS_S_MODULOS_REFERENCE_GRUPOS_SEGURIDAD foreign key (grupo_seguridad_id)
      references grupos_seguridad (id)
go

alter table grupos_seguridad_modulos
   add constraint FK_GRUPOS_S_REFERENCE_MODULOS foreign key (modulo_id)
      references modulos (id)
go

alter table grupos_seguridad_usuarios
   add constraint FK_GRUPOS_S_REFERENCE_USUARIOS foreign key (usuario_id)
      references usuarios (id)
go

alter table grupos_seguridad_usuarios
   add constraint FK_GRUPOS_S_USUARIOS_REFERENCE_GRUPOS_SEGURIDAD foreign key (grupo_seguridad_id)
      references grupos_seguridad (id)
go

alter table medios_comunicacion
   add constraint FK_MEDIOS_C_REFERENCE_CLIENTES foreign key (cliente_id)
      references clientes (persona_id)
go

alter table medios_comunicacion
   add constraint FK_MEDIOS_C_REFERENCE_TIPOS_ME foreign key (tipo_medio_comunicacion_id)
      references tipos_medios_comunicacion (id)
go

alter table municipios
   add constraint FK_MUNICIPI_REFERENCE_ESTADOS foreign key (estado_id)
      references estados (id)
go

alter table productos
   add constraint FK_PRODUCTO_REFERENCE_TIPOS_PR foreign key (tipo_producto_id)
      references tipos_productos (id)
go

alter table rutas
   add constraint FK_RUTAS_REFERENCE_SUCURSAL foreign key (sucursal_id)
      references sucursales (id)
go

alter table tipos_productos
   add constraint FK_TIPOS_PR_REFERENCE_LINEAS_P foreign key (linea_producto_id)
      references lineas_productos (id)
go

