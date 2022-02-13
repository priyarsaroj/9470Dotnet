create table Student
(
Id int identity(1,1)not null,
First_name varchar(20)null,
Last_name varchar(20)null,
Address varchar(50)null,
Phone_No varchar(15)null,
primary key clustered(Id asc)
);

insert into Student values('Rachel','Green','California',8888777665);
insert into Student values('Monica','Geller','Alabama',7777666554);
insert into Student values('Phoebe','Buffay','California',6666555443);
insert into Student values('Joey','Tribbiani','Massachusetts',5555444332);
insert into Student values('Chandler','Bing','Massachusetts',4444333221);
insert into Student values('Ross','Geller','New York',3333222110);
 
select * from Student;

