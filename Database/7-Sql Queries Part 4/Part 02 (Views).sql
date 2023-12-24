--1.Create a view that displays the student's full name,
--course name if the student has a grade more than 50.

create view studentcoursewithgrademorethan50
as
select [Full Name]= CONCAT(s.St_Fname ,' ',s.St_Lname) , c.Crs_Name 
from Student s join Stud_Course sc on s.St_Id = sc.St_Id and sc.Grade > 50
join Course c on sc.Crs_Id = c.Crs_Id


select * from studentcoursewithgrademorethan50


--2.Create an Encrypted view that displays manager names and the topics they teach. 
create view managerstopics
with encryption 
as
select  i.Ins_Name , t.*
from Department d join Instructor i on d.Dept_Manager = i.Ins_Id
join Ins_Course ic on i.Ins_Id = ic.Ins_Id
join Course c on c.Crs_Id = ic.Crs_Id
join Topic t on t.Top_Id = c.Top_Id


--3.Create a view that will display Instructor Name, Department Name for the ‘SD’ or
--‘Java’ Department “use Schema binding” 
--and describe what is the meaning of Schema Binding


create view instructordepartment
with schemabinding
as 

select i.Ins_Name , d.Dept_Name 
from dbo.Instructor i join dbo.Department d
on i.Dept_Id = d.Dept_Id and d.Dept_Name in ('SD', 'Java')



select * from instructordepartment
 
/*Schema Binding is preventing tables used in the view to be deleted or 
make any  modifications that can affect the view , to do this you have to alter view (delete schemabinding )*/

--4.Create a view that will display the project name
--and the number of employees working on it. (Use Company DB)

create view projectemployees(projectname,numberofemployees)
as

select p.Pname , count(w.ESSn) 
from Project p   join Works_for w on w.Pno = p.Pnumber 
group by p.Pname

select * from projectemployees

--use CompanySD32_DB:

--1.Create a view named   “v_clerk” that will display employee Number
--,project Number, the date of hiring of all the jobs of the type 'Clerk'.

create view v_clerk
as 

select e.EmpNo , p.ProjectNo ,w.Enter_Date  
from hr.Employee e join Works_on w on e.EmpNo = w.EmpNo and Job='Clerk'
join hr.Project  p on p.ProjectNo = w.ProjectNo


--2.Create view named  “v_without_budget” that will display all the projects data without budget

create view v_without_budget
as
select ProjectNo , ProjectName
from hr.Project



--3.Create view named  “v_count “ that will display the project name and the Number of jobs in it

create view v_count (ProjectName ,  NumberOfJobs)
as
select  p.ProjectName , COUNT(Job)
from hr.Project p join works_on w on p.ProjectNo = w.ProjectNo
group by p.ProjectName


--4.Create view named ” v_project_p2” that will display the
--emp# s for the project# ‘p2’ . (use the previously created view  “v_clerk”)

create view v_project_p2
as
select EmpNo
from v_clerk
where ProjectNo = 2

--5.modify the view named  “v_without_budget”  to display all DATA in project p1 and p2.

alter view v_without_budget
as
select *
from hr.Project p
where p.ProjectNo in(1,2)


--6.Delete the views  “v_ clerk” and “v_count”

drop view v_clerk
drop view v_count


--7.Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’

create view employeedepartment
as 

select e.EmpNo , e.EmpLname 
from hr.Employee e join Company.Department d  on e.DeptNo = d.DeptNo and d.DeptNo = 2


--8.Display the employee  lastname that contains letter “J” (Use the previous view created in Q#7)

select EmpLname
from employeedepartment
where EmpLname like '%J%' or EmpLname like 'J%'  or EmpLname like '%J'


--9.Create view named “v_dept” that will display the department# and department name

Create view v_dept
as 

select DeptNo , DeptName
from Company.Department

