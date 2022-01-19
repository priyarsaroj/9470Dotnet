create table customers(
customer_id int primary key not null,
customer_name varchar(25) not null,
customer_age  varchar(10) not null,
customer_address varchar(25) not null,
customer_sal varchar(25) not null);

insert customers values(1,'ramesh',35,'ahmedabad',2000),(2,'khilan',25,'delhi',1500),(3,'kaushik',23,'kota',2000),
(4,'chaitali',25,'mumbai',6500),(5,'hardik',27,'bhopal',8500),(6,'komal',22,'mp',4500),(7,'muffy',24,'indore',10000);

select * from customers;


create table customers_bkp(
customer_id int primary key not null,
customer_name varchar(25) not null,
customer_age  varchar(10) not null,
customer_address varchar(25) not null,
customer_sal varchar(25) not null);

select * from customers_bkp;

select * from customers where customer_id in (select customer_id from customers where customer_sal>4500);

insert into customers_bkp select * from customers where customer_id in (select customer_id from customers);

update customers set customer_sal=customer_sal*1 where customer_age in (select customer_age from customers_bkp where customer_age>=27);

delete from customers where customer_age in(select customer_age from customers_bkp where customer_age>=27);