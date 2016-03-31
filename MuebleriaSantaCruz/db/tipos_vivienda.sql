if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('domicilios') and o.name = 'FK_DOMICILI_REFERENCE_TIPOS_VI')
alter table domicilios
   drop constraint FK_DOMICILI_REFERENCE_TIPOS_VI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tipos_viviendas')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index tipos_viviendas.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipos_viviendas')
            and   type = 'U')
   drop table tipos_viviendas
go

/*==============================================================*/
/* Table: tipos_viviendas                                       */
/*==============================================================*/
create table tipos_viviendas (
   id                   int                  not null,
   nombre               varchar(50)          null,
   activo               bit                  null,
   constraint PK_TIPOS_VIVIENDAS primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on tipos_viviendas (
id ASC
)
go