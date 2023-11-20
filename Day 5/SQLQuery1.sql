create database shoppingDB

use shoppingDB

create table productsList
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into productsList values(101,'Pepsi','Çold-Drink',80,1)
insert into productsList values(102,'Jeep Compass','SUV',80,1)
insert into productsList values(103,'Fanta','Çold-Drink',80,1)
insert into productsList values(104,'Samsung TV','Electronics',80,1)
insert into productsList values(105,'IPhone','Phone',80,0)
insert into productsList values(106,'Sandwitch','Snaks',80,1)
insert into productsList values(107,'Fossil Q','Watch',80,0)


select * from productsList


create table Customers
(
	cId int primary key,
	cName varchar(20),
	cType varchar(20),
	cWalletBalance int,
	cIsActive bit
)

insert into Customers values(501,'Nikhil','Regular',2000,1)
insert into Customers values(502,'Preeti','Regular',3000,1)
insert into Customers values(503,'Yash','Defaulted',4000,1)
insert into Customers values(504,'Kriti','Regular',5000,1)
insert into Customers values(505,'Sunny','InActive',12000,0)











