if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('personas') and o.name = 'FK_PERSONAS_REFERENCE_ESTADOS_')
alter table personas
   drop constraint FK_PERSONAS_REFERENCE_ESTADOS_
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('estados_civiles')
            and   name  = 'index_1'
            and   indid > 0
            and   indid < 255)
   drop index estados_civiles.index_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('estados_civiles')
            and   type = 'U')
   drop table estados_civiles
go

/*==============================================================*/
/* Table: estados_civiles                                       */
/*==============================================================*/
create table estados_civiles (
   id                   int                  not null,
   nombre               varchar(30)          null,
   activo               bit                  null,
   constraint PK_ESTADOS_CIVILES primary key (id)
)
go

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on estados_civiles (
id ASC
)
go
