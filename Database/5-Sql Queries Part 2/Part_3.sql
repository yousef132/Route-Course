--1.Retrieve the names of all employees in department 10 
--who work more than or equal 10 hours per week
--on the "AL Rabwah" project.

select e.Fname+' ' + e.Lname [full name]
from Employee e join Works_for w on e.SSN=w.ESSn and w.Hours>=10 and e.Dno=10
join Project p on w.Pno = p.Pnumber and p.Pname='AL Rabwah'


--2.Find the names of the employees who were directly
--supervised by Kamel Mohamed.

select e.Fname , e.Lname [full name]
from Employee e join Employee s
on e.Superssn = s.SSN
where s.Fname +' '+s.Lname = 'Kamel Mohamed' 

--3.Display All Data of the managers
select e.*
from Employee e join Departments d 
on e.SSN = d.MGRSSN

--4.Retrieve the names of all employees and 
--the names of the projects they are working on, 
--sorted by the project name


select e.SSN,e.Fname , e.Lname , p.Pname 
from Employee e  join Works_for w on e.SSN=w.ESSn 
 join Project p on w.Pno = p.Pnumber 
order by  p.Pname 


--5.For each project located in Cairo City , 
--find the project number, the controlling department name ,
--the department manager last name ,address and birthdate.
select p.Pnumber , d.Dname , e.Lname , e.Address , e.Bdate
from Employee e inner join Departments d on e.SSN = d.MGRSSN
inner join Project p on p.Dnum=d.Dnum and p.City='Cairo'


--6.Display All Employees data and the data of their dependents
--even if they have no dependents.

select *
from Employee e left outer join Dependent d
on e.SSN = d.ESSN