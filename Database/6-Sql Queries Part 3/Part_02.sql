
--1.Display the SalesOrderID, ShipDate of the SalesOrderHearder table
--(Sales schema) to designate SalesOrders that occurred within 
--the period ‘7/28/2002’ and ‘7/29/2014’

select SalesOrderID ,ShipDate 
from Sales.SalesOrderHeader 
where OrderDate between '7/28/2002' and '7/29/2014'

--2.Display only Products(Production schema) with a StandardCost below
--$110.00 (show ProductID, Name only)

select ProductID , Name from
Production.Product
where StandardCost <110.00


--3.Display ProductID, Name if its weight is unknown 

select ProductID , Name from
Production.Product
where Weight is null

--4.Display all Products with a Silver, Black, or Red Color

select *
from Production.Product
where Color in ('Silver','Black','Red')


--5.Display any Product with a Name starting with the letter B

select *
from Production.Product
where Name like 'B%'

--6 -Then write a query that displays any Product description with underscore value in its description.

/*UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3*/

select p.*
from Production.Product  p join Production.ProductDescription pd 
on p.ProductID = pd.ProductDescriptionID and pd.Description like '%_%'



--7.Display the Employees HireDate (note no repeated values are allowed)

select distinct HireDate
from HumanResources.Employee



--8.Display the Product Name and its ListPrice within the values of 100 
--and 120 the list should have the following format "The [product name] is only! [List price]"
--(the list will be sorted according to its ListPrice value)

select Name , concat('The [' , Name , ' ] is only ! ',ListPrice) as ListPirces
from Production.Product p
where ListPrice between 100 and 120
order by p.ListPrice 






