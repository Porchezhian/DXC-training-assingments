
--InsertEmployee
create procedure sp_InsertEmployee(@name varchar(20), @gender varchar(6), @location varchar(30), @salary bigint)
as
begin
insert into tblEmployee values (@name, @gender, @location, @salary)
end

--UpdateEmployee
create procedure sp_UpdateEmployee(@id int, @name varchar(20), @gender varchar(6), @location varchar(30), @salary bigint)
as 
begin
update tblEmployee set Name=@name, Gender=@gender, Location=@location, Salary=@salary where Id=@id
end

--DeleteEmployeeById
create procedure sp_DeleteEmployeeById(@id int)
as
begin
delete from tblEmployee where Id=@id
end

--RetriveEmployeeById
create procedure sp_RetriveEmployeeById (@id int)
as
begin
select * from tblEmployee where Id=@id
end

--RetriveAllEmployee
create procedure sp_RetriveAllEmployee
as
begin
select * from tblEmployee
end