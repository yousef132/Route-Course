create table Department
(
DeptNo  int primary key ,
DeptName varchar(20) ,
Location varchar(20) 
)

create table Employee
(
EmpNo   int primary key ,
EmpFname varchar(20) not null,
EmpLname varchar(20) not null,
DeptNo int foreign key references Department (DeptNo),
salary money unique 
)

insert into Department 
values(1,'Research','NY'),
(2,'Accounting','DS'),
(3,'Marketing','KW')

insert into Employee
values (25348,'Mathew','Smith',3,2500),
(10102,'Ann','Jones',3,3000)

insert into Project
values (1,'Apollo',	120000),
(2,'Gemini',95000)


insert into Works_on
values (25348,2,'Clerk','2007.2.15'),
(10102,1,'Analyst','2006.10.1')



--1-Add new employee with EmpNo =11111 In the works_on table [what will happen]
--  error : because there is no employee with empno = 11111 in the employee table 

--2-Change the employee number 10102  to 11111  in the works on table [what will happen]
-- error : because there is no employee with empno = 11111 in the employee table 

--3-Modify the employee number 10102 in the employee table to 22222. [what will happen]
-- Error : cant't be updated because this PK is a foreign key in works_on table 

--4-Delete the employee with id 10102
-- error : cant't be deleted because this PK (parent table) is a foreign key in works_on (child table) table 


--1-Add  TelephoneNumber column to the employee table[programmatically]
alter table employee 
add TelephoneNumber varchar(20) 

--2-drop this column[programmatically]
alter table employee
drop column TelephoneNumber

--2.	Create the following schema and transfer the following tables to it 
--a.	Company Schema 
--	i.	Department table 
--	ii.	Project table 
create schema Company

alter schema company 
transfer department

alter schema company 
transfer Project 
--b.	Human Resource Schema
--	i.	  Employee table 
create schema HumanResource 

alter schema HumanResource 
transfer Employee 

--3.Increase the budget of the project where the manager number is 10102 by 10%.

update Company.Project 
set budget  = budget*1.1 
where ProjectNo in(
	SELECT ProjectNo
    FROM works_on
    WHERE empno = 10102

)

--4.Change the name of the department for which the employee named James works.
--The new department name is Sales

update Company.Department
set DeptName = 'Sales'
where DeptNo in (select DeptNo from HumanResource.Employee where EmpFname = 'James')

--5.Change the enter date for the projects for those employees who work in project p1 
--and belong to department ‘Sales’. The new date is 12.12.2007.


update Works_on
set Enter_Date = '2007.12.12'
where ProjectNo = 1 and EmpNo in (
select EmpNo from 
HumanResource.Employee e join Company.Department d on e.DeptNo = d.DeptNo and DeptName = 'Sales'
)


--6.Delete the information in the works_on table for all employees 
--who work for the department located in KW.

delete from Works_on
where EmpNo in (
select EmpNo from 
HumanResource.Employee e join company.Department d on e.DeptNo = d.DeptNo and Location = 'KW'

)

/*2.Create an Audit table with the following structure 
ProjectNo	UserName 	ModifiedDate 	Budget_Old 	Budget_New 
p2	Dbo	2008-01-31	95000	200000
       This table will be used to audit the update trials on the Budget              
         column (Project table, Company DB)
If a user updated the budget column then the project number, username that made that update,  the date of the modification and the value of the old and the new budget will be inserted into the Audit table
(Note: This process will take place only if the user updated the budget column)*/



create table audittable
(
projectno int ,
username varchar(200),
modifieddate date ,
budget_old int ,
budget_new int 
)


create trigger onupdatebudget
on HR.project 
after update 
as 
if(update(budget))
begin 
insert into audittable 
select ProjectNo , SUSER_NAME() , GETDATE() , Budget ,
(select  budget from inserted) as newbudget
from deleted
end












