
--1.Create a scalar function that takes a date and returns the Month name of that date.

create function getmonthname(@date date)
returns varchar(20)
as 
begin
return (format(@date,'MMMM')) 
end

select dbo.getmonthname('2003-3-1')

--2.Create a multi-statements table-valued function
--that takes 2 integers and returns the values between them.

create function getvaluesbetweentwonumbers(@a int,@b int)
returns @values table(number int)
as
begin

set @a+=1;

	while(@a<@b)
	begin
	insert into @values
	select @a
	set @a+=1;
	end

	return 
end

select * from getvaluesbetweentwonumbers(1,20)


--3. Create a table-valued function that takes Student
--No and returns Department Name with Student full name.

create function getstudentdepartment(@st_id int)
returns table
as
return (
select d.Dept_Name , [Full Name]= CONCAT(s.St_Fname , ' ' ,s.St_Lname)
from Student s join Department d 
on s.Dept_Id = d.Dept_Id
where s.St_Id = @st_id
)

select * from getstudentdepartment(13)


--4.Create a scalar function that takes Student ID and returns a message to user 
--a.If first name and Last name are null then display 'First name & last name are null'
--b.If First name is null then display 'first name is null'
--c.If Last name is null then display 'last name is null'
--d.Else display 'First name & last name are not null'

create function checkname(@st_id int)
returns varchar(50)
as 
begin

declare @fname varchar(20) , @lname varchar(20)
select @fname = St_Fname , @lname = St_Lname
from Student
where St_Id = @st_id
	
	  if @fname is null and @lname is null
	  return 'First name & last name are null' 

	  else if @fname is null
	  return 'first name is null'

	  else if @lname is null
	  return 'last name is null'
	   
	  return 'First name & last name are not null'
	
end


select dbo.checkname(21)


--5.Create a function that takes an integer which represents the format of the Manager
--hiring date and displays department name, Manager Name and hiring date with this format.   


create function mang_dept(@num int)
returns table
as
return
(
     select i.Ins_Name,d.Dept_Name,d.Manager_hiredate
    from Instructor i ,Department d
    where i.Ins_Id=d.Dept_Manager
    and CONVERT(DATE,CONVERT(VARCHAR(50), @num),101)in(d.Manager_hiredate)
        
)

select * from  mang_dept(20231129)


--6.Create multi-statement table-valued function that takes a string
--a.If string='first name' returns student first name
--b.If string='last name' returns student last name 
--c.If string='full name' returns Full Name from student table  
create function getstudentname(@format varchar(30))
returns @table table(name varchar(50))
as
begin
	if @format = 'first name'
	insert into @table
	select ISNULL(St_Fname ,'first name is null')
	from Student

	else if @format = 'last name'
	insert into @table
	select ISNULL(St_Lname ,'last name is null')
	from Student

	else
	insert into @table
	select ISNULL(St_Fname + ' ' + St_Lname ,'full name is null')
	from Student

	return
end


select * from getstudentname('last name')

--7.Create function that takes project number and display all
--employees in this project (Use MyCompany DB)

create function getprojectemployees(@pnumber int)
returns table 
as return 
(
select e.*
from Project p join Works_for w on p.Pnumber =w.Pno  and p.Pnumber = @pnumber
join Employee e on e.SSN = w.ESSn 
)

select * from getprojectemployees (300)

