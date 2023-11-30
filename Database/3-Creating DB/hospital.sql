
create table patient
(
id int primary key identity(1,1),
name varchar(20) not null,
DOB date not null,
cid int ,
wid int 
)

create table consultant
(
id int primary key identity(1,1),
name varchar(20) not null,

)
create table examin
(
pid int references patient(id),
cid int references consultant(id),
primary key (pid,cid)
)

alter table patient
add foreign key (cid)
references consultant(id)

create table ward
(
id int primary key identity(1,1),
name varchar(20) not null,
nnumber int ,
)

create table nurse
(
number int primary key identity(1,1),
name varchar(20) not null,
address varchar(20) ,
wid int 

)

alter table ward
add foreign key (nnumber)
references nurse(number)

alter table patient
add foreign key (wid)
references ward(id)

alter table nurse
add foreign key (wid)
references ward(id)


create table drug
(
code int primary key identity(1,1),
dosage varchar(20) not null
)
create table Drug_brande
(
dcode int references drug(code),
brand varchar(20),
primary key(dcode , brand)
)


create table give
(
pid int references patient(id) ,
dcode int references drug(code),
nnumber int references nurse(number),
dosage varchar(20) not null,
date date not null ,
time datetime  not null,

)

