use Mycompany

--1.For each project, list the project name and the 
--total hours per week (for all employees) spent on that project.

select p.Pname , sum(w.Hours) [Total hours]
from Project p join Works_for w 
on p.Pnumber =w.Pno
group by p.Pname

--2.For each department, retrieve the department 
--name and the maximum, minimum and average salary of its employees.

select d.Dname , 
MAX(e.Salary)[max salary] , 
min(e.Salary)[min salary] ,
avg(e.Salary)[avg salary]
from Departments d join Employee e
on d.Dnum=e.Dno
group by d.Dname


--3.Retrieve a list of employees and the projects they are
--working on ordered by department and within each department,
--ordered alphabetically by last name, first name.

select e.*,p.*
from Employee e join Works_for w on e.SSN=w.ESSn
join Project p on p.Pnumber = w.Pno
order by e.Dno ,e.Lname, e.Fname


--4.Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%

update e
set e.Salary+= (e.salary*0.3)
from Employee e join Works_for w on e.SSN=w.ESSn
join Project p on p.Pnumber = w.Pno
where p.Pname='Al Rabwah'

-----DML-----

--In the department table insert a new department called "DEPT IT" ,
--with id 100, employee with SSN = 112233 as 
--a manager for this department. The start date for this manager is '1-11-2006'.
insert into Departments
values('DEPT IT',100,112233,'1-11-2006')


--Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574) 
--moved to be the manager of the new department (id = 100), and they give 
--you(your SSN =102672) her position (Dept. 20 manager) 


--a. First try to update her record in the department table


update Departments
set MGRSSN =968574
where Dnum=100


--b. Update your record to be department 20 manager.

--first insert an employee
insert into Employee
values('yousef','saad',102672,'2033-9-9','cairo','M',2222,36,null);


update Departments
set MGRSSN =102672
where Dnum=20


--c. Update the data of employee number=102660 to
--be in your teamwork (he will be supervised by you) (your SSN =102672)

-- make him in my department  
update Employee
set Dno = 20
where SSN =102660 


-- be his supervisor 
update Employee
set Superssn = 102672
where SSN =102660 


--3. Unfortunately the company ended the contract with  Mr.Kamel Mohamed (SSN=223344)
--so try to delete him from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager,
--supervises any employees or works in any projects and handles these cases).


--considering my id is 102672

--supervise--
update Employee
set Superssn = 102672
where Superssn = 223344


--Dependent--
update Dependent
set ESSN=102672
where ESSN = 223344

--Departement--
update Departments
set MGRSSN = 102672
where MGRSSN = 223344

--Works For--
update Works_for 
set ESSN=102672
where ESSN = 223344

delete from Employee
where SSN =223344