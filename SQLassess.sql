create database sqlasses

create table branch_master
(
	branch_id varchar(6),
	branch_name varchar(30),
	branch_city varchar(30),
	constraint pk_branch_id primary key(branch_id)
)

create table loan_details
(
	customer_number varchar(6),
	branch_id varchar(6),
	loan_amount int,
	constraint fk_customer_number foreign key(customer_number) references customer_master(customer_number),
	constraint fk_branch_id foreign key(branch_id) references branch_master(branch_id)
)

create table customer_master
(
	customer_number varchar(6),
	firstname varchar(30),
	middlename varchar(30),
	lastname varchar(30),
	customer_city varchar(15),
	customer_conatact_no varchar(10),
	occupation varchar(20),
	customer_date_of_birth Date,
	constraint pk_customer_number primary key(customer_number)
)

create table account_master
(
	account_number varchar(6),
	customer_number varchar(6),
	branch_id varchar(6),
	opening_balance int,
	account_opening_date Date,
	account_type varchar(10),
	account_status varchar(10)
	constraint pk_account_number primary key(account_number),
	constraint fk_customer_number_am foreign key(customer_number) references customer_master(customer_number),
	constraint fk_branch_id_am foreign key(branch_id) references branch_master(branch_id)
)

create table transaction_details
(
	transaction_number varchar(6),
	account_number varchar(6),
	date_of_transaction Date,
	medium_of_transaction varchar(20),
	transaction_type varchar(20),
	transaction_amount int
	constraint pk_transaction_number primary key(transaction_number),
	constraint fk_account_number foreign key(account_number) references account_master(account_number)
)



select * from account_master
select * from branch_master
select * from customer_master
select * from loan_details
select * from transaction_details

--1.
select am.account_number, am.customer_number, cm.firstname, cm.lastname, am.account_opening_date 
from 
account_master am inner join
customer_master cm
on am.customer_number = cm.customer_number
order by am.account_number

--2.
select count(customer_city) as Cust_Count from customer_master where customer_city = 'DELHI'

--3.
select cm.customer_number, cm.firstname, am.account_number from
customer_master cm inner join
account_master am
on am.customer_number = cm.customer_number
where day(account_opening_date) > 15
order by cm.customer_number asc, am.account_number asc

--4.
select cm.customer_number, cm.firstname, am.account_number from
customer_master cm inner join
account_master am
on am.customer_number = cm.customer_number
where am.account_status = 'TERMINATED'
order by cm.customer_number asc, am.account_number asc

--5.
select transaction_type, count(transaction_type) as Trans_Count from transaction_details t inner join account_master a 
on t.account_number = a.account_number
where a.customer_number like '%001'
group by transaction_type
order by transaction_type asc

--6.
select count(customer_number) as Count_customer from customer_master
where customer_number not in (select customer_number from account_master)

--7.
select t.account_number, sum(transaction_amount)+opening_balance from transaction_details t inner join account_master a
on t.account_number = a.account_number 
where t.transaction_type = 'DEPOSIT'
group by t.account_number, a.opening_balance