Create table TblDepartment
(
 Id int primary key identity,
 Name nvarchar(50)
)
Insert into TblDepartment values('Computer')
Insert into TblDepartment values('Electronics')
Insert into TblDepartment values('Civil')
Create table TblStudent
(
 StudentId int Primary Key Identity(1,1),
 Name nvarchar(50),
 Gender nvarchar(10),
 City nvarchar(50),
 DepartmentId int
)

Alter table TblStudent
add foreign key (DepartmentId)
references TblDepartment(Id)

Insert into TblStudent values('Mark','Male','London',1)
Insert into TblStudent values('John','Male','Chennai',3)
Insert into TblStudent values('Mary','Female','New York',3)
Insert into TblStudent values('Mike','Male','Sydeny',2)
Insert into TblStudent values('Scott','Male','London',1)
Insert into TblStudent values('Pam','Female','Falls Church',2)
Insert into TblStudent values('Todd','Male','Sydney',1)
Insert into TblStudent values('Ben','Male','New Delhi',2)
Insert into TblStudent values('Sara','Female','London',1)