use iti

--1.Retrieve a number of students who have a value in their age. 
select count(*) [students have age]
from Student
where St_Age is not null

--2.Display number of courses for each topic name 
select t.Top_Name , COUNT(c.Crs_Id) [Number of courses]
from Topic t join Course c
on t.Top_Id = c.Top_Id
group by t.Top_Name

--3.Select Student first name and the data of his supervisor 

select student.St_Fname , supervisor.*
from Student student join Student supervisor
on student.St_super = supervisor.St_Id

--4.Display student with the following Format (use isNull function)

select isnull(s.St_Id, '') [Student ID] ,
isnull(s.St_Fname, '') + ' ' + isnull(s.St_Lname,'')[Student Full Name],
isnull(d.Dept_Name, '')[Department name]
from Student s join Department d 
on s.Dept_Id = d.Dept_Id

--5.Select instructor name and his salary but if there is no salary display value ‘0000’ . “use one of Null Function” 

select Ins_Name ,ISNULL(Salary,'0000')
from Instructor

--6.Select Supervisor first name and the count of students who supervises on them

select supervisor.St_Fname  , count(student.St_Id) [Number of students]
from Student student join Student supervisor
on student.St_super = supervisor.St_Id
group by supervisor.St_Fname


--7.Display max and min salary for instructors

select Ins_Id , Ins_Name, max(Salary) [max salary] , min(salary) [min salary]
from Instructor
group by Ins_Id ,Ins_Name

--8.Select Average Salary for instructors 
select Ins_Id , ISNULL(avg(Salary),0) [avg salary] 
from Instructor
group by Ins_Id 

