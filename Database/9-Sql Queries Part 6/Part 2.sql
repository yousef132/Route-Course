--•	Create an index on column (Hiredate) that allows you to cluster the data in table Department.
--What will happen?


-- if i use clustered index it will cause  error because only one clustered index (on PK column) can be created for a table
create clustered index hiredateindex
on Department(Manager_hiredate)
--NO ERRORS
create nonclustered index hiredateindex
on Department(Manager_hiredate)

--•	Create an index that allows you to enter unique ages in the student table. What will happen?
--can't be created because there are duplicated values in column st_age 
CREATE UNIQUE INDEX idx_unique_age ON student (St_Age);


--•	Try to Create Login Named(RouteStudent) who can access Only student and Course tables
--from ITI DB then allow him to select and insert data into tables and deny Delete and update
