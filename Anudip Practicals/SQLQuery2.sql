create table student(
studentid int primary key not null,
name varchar(25) not null,
address varchar(40) not null)

insert into student values(1,'aayushi','vasai');
insert into student values(2,'ayush','vasai');
insert into student values(3,'ananya','mumbai');
insert into student values(4,'ayansh','pune');
insert into student values(5,'arpita','nashik');

delete from student where studentid=2;

select * from student;
