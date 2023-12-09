use MyCompany


--1.Display all the employees Data.
select * from Employee

--2.Display the employee First name, last name, Salary and Department number.
select Fname , Lname , Salary, Dno
from Employee 

--3.Display all the projects names, locations and the department which is responsible for it.
select Pname , Plocation ,dnum
from Project

--or

select Pname , Plocation ,d.*
from Project p left outer join Departments d 
on p.Dnum=d.Dnum


--4.If you know that the company policy is to pay an annual commission for each employee with specific percent equals 10% of his/her annual salary .
--Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
select [Full Name ]=Fname + ' ' + Lname , [ANNUAL COMM]= (Salary*12)*0.1 ,Salary
from Employee

--5.Display the employees Id, name who earns more than 1000 LE monthly.
-- No column called employees Id
select SSN , [Name]= Fname + ' ' + Lname 
from Employee
where Salary>1000

--6.Display the employees Id, name who earns more than 10000 LE annually.
select SSN , [Full Name]= Fname + ' ' + Lname 
from Employee
where Salary*12>10000

--7.Display the names and salaries of the female employees 
select [Full Name]= Fname + ' ' + Lname  , Salary
from Employee
where Sex='F'
--8.Display each department id, name which is managed by a manager with id equals 968574
select Dnum , Dname
from Departments
where MGRSSN=968574
--9.Display the ids, names and locations of  the projects which are controlled with department 10.
select Pnumber , Pname , Plocation
from Project
where Dnum=10
