--1.Create a stored procedure that calculates the sum of a given range of numbers
create proc CalculateSumInRange( @startNum int,  @endNum int,  @result int output)
as
    declare @sumResult int
    SET @sumResult = 0

    WHILE @startNum <= @endNum 
	begin
        SET @sumResult +=  @startNum;
        SET @startNum +=  1;
    END 

    SET @result = @sumResult;

	declare @sum int
	exec CalculateSumInRange 1,4,@sum output
	select @sum

--2.Create a stored procedure that calculates the area of a circle given its radius

create proc sp_getcirclearea(@r float , @area float output)
as
set @area = 3.14 * @r * @r 


declare @area float
exec sp_getcirclearea 2 , @area output
select @area

--3.Create a stored procedure that calculates the age category 
--based on a person's age ( Note: IF Age < 18 then Category is Child
--and if  Age >= 18 AND Age < 60 then Category is Adult otherwise  Category is Senior)

create proc sp_checkage(@age int , @category varchar(20) output)
as 
	if @age <18
	set @category = 'Child'
	else if @Age >= 18 AND @Age < 60
	set @category = 'Adult'
	else
	set @category = 'Senior'


declare @category varchar(20)
exec sp_checkage 22 , @category output
select @category


--4.Create a stored procedure that determines the maximum, minimum,
--and average of a given set of numbers 
--( Note : set of numbers as Numbers = '5, 10, 15, 20, 25')
create proc sp_getminmaxavg(@num1 int , @num2 int,@num3 int ,@num4 int, @num5 int,
@min int output,@avg int output,@max int output)
as 

select @min=min(v),@max=max(v),@avg=avg(v)
from (values (@num1), (@num2), (@num3), (@num4), (@num5)) as value(v);


declare @min int
declare @max int
declare @avg int
exec sp_getminmaxavg 1,2,3,4,5 ,@min output,@avg output,@max output
select @min, @max , @avg

