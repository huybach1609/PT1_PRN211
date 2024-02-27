create table Member(
	MemberId int primary key not null,
	Email varchar(100) not null,
	CompanyName varchar(40) not null,
	City varchar(15) not null,
	Country varchar(15) not null, 
	Password varchar(30) not null
)

go

create table [Order](
	OrderId int primary key not null,
	MemberId int not null,
	OrderDate datetime not null,
	RequiredDate datetime,
	ShippedDate datetime,
	Freigth money
	FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
)
go
create table Product(
	ProductId int primary key not null,
	CatgoryId int not null,
	ProductName varchar(40) not null,
	[Weight] varchar(40) not null,
	UnitPrice money not null,
	UnitInStock int not null
)
create table OrderDetail(
	OrderId int  not null,
	ProductId int  not null,
	UnitPrice money  not null,
	Quantity int  not null,
	Discount float  not null,
	FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
	FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
)