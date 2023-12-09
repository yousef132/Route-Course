use ITI

--1.Insert your personal data to the student table as a new Student in department number 30.
insert into Student
values(3333,'Usif','Saad','benisuif',20,30,1)


--2.Insert Instructor with personal data of your friend as new Instructor in department number 30,
--Salary= 4000, but don’t enter any value for bonus
insert into Instructor
values(16,'Ammar','cs',4000,30)

--3.Upgrade Instructor salary by 20 % of its last value.
update Instructor
set Salary +=  (Salary*0.2);