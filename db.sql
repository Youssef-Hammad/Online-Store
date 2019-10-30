drop table [USER]

create table [USER]
(
	USERID         int identity(1,1) not null,
	USERNAME       varchar(26)       not null,
	EMAIL          varchar(52)       not null,
	PASSWORD       varchar(60)       not null,
	TYPE           int               not null,

	constraint PK_CONSUMER primary key nonclustered(USERID)
)

create table merchantStores
(
	STOREID        int identity(1,1) not null,
	MERCHANTNAME   varchar(26)       not null,
	STORENAME      varchar(26)       not null,
	STORELOCATION  varchar(52)       null,

	constraint PK_STORE primary key nonclustered(STOREID)
)

create table products
(
	PRODUCTID      int identity(1,1) not null,
	NAME           varchar(26)       not null,
	PRICE          money             not null,
	CATEGORY       varchar(26)       not null,
	PTYPE          varchar(12)       not null, 
	
	constraint PK_PRODUCT primary key nonclustered(PRODUCTID)
)

create table storeProducts
(
	STORENAME    varchar(30) not null,
	PRODUCTNAME  varchar(30) not null
)