if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('referencias') and o.name = 'FK_REFERENC_REFERENCE_ASENTAMI')
alter table referencias
   drop constraint FK_REFERENC_REFERENCE_ASENTAMI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('referencias') and o.name = 'FK_REFERENC_REFERENCE_PERSONAS')
alter table referencias
   drop constraint FK_REFERENC_REFERENCE_PERSONAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('referencias')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index referencias.index_1
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('referencias')
            and   name  = 'index_2'
            and   indid > 0
            and   indid < 255)
   drop index referencias.index_2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('referencias')
            and   type = 'U')
   drop table referencias
go

/*==============================================================*/
/* Table: referencias                                           */
/*==============================================================*/
create table referencias (
   id                   int                  not null,
   persona_id           int                  null,
   nombre_completo      varchar(100)         null,
   asentamiento_id      int                  null,
   calle                varchar(100)         null,
   numero_interior      varchar(50)          null,
   numero_exterior      varchar(50)          null,
   telefono             varchar(50)          null,
   anios_conocerlo      int                  null,
   parentesto           varchar(30)          null,
   fecha_registro       datetime             null,
   fecha_modificacion   datetime             null,
   activo               bit                  null,
   constraint PK_REFERENCIAS primary key (id)
)
go

/*==============================================================*/
/* Index: index_2                                               */
/*==============================================================*/
create index index_2 on referencias (
persona_id ASC
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on referencias (
id ASC
)
go

alter table referencias
   add constraint FK_REFERENC_REFERENCE_ASENTAMI foreign key (asentamiento_id)
      references asentamientos (id)
go

alter table referencias
   add constraint FK_REFERENC_REFERENCE_PERSONAS foreign key (persona_id)
      references personas (id)
go
