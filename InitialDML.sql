create table consumerUser
(
	USERID         int identity(1,1) not null,
	FIRSTNAME      varchar(26)       not null,
	LASTNAME       varchar(26)       not null,
	USERNAME       varchar(26)       not null,
	EMAIL          varchar(52)       not null,
	PASSWORD       varchar(60)       not null,
	DOB            date              not null,

	constraint PK_CONSUMER primary key nonclustered(USERID)
)

create table merchantUser
(
	MERCHANTID     int identity(1,1) not null,
	FIRSTNAME      varchar(26)       not null,
	LASTNAME       varchar(26)       not null,
	USERNAME       varchar(26)       not null,
	EMAIL          varchar(52)       not null,
	PASSWORD       varchar(60)       not null,
	DOB            date              not null,
	
	constraint PK_MERCHANT primary key nonclustered(MERCHANTID)
)

create table adminUser
(
	ADMINID        int identity(1,1) not null,
	FIRSTNAME      varchar(26)       not null,
	LASTNAME       varchar(26)       not null,
	USERNAME       varchar(26)       not null,
	EMAIL          varchar(52)       not null,
	PASSWORD       varchar(60)       not null,
	DOB            date              not null,
	
	constraint PK_ADMIN primary key nonclustered(ADMINID)
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

create table storesProducts
(
	STOREID			int identity(1,1)  not null,
	PRODUCTID		int identity(1,1)  not null,

	constraint PK_STOREPRODUCT primary key(STOREID,PRODUCTID)
)
