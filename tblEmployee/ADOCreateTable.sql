create table tblEmployee(
Id int primary key Identity,
Name varchar(30),
Gender varchar(6),
Location varchar(30),
Salary bigint
)

insert into tblEmployee (Name, Gender, Location, Salary) values ('porsche', 'male', 'banglore', 40000)
insert into tblEmployee (Name, Gender, Location, Salary) values ('sam', 'female', 'chennai', 50000)
insert into tblEmployee (Name, Gender, Location, Salary) values ('yuva', 'female', 'banglore', 60000)
insert into tblEmployee (Name, Gender, Location, Salary) values ('porsche', 'male', 'delhi', 70000)
