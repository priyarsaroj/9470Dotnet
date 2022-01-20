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


create  table department(
deptid int primary key not null,
dept_name varchar(25) not null)

insert into department values(1,'administration'),(2,'customer serrvice'),(3,'finance'),(4,'human resource'),(5,'sales');

select * from department;
 
select e1.employee_id,e1.employee_name,d1.dept_name from employee AS e1 inner join department AS d1 on e1.employee_id=d1.deptid order by employee_id;

select e1.employee_id,e1.employee_name,d1.dept_name from employee as e1 left join department as d1 on e1.employee_name=d1.dept_name;

select e1.employee_id,e1.employee_name,d1.dept_name from employee as e1 right join department as d1 on e1.employee_name=d1.dept_name;

select e1.employee_id,e1.employee_name,d1.dept_name from employee as e1 full join department as d1 on e1.employee_name=d1.dept_name;

select e1.employee_id,e1.employee_name,d1.dept_name from employee as e1 cross join department as d1;
