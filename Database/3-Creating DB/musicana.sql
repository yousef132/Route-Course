
create table instrument
(
name varchar(20) primary key,
keyy varchar(20) not null,
)

create table musician
(
id int primary key identity(1,1),
name varchar(20) not null,
phnumber varchar(20) not null,
city varchar(20),
street varchar(20) 
)
create table Musician_instrument
(
 mid int references musician(id),
 iname varchar(20) references instrument(name)
 primary key(mid,iname)
)

create table songs
(
title varchar(20) primary key,
author varchar(20) not null
)
create table Musician_song
(
 mid int references musician(id),
 stitle varchar(20) references songs(title)
 primary key(mid,stitle)
)
create table albums
(
id int primary key identity(1,1),
title varchar(20) not null,
date date not null,
mid int references musician(id)

)
create table Album_Song
(
aid int references albums(id),
stitle varchar(20) references songs(title),
primary key(stitle)
)

