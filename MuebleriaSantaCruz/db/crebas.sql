/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     22/02/2016 15:01:18                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ARTICULOS') and o.name = 'FK_ARTICULO_REFERENCE_CATEGORI')
alter table ARTICULOS
   drop constraint FK_ARTICULO_REFERENCE_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASENTAMIENTOS') and o.name = 'FK_ASENTAMI_REFERENCE_MUNICIPI')
alter table ASENTAMIENTOS
   drop constraint FK_ASENTAMI_REFERENCE_MUNICIPI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASENTAMIENTOS') and o.name = 'FK_ASENTAMI_REFERENCE_TIPOS_AS')
alter table ASENTAMIENTOS
   drop constraint FK_ASENTAMI_REFERENCE_TIPOS_AS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GRUPOS_SEGURIDAD_MODULOS') and o.name = 'FK_GRUPOS_S_REFERENCE_GRUPOS_S2')
alter table GRUPOS_SEGURIDAD_MODULOS
   drop constraint FK_GRUPOS_S_REFERENCE_GRUPOS_S2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GRUPOS_SEGURIDAD_MODULOS') and o.name = 'FK_GRUPOS_S_REFERENCE_MODULOS')
alter table GRUPOS_SEGURIDAD_MODULOS
   drop constraint FK_GRUPOS_S_REFERENCE_MODULOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GRUPOS_SEGURIDAD_USUARIOS') and o.name = 'FK_GRUPOS_S_REFERENCE_USUARIOS')
alter table GRUPOS_SEGURIDAD_USUARIOS
   drop constraint FK_GRUPOS_S_REFERENCE_USUARIOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GRUPOS_SEGURIDAD_USUARIOS') and o.name = 'FK_GRUPOS_S_REFERENCE_GRUPOS_S1')
alter table GRUPOS_SEGURIDAD_USUARIOS
   drop constraint FK_GRUPOS_S_REFERENCE_GRUPOS_S1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDIOS_COMUNICACION') and o.name = 'FK_MEDIOS_C_REFERENCE_TIPOS_ME')
alter table MEDIOS_COMUNICACION
   drop constraint FK_MEDIOS_C_REFERENCE_TIPOS_ME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDIOS_COMUNICACION') and o.name = 'FK_MEDIOS_C_REFERENCE_PERSONAS')
alter table MEDIOS_COMUNICACION
   drop constraint FK_MEDIOS_C_REFERENCE_PERSONAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MUNICIPIOS') and o.name = 'FK_MUNICIPI_REFERENCE_ESTADOS')
alter table MUNICIPIOS
   drop constraint FK_MUNICIPI_REFERENCE_ESTADOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERSONAS') and o.name = 'FK_PERSONAS_REFERENCE_ASENTAMI')
alter table PERSONAS
   drop constraint FK_PERSONAS_REFERENCE_ASENTAMI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RUTAS') and o.name = 'FK_RUTAS_REFERENCE_SUCURSAL')
alter table RUTAS
   drop constraint FK_RUTAS_REFERENCE_SUCURSAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARTICULOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index ARTICULOS.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARTICULOS')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index ARTICULOS.INDEX_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ARTICULOS')
            and   type = 'U')
   drop table ARTICULOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASENTAMIENTOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index ASENTAMIENTOS.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASENTAMIENTOS')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index ASENTAMIENTOS.INDEX_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASENTAMIENTOS')
            and   type = 'U')
   drop table ASENTAMIENTOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CATEGORIAS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index CATEGORIAS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORIAS')
            and   type = 'U')
   drop table CATEGORIAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ESTADOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index ESTADOS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTADOS')
            and   type = 'U')
   drop table ESTADOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GRUPOS_SEGURIDAD')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index GRUPOS_SEGURIDAD.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPOS_SEGURIDAD')
            and   type = 'U')
   drop table GRUPOS_SEGURIDAD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GRUPOS_SEGURIDAD_MODULOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index GRUPOS_SEGURIDAD_MODULOS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPOS_SEGURIDAD_MODULOS')
            and   type = 'U')
   drop table GRUPOS_SEGURIDAD_MODULOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GRUPOS_SEGURIDAD_USUARIOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index GRUPOS_SEGURIDAD_USUARIOS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPOS_SEGURIDAD_USUARIOS')
            and   type = 'U')
   drop table GRUPOS_SEGURIDAD_USUARIOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MEDIOS_COMUNICACION')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index MEDIOS_COMUNICACION.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDIOS_COMUNICACION')
            and   type = 'U')
   drop table MEDIOS_COMUNICACION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODULOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index MODULOS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODULOS')
            and   type = 'U')
   drop table MODULOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MUNICIPIOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index MUNICIPIOS.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MUNICIPIOS')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index MUNICIPIOS.INDEX_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MUNICIPIOS')
            and   type = 'U')
   drop table MUNICIPIOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PERSONAS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index PERSONAS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERSONAS')
            and   type = 'U')
   drop table PERSONAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RUTAS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index RUTAS.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RUTAS')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index RUTAS.INDEX_2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RUTAS')
            and   name  = 'INDEX_3'
            and   indid > 0
            and   indid < 255)
   drop index RUTAS.INDEX_3
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RUTAS')
            and   type = 'U')
   drop table RUTAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUCURSALES')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index SUCURSALES.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUCURSALES')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index SUCURSALES.INDEX_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUCURSALES')
            and   type = 'U')
   drop table SUCURSALES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOS_ASENTAMIENTOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index TIPOS_ASENTAMIENTOS.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOS_ASENTAMIENTOS')
            and   type = 'U')
   drop table TIPOS_ASENTAMIENTOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOS_MEDIOS_COMUNICACION')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index TIPOS_MEDIOS_COMUNICACION.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOS_MEDIOS_COMUNICACION')
            and   type = 'U')
   drop table TIPOS_MEDIOS_COMUNICACION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIOS')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index USUARIOS.INDEX_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIOS')
            and   name  = 'INDEX_2'
            and   indid > 0
            and   indid < 255)
   drop index USUARIOS.INDEX_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIOS')
            and   type = 'U')
   drop table USUARIOS
go

/*==============================================================*/
/* Table: ARTICULOS                                             */
/*==============================================================*/
create table ARTICULOS (
   ID                   int                  not null,
   CATEGORIA_ID         int                  null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_ARTICULOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on ARTICULOS (
NOMBRE ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on ARTICULOS (
ID ASC
)
go

/*==============================================================*/
/* Table: ASENTAMIENTOS                                         */
/*==============================================================*/
create table ASENTAMIENTOS (
   ID                   int                  not null,
   TIPO_ASENTAMIENTO_ID int                  null,
   MUNICIPIO_ID         int                  null,
   NOMBRE               varchar(50)          null,
   CP                   varchar(5)           null,
   ACTIVO               bit                  null,
   constraint PK_ASENTAMIENTOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on ASENTAMIENTOS (
NOMBRE ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on ASENTAMIENTOS (
CP ASC
)
go

/*==============================================================*/
/* Table: CATEGORIAS                                            */
/*==============================================================*/
create table CATEGORIAS (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_CATEGORIAS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on CATEGORIAS (
ID ASC
)
go

/*==============================================================*/
/* Table: ESTADOS                                               */
/*==============================================================*/
create table ESTADOS (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_ESTADOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on ESTADOS (
ID ASC
)
go

/*==============================================================*/
/* Table: GRUPOS_SEGURIDAD                                      */
/*==============================================================*/
create table GRUPOS_SEGURIDAD (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   FECHA_REG            datetime             null,
   FECHA_MOD            datetime             null,
   constraint PK_GRUPOS_SEGURIDAD primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on GRUPOS_SEGURIDAD (
ID ASC
)
go

/*==============================================================*/
/* Table: GRUPOS_SEGURIDAD_MODULOS                              */
/*==============================================================*/
create table GRUPOS_SEGURIDAD_MODULOS (
   GRUPO_SEGURIDAD_ID   int                  null,
   MODULOS_ID           int                  null,
   FECHA_REG            datetime             null,
   FECHA_MOD            datetime             null,
   constraint AK_KEY_1_2_GRUPOS_S unique (GRUPO_SEGURIDAD_ID, MODULOS_ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on GRUPOS_SEGURIDAD_MODULOS (
GRUPO_SEGURIDAD_ID ASC,
MODULOS_ID ASC
)
go

/*==============================================================*/
/* Table: GRUPOS_SEGURIDAD_USUARIOS                             */
/*==============================================================*/
create table GRUPOS_SEGURIDAD_USUARIOS (
   GRUPO_SEGURIDAD_ID   int                  null,
   USUARIO_ID           int                  null,
   FECHA_REG            datetime             null,
   FECHA_MOD            datetime             null,
   constraint AK_KEY_1_1_GRUPOS_S unique (GRUPO_SEGURIDAD_ID, USUARIO_ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on GRUPOS_SEGURIDAD_USUARIOS (
GRUPO_SEGURIDAD_ID ASC,
USUARIO_ID ASC
)
go

/*==============================================================*/
/* Table: MEDIOS_COMUNICACION                                   */
/*==============================================================*/
create table MEDIOS_COMUNICACION (
   ID                   int                  not null,
   TIPO_MEDIO_COMUNICACION_ID int                  null,
   PERSONA_ID           int                  null,
   VALOR                varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_MEDIOS_COMUNICACION primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on MEDIOS_COMUNICACION (
ID ASC
)
go

/*==============================================================*/
/* Table: MODULOS                                               */
/*==============================================================*/
create table MODULOS (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   FECHA_REG            datetime             null,
   FECHA_MOD            datetime             null,
   constraint PK_MODULOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on MODULOS (
ID ASC
)
go

/*==============================================================*/
/* Table: MUNICIPIOS                                            */
/*==============================================================*/
create table MUNICIPIOS (
   ID                   int                  not null,
   ESTADO_ID            int                  null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_MUNICIPIOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on MUNICIPIOS (
ESTADO_ID ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on MUNICIPIOS (
ID ASC
)
go

/*==============================================================*/
/* Table: PERSONAS                                              */
/*==============================================================*/
create table PERSONAS (
   ID                   int                  not null,
   ASENTAMIENTO_ID      int                  null,
   NOMBRE               varchar(50)          null,
   AP_PATERNO           varchar(50)          null,
   AP_MATERNO           varchar(50)          null,
   FECHA_NACIMIENTO     date                 null,
   SEXO                 varchar(1)           null,
   constraint PK_PERSONAS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on PERSONAS (
NOMBRE ASC,
AP_PATERNO ASC,
AP_MATERNO ASC
)
go

/*==============================================================*/
/* Table: RUTAS                                                 */
/*==============================================================*/
create table RUTAS (
   ID                   int                  not null,
   SUCURSAL_ID          int                  null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_RUTAS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
create index INDEX_3 on RUTAS (
NOMBRE ASC
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on RUTAS (
SUCURSAL_ID ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on RUTAS (
ID ASC
)
go

/*==============================================================*/
/* Table: SUCURSALES                                            */
/*==============================================================*/
create table SUCURSALES (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_SUCURSALES primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on SUCURSALES (
NOMBRE ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on SUCURSALES (
ID ASC
)
go

/*==============================================================*/
/* Table: TIPOS_ASENTAMIENTOS                                   */
/*==============================================================*/
create table TIPOS_ASENTAMIENTOS (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_TIPOS_ASENTAMIENTOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on TIPOS_ASENTAMIENTOS (
ID ASC
)
go

/*==============================================================*/
/* Table: TIPOS_MEDIOS_COMUNICACION                             */
/*==============================================================*/
create table TIPOS_MEDIOS_COMUNICACION (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   ACTIVO               bit                  null,
   constraint PK_TIPOS_MEDIOS_COMUNICACION primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on TIPOS_MEDIOS_COMUNICACION (
ID ASC
)
go

/*==============================================================*/
/* Table: USUARIOS                                              */
/*==============================================================*/
create table USUARIOS (
   ID                   int                  not null,
   NOMBRE               varchar(50)          null,
   LOGIN                varchar(15)          null,
   PASSWORD             varchar(15)          null,
   ACTIVO               bit                  null,
   FECHA_REG            datetime             null,
   FECHA_MOD            datetime             null,
   constraint PK_USUARIOS primary key (ID)
)
go

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
create index INDEX_2 on USUARIOS (
LOGIN ASC,
PASSWORD ASC
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on USUARIOS (
ID ASC
)
go

alter table ARTICULOS
   add constraint FK_ARTICULO_REFERENCE_CATEGORI foreign key (CATEGORIA_ID)
      references CATEGORIAS (ID)
go

alter table ASENTAMIENTOS
   add constraint FK_ASENTAMI_REFERENCE_MUNICIPI foreign key (MUNICIPIO_ID)
      references MUNICIPIOS (ID)
go

alter table ASENTAMIENTOS
   add constraint FK_ASENTAMI_REFERENCE_TIPOS_AS foreign key (TIPO_ASENTAMIENTO_ID)
      references TIPOS_ASENTAMIENTOS (ID)
go

alter table GRUPOS_SEGURIDAD_MODULOS
   add constraint FK_GRUPOS_S_REFERENCE_GRUPOS_S2 foreign key (GRUPO_SEGURIDAD_ID)
      references GRUPOS_SEGURIDAD (ID)
go

alter table GRUPOS_SEGURIDAD_MODULOS
   add constraint FK_GRUPOS_S_REFERENCE_MODULOS foreign key (MODULOS_ID)
      references MODULOS (ID)
go

alter table GRUPOS_SEGURIDAD_USUARIOS
   add constraint FK_GRUPOS_S_REFERENCE_USUARIOS foreign key (USUARIO_ID)
      references USUARIOS (ID)
go

alter table GRUPOS_SEGURIDAD_USUARIOS
   add constraint FK_GRUPOS_S_REFERENCE_GRUPOS_S1 foreign key (GRUPO_SEGURIDAD_ID)
      references GRUPOS_SEGURIDAD (ID)
go

alter table MEDIOS_COMUNICACION
   add constraint FK_MEDIOS_C_REFERENCE_TIPOS_ME foreign key (TIPO_MEDIO_COMUNICACION_ID)
      references TIPOS_MEDIOS_COMUNICACION (ID)
go

alter table MEDIOS_COMUNICACION
   add constraint FK_MEDIOS_C_REFERENCE_PERSONAS foreign key (PERSONA_ID)
      references PERSONAS (ID)
go

alter table MUNICIPIOS
   add constraint FK_MUNICIPI_REFERENCE_ESTADOS foreign key (ESTADO_ID)
      references ESTADOS (ID)
go

alter table PERSONAS
   add constraint FK_PERSONAS_REFERENCE_ASENTAMI foreign key (ASENTAMIENTO_ID)
      references ASENTAMIENTOS (ID)
go

alter table RUTAS
   add constraint FK_RUTAS_REFERENCE_SUCURSAL foreign key (SUCURSAL_ID)
      references SUCURSALES (ID)
go

