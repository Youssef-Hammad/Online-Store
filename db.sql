/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     08-Nov-19 9:22:18 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('APPROVEDPRODUCTS') and o.name = 'FK_APPROVED_REFERENCE_BRAND')
alter table APPROVEDPRODUCTS
   drop constraint FK_APPROVED_REFERENCE_BRAND
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PENDINGSTORES') and o.name = 'FK_PENDINGS_REFERENCE_USER')
alter table PENDINGSTORES
   drop constraint FK_PENDINGS_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCTSTOCK') and o.name = 'FK_PRODUCTS_REFERENCE_STORES')
alter table PRODUCTSTOCK
   drop constraint FK_PRODUCTS_REFERENCE_STORES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCTSTOCK') and o.name = 'FK_PRODUCTS_REFERENCE_APPROVED')
alter table PRODUCTSTOCK
   drop constraint FK_PRODUCTS_REFERENCE_APPROVED
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PURCHASEHISTORY') and o.name = 'FK_PURCHASE_REFERENCE_APPROVED')
alter table PURCHASEHISTORY
   drop constraint FK_PURCHASE_REFERENCE_APPROVED
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PURCHASEHISTORY') and o.name = 'FK_PURCHASE_REFERENCE_USER')
alter table PURCHASEHISTORY
   drop constraint FK_PURCHASE_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PURCHASEHISTORY') and o.name = 'FK_PURCHASE_REFERENCE_STORES')
alter table PURCHASEHISTORY
   drop constraint FK_PURCHASE_REFERENCE_STORES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STORES') and o.name = 'FK_STORES_REFERENCE_USER')
alter table STORES
   drop constraint FK_STORES_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STORESTATISTICS') and o.name = 'FK_STORESTA_REFERENCE_STORES')
alter table STORESTATISTICS
   drop constraint FK_STORESTA_REFERENCE_STORES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('APPROVEDPRODUCTS')
            and   type = 'U')
   drop table APPROVEDPRODUCTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRAND')
            and   type = 'U')
   drop table BRAND
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PENDINGSTORES')
            and   type = 'U')
   drop table PENDINGSTORES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTSTOCK')
            and   type = 'U')
   drop table PRODUCTSTOCK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PURCHASEHISTORY')
            and   type = 'U')
   drop table PURCHASEHISTORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STORES')
            and   type = 'U')
   drop table STORES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STORESTATISTICS')
            and   type = 'U')
   drop table STORESTATISTICS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

if exists (select 1
			from sysobjects
			where id = object_id('COLLABS')
			and	  type = 'U')
	drop table COLLABS

/*==============================================================*/
/* Table: APPROVEDPRODUCTS                                      */
/*==============================================================*/
create table APPROVEDPRODUCTS (
   PID                  int   identity(1,1)  not null,
   BRANDNAME            varchar(30)          null,
   PRODUCTNAME          varchar(30)          not null,
   PRODUCTPRICE         float                not null,
   PRODUCTCAT           varchar(30)          not null,
   constraint PK_APPROVEDPRODUCTS primary key (PID)
)
go

/*==============================================================*/
/* Table: BRAND                                                 */
/*==============================================================*/
create table BRAND (
   BRANDNAME            varchar(30)          not null,
   BRANDCAT             varchar(30)          not null,
   constraint PK_BRAND primary key (BRANDNAME)
)
go

/*==============================================================*/
/* Table: PENDINGSTORES                                         */
/*==============================================================*/
create table PENDINGSTORES (
   STORENAME            varchar(30)          not null,
   OWNERNAME            varchar(30)          not null,
   STORELOC             varchar(30)          not null,
   STYPE                tinyint              not null,
   constraint PK_PENDINGSTORES primary key (STORENAME, STORELOC)
)
go

/*==============================================================*/
/* Table: PRODUCTSTOCK                                          */
/*==============================================================*/
create table PRODUCTSTOCK (
   [SID]                int                  not null,
   PID                  int                  not null,
   QTY                  int                  not null default 0,
   constraint PK_PRODUCTSTOCK primary key (SID, PID)
)
go

/*==============================================================*/
/* Table: PURCHASEHISTORY                                       */
/*==============================================================*/
create table PURCHASEHISTORY (
   HID                  int   identity(1,1)  not null,
   USERNAME             varchar(30)          not null,
   PID                  int                  not null,
   [SID]                int                  not null,
   QTY                  int                  not null,
   COST                 float                not null,
   constraint PK_PURCHASEHISTORY primary key (HID)
)
go

/*==============================================================*/
/* Table: STORES                                                */
/*==============================================================*/
create table STORES (
   [SID]                int   identity(1,1)  not null,
   STORENAME            varchar(30)          not null,
   STORELOC             varchar(30)          not null,
   OWNERUSR             varchar(30)          not null,
   STYPE                tinyint              not null,
   constraint PK_STORES primary key (SID)
)
go

/*==============================================================*/
/* Table: STORESTATISTICS                                       */
/*==============================================================*/
create table STORESTATISTICS (
   [SID]                  int                  not null,
   PRODUCTVIEWS         int                  not null default 0,
   STOREREVENUE         float                not null default 0,
   constraint PK_STORESTATISTICS primary key (SID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USERNAME             varchar(30)          not null,
   EMAIL                varchar(60)          not null,
   [PASSWORD]           varchar(30)          not null,
   UTYPE                tinyint              not null,
   constraint PK_USER primary key (USERNAME)
)
go


create table COLLABS (
	OUSERNAME		varchar(30)			not null,
	CUSERNAME		varchar(30)			not null,
	primary key (OUSERNAME, CUSERNAME)
)


create table STOREACTIONS (
	AID				int	identity(1,1)	not null,
	[SID]			int					not null,
	PID				int					not null,
	[STATEMENT]		varchar(60)			not null,
	primary key (AID)
)

alter table STOREACTIONS
	add constraint FK_STOREACTIONS_REFERENCE_STORES foreign key ([SID])
		references STORES ([SID])

alter table STOREACTIONS
    add constraint FK_STOREACTIONS_REFERENCE_APPROVEDPRODUCT foreign key (PID)
		references APPROVEDPRODUCTS (PID)

alter table STOREACTIONS
add QTY int null;


alter table APPROVEDPRODUCTS
   add constraint FK_APPROVED_REFERENCE_BRAND foreign key (BRANDNAME)
      references BRAND (BRANDNAME)
go

alter table PENDINGSTORES
   add constraint FK_PENDINGS_REFERENCE_USER foreign key (OWNERNAME)
      references "USER" (USERNAME)
go

alter table PRODUCTSTOCK
   add constraint FK_PRODUCTS_REFERENCE_STORES foreign key ([SID])
      references STORES ([SID])
go

alter table PRODUCTSTOCK
   add constraint FK_PRODUCTS_REFERENCE_APPROVED foreign key (PID)
      references APPROVEDPRODUCTS (PID)
go

alter table PURCHASEHISTORY
   add constraint FK_PURCHASE_REFERENCE_APPROVED foreign key (PID)
      references APPROVEDPRODUCTS (PID)
go

alter table PURCHASEHISTORY
   add constraint FK_PURCHASE_REFERENCE_USER foreign key (USERNAME)
      references "USER" (USERNAME)
go

alter table PURCHASEHISTORY
   add constraint FK_PURCHASE_REFERENCE_STORES foreign key ([SID])
      references STORES ([SID])
go

alter table STORES
   add constraint FK_STORES_REFERENCE_USER foreign key (OWNERUSR)
      references "USER" (USERNAME)
go

alter table STORESTATISTICS
   add constraint FK_STORESTA_REFERENCE_STORES foreign key ([SID])
      references STORES ([SID])
go

