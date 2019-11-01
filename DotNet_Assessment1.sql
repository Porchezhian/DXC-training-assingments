--supplier table:
--supplierId, supplierName, ProductId, Location, Price

--product table:
--productId, productName 

--customer table:
--customerId, customerName, ProductId, no.of products, supplierId, Total

create table tblProduct(
ProductId int primary key,
ProductName varchar(30)
)

create table tblSupplier(
SupplierId int primary key,
SupplierName varchar(30),
ProductId int foreign key references tblProduct(ProductId),
Location varchar(30),
Price int 
)

create table tblCustomer(
CustomerId int,
CustomerName varchar(30),
ProductId int foreign key references tblProduct(ProductId),
NoOfProducts int ,
SupplierId int foreign key references tblSupplier(SupplierId),
Total int
)

--showCatalog
create procedure sp_ShowCatalog
as 
begin
select p.ProductId, ProductName, SupplierId, SupplierName, Location, Price from tblProduct p 
left join 
tblSupplier s
on p.ProductId = s.ProductId
end

--buy
create procedure sp_Buy(@id int, @name varchar(30), @productid int, @noofproducts int, @supplierid int, @price int)
as
begin
declare @total int
select @price = Price from tblSupplier where tblSupplier.ProductId = @productid
set @total = @price * @noofproducts
insert into tblCustomer values (@id, @name, @productid, @noofproducts, @supplierid, @total)
end

drop procedure sp_Buy

--bill
create procedure sp_Bill(@id int)
as 
begin
select sum(Total) from tblCustomer c
where c.CustomerId = @id
end

--getbill
create procedure sp_GetBill(@id int)
as 
begin
select ProductName, NoOfProducts, Total from tblCustomer c inner join tblProduct p 
on c.ProductId = p.ProductId
where c.CustomerId = @id
end

--getSupplier
create procedure sp_GetSupplier(@supplierid int, @productid int)
as
begin
select ProductId from tblSupplier s 
where s.SupplierId = @supplierid and s.ProductId = @productid
end

--getCustomer
create procedure sp_GetCustomer(@id int)
as
begin
select count(CustomerId) from tblCustomer  where CustomerId = @id
end
