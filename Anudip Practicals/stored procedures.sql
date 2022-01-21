create table employee(
employee_id int primary key not null,
employee_name varchar(25)not null,
employee_city varchar(40)not null,
employee_salary int not null,
employee_phone_number int not null)

insert into employee values(1,'aman','mumbai',20000,1234567890);
insert into employee values(2,'ujala','mumbai',30000,234561809);
insert into employee values(3,'rachana','pune',35000,1234567980);
insert into employee values(4,'shagun','pune',25000,1234568709);
insert into employee values(5,'parth','nashik',20000,1236547890);

select * from employee;

---create procedure
create procedure pro_emp
as
begin
select
employee_name,employee_city,employee_phone_number
from employee
order by employee_name asc;
end;

---execute
execute pro_emp;

---alter
alter procedure pro_emp
as
begin
select
employee_name,employee_city,employee_salary
from employee
where
employee_salary=20000;
end;

