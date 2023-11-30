create table student
(
id int primary key identity (1,1),
address varchar(20) not null,
fname varchar(20) not null,
lname varchar(20) ,
age tinyint not null,
did int  
)
create table course
(
id int primary key identity (1,1),
name varchar(20) not null,
duration int not null,
description varchar(20) ,
tid int ,
)

create table student_course
(
sid int references student(id),
cid int references course(id),
grade int not null,
primary key (sid,cid)
)

create table topic
(
id int primary key identity(1,1),
name varchar(20) not null,
)
alter table course
add foreign key (tid) references topic(id)

create table Departement
(
id int primary key identity (1,1),
name varchar(20) not null,
ins_id int ,
hiring_date date not null,
)
alter table student
add foreign key (did) references departement (id)

create table instructor
(
id int primary key identity (1,1),
name varchar(20) not null,
bonus money ,
address varchar(20) not null,
salary money not null,
hour_rate int ,
dept_id int 
)

alter table instructor
add foreign key (dept_id)references departement(id)

alter table departement
add foreign key (ins_id) references instructor (id)

create table course_instructor
(
cid int references course (id) ,
ins_id int references instructor (id) ,
Evaluation int,
primary key(cid,ins_id)
)