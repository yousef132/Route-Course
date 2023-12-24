--1.Create a view “V1” that displays student
--data for students who live in Alex or Cairo. 

create view v1 
as 
select * from Student
where St_Address in ('Alex','Cairo')
with check option



--1.Create view named “v_dept” that will display the department# and department name

create view v_dept 
as 
select Company.Department.DeptNo , Company.Department.DeptName
from Company.Department

--2.using the previous view try enter new department data where
--dept# is ’d4’ and dept name is ‘Development’

insert into v_dept(DeptNo,DeptName)
values(4,'Development')


--3.Create view name “v_2006_check” that will display employee Number,
--the project Number where he works and the date of joining the project
--which must be from the first of January and the last of December 2006.
--this view will be used to insert data so make sure that
--the coming new data must match the condition

create view v_2006_check
as 

select e.EmpNo , p.ProjectNo , w.Enter_Date
from hr.Employee e join Works_on w on e.DeptNo = w.EmpNo
join hr.Project p on p.ProjectNo = w.ProjectNo
where  Enter_Date BETWEEN '2006-01-01' AND  '2006-12-31'
with check option

