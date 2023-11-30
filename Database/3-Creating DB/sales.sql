create database Sales

create table sales_offices
(
number int primary key identity(1,1),
location varchar(20) not null,
eid int 
)
create table employees
(
id int primary key identity(1,1),
name varchar(20) not null,
snumber int 
)
alter table sales_offices
add foreign key(eid)
references employees(id)

alter table employees
add foreign key(snumber)
references sales_offices(number)

create table property
(
id int primary key identity(1,1),
address varchar(20) not null,
city varchar(20) ,
state varchar(20) ,
code varchar(20) ,
snumber int references sales_offices(number)
)

create table owners
(
id int primary key identity (1,1),
name varchar(20) not null,
)
create table Owner_Property
(
pid int references property(id),
oid int references owners(id),
Precent float not null,
primary key(pid,oid)
)