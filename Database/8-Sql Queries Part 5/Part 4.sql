--1.Create a trigger to prevent anyone from inserting a new record in
--the Department table ( Display a message for user to tell him that
--he can’t insert a new record in that table )


create trigger InsertPreventTrigger 
on Department
instead of insert
as
print 'You can not insert a new record in that table'

insert into Department(Dept_Id , Dept_Name)
values (44,'mydept')


--2.Create a table named “StudentAudit”.
--Its Columns are (Server User Name , Date, Note) 

create table StudentAudit(
ServerUserName varchar(200) ,
Mdate date ,
note varchar(200)
) 

--3.Create a trigger on student table after insert to add Row 
--in StudentAudit table 
--•	 The Name of User Has Inserted the New Student  
--•	Date
--•	Note that will be like ([username] Insert New Row with Key 
--= [Student Id] in table [table name]


create trigger afterinserttTrigger
on student
after insert
as
insert into StudentAudit (ServerUserName , Mdate,note)
select SUSER_NAME() , getdate(),concat(SUSER_NAME(),'Insert New Row with Key', St_Id ,'in table student')
from inserted





--4.Create a trigger on student table instead of delete to add Row in
--StudentAudit table 
--○ The Name of User Has Inserted the New Student
--○ Date
--○ Note that will be like “try to delete Row with id = [Student Id]” 

create trigger OnInsteadofDeleteTrigger
on student
instead of delete
as
insert into StudentAudit (ServerUserName , Mdate,note)
select SUSER_NAME() , getdate(),concat('try to delete Row with id = ', St_Id )
from deleted


--5.Create a trigger that prevents the insertion Process 
--for Employee table in March.


create trigger PreventTrigger
on employee
instead of insert
as
	if  MONTH(getdate()) != 3
	insert into Employee
	select * from inserted

	else
	print 'You can not insert employees in March'





