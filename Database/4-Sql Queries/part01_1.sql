use airline
insert into airline
values('cairo airline','cairo','person1'),
('america airline','america','person2'),
('mosco airline','mosco','person2')

insert into airlinephone
values(1,01289060),
(2,0125896477)

insert into employee
values ('ali' , 1 , 'm' , 2017 , 2 , 15,'cairo' , 'main pilot'),
('mona' , 1 , 'f' , 2017 , 2 , 15,'cairo' , 'ass pilot')

 insert into employee_qualificatinos
 values(2,'q1'),
 (2,'q2'),
 (3,'q1')

 insert into transactions
 values(2,2000,'d1' , '2003-7-30'),
 (3,7700,'d2' , '2013-8-30')

 insert into aircraft
 values('m1' , 2000 , 2),
 ('m2' , 3000 , 3)


 insert into crew 
 values('ali',2,'mona',1,2),
 ('omar',3,'khalid',2,3)

 insert into route
 values('c1' ,18000.6 , 'o1','d1'),
 ('c2' ,10000.1 , 'o2','d2')

 insert into aircraft_route
 values(2,1,1000,5566,12,3000),
 (3,2,2000,5066,1,1000)

----------------------------------------

GO
use ITI
-- Insert into Student
insert into Student
values('omar','Mohamed','cairo',22,70,NULL),
('ahmed','amr','benisuef',28,40,NULL)

-- Insert into Department
insert into Department
values(80,'C#','Web Development','Beni Suef',NULL,getdate()),
(90,'C+++++','back end','Menia',NULL,2/2/2009)

-- Insert into Innstructor
insert into Instructor
values(166,'Yousef','M',8632.0000,70),
(177,'mohamed','M',8696.0000,70)

-- Insert into Course
insert into Course
values(1700,'c++',40,5),(1400,'c#',60,3)

-- Insert into Topic
insert into Topic
values(7,'math'),(8,'programming')

-- Insert into Ins_Course
insert into Ins_Course
values(2,100,'Baaaaad'),(6,700,'good')

-- Insert into Stud_Course
insert into Stud_Course
values(400,62,80),(300,55,90)



----

GO

use musicana


--Insert into Musician
insert into Musician
values(7,'mohamed',11,'sarqia','Saido'),
(8,'amr',88,'Cairo','Talat Harb')

--Insert into Album
insert into Album
values(25,'kdhjfasd',getdate()),(30,'fasf',getdate())

--Insert into Instrument
insert into Instrument
values('gadsg',28),('asdl',30)

--Insert into Song
insert into Song
values('Ass','sadfg'),('adf','adsf')

--Insert into Album_Song
insert Album_Song
values('sadf',5),('adsf',10)

--Insert into Mus_Song
insert into Mus_Song
values('adsgfdsag',5),('dasg',7)

--Insert into Mus_Instrument
insert into Mus_Instrument
values(2,'ppp'),(4,'gsadg')



