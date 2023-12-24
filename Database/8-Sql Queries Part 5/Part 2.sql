--1.Create a stored procedure to show the number
--of students per department.[use ITI DB] 

create proc sp_DepartmentStudent
as
select d.Dept_Id , count(St_Id) [Number of Students]
from Department d join Student s 
on d.Dept_Id = s.Dept_Id
group by d.Dept_Id



--2.Create a stored procedure that will check for the Number of employees in
--the project 100 if they are more than 3 print message to
--the user “'The number of employees in the project 100 is 3 or more'” if
--they are less display a message to the user “'The following employees work for
--the project 100'” in addition to the first name and last name of each one.
--[MyCompany DB] 

create proc sp_checkCompanyEmployees
as

declare @Noe int

select @Noe= count(w.ESSn)
from 
Project p join Works_for w on p.Pnumber = w.Pno and pno=100
group by p.Pnumber

	if @Noe > 3
	print 'The number of employees in the project 100 is 3 or more'
	else
	begin
		select 'The following employees work for the project 100'

		select e.Fname , e.Lname
		from Works_for w join Employee e 
		on w.ESSn  = e.SSN and w.Pno = 100

	end


	
--3.Create a stored procedure that will be used in case an old employee has 
--left the project and a new one becomes his replacement. The procedure should
--take 3 parameters (old Emp. number, new Emp. number and the project number) 
--and it will be used to update works_on table. [MyCompany DB]

create proc sp_UpdateProjectEmployee (@oldempNum int , @newempnum int,@Pno int)
as

update Works_for 
set ESSn = @newempnum
where ESSn = @oldempNum and Pno = @Pno




