use MyCompany

--1.Display the Department id, name and id and the name of its manager
select d.Dnum , d.Dname ,e.SSN , [Full Name]=e.Fname + ' '+ e.Lname
from Departments d inner join Employee e
on e.SSN = d.MGRSSN

--2.Display the name of the departments and the name of the projects under its control.

select d.Dname , p.Pname from 
Departments d inner join Project p 
on p.Dnum = d.Dnum

--3.Display the full data about all the dependence associated with the name of the employee they depend on .

select d.* , [Full Name]=e.Fname + ' '+e.Lname 
from Dependent d inner join Employee e
on d.ESSN=e.SSN

--4.Display the Id, name and location of the projects in Cairo or Alex city.

select Pnumber , Pname ,Plocation
from Project
where City in('cairo' , 'alex')

--5.Display the Projects full data of the projects with a name starting with "a" letter.
select * 
from Project
where Pname like'a%'

--6.display all the employees in department 30 whose salary from 1000 to 2000 LE monthly

select Employee.* 
from Employee  inner join Departments 
on Dno = Dnum and Dnum=30 and Salary between 1000 and 2000


--7.Retrieve the names of all employees in department 10 who work more 
--than or equal 10 hours per week on the "AL Rabwah" project.


select [full name]= e.Fname + ' '+ e.Lname 
from Employee e inner join Works_for w
on e.SSN = w.ESSn and w.Hours>=10 and e.Dno=10 inner join Project p
on w.Pno = p.Pnumber and p.Pname='AL Rabwah'


--8.Retrieve the names of all employees and the names of the projects
--they are working on, sorted by the project name.
select [full name]= e.Fname + ' '+ e.Lname ,p.Pname
from Employee e inner join Works_for w
on e.SSN = w.ESSn  inner join Project p
on w.Pno = p.Pnumber 
order by p.Pname

--9.For each project located in Cairo City , 
--find the project number, the controlling department name ,
--the department manager last name ,address and birthdate.

select p.Pnumber , d.Dname , e.Lname , e.Address , e.Bdate
from project p inner join Departments d
on p.Dnum = d.Dnum and p.City='Cairo'
inner join Employee e on e.SSN=d.MGRSSN
