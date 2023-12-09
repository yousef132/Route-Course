use ITI
--1.Get all instructors Names without repetition
	select distinct Ins_Name
	from Instructor

--2.Display instructor Name and Department Name 
select i.Ins_Name , d.Dept_Name from 
Instructor i left outer join Department d
on i.Dept_Id = d.Dept_Id

--3.Display student full name and the name of the course he is taking
--For only courses which have a grade  
select [Full Name]=s.St_Fname+ ' '+ s.St_Lname , c.Crs_Name from 
Student s inner join Stud_Course sc 
on s.St_Id=sc.St_Id and sc.Grade is not null
inner join Course c on c.Crs_Id=sc.Crs_Id

--Bouns

/*
 @@AnyExpression is a global variable which is defined by sql server to get some data
*/

--get sql server version (Microsoft SQL Server 2022 (RTM-GDR) (KB5029379) - 16.0.1105.1 (X64)   Aug 24 2023 02:40:55   Copyright (C) 2022 Microsoft Corporation  Developer Edition (64-bit) on Windows 10 Pro 10.0 <X64> (Build 22621: ) )
select @@VERSION

--get server name (DESKTOP-AF2O25E)
select @@SERVERNAME
