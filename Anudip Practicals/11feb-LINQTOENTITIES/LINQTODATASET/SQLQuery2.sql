CREATE TABLE [dbo].[EmployeeDetails1](
[EmpId] INT IDENTITY (1, 1) NOT NULL,
[EmpName] VARCHAR (50) NULL,
[Location] VARCHAR (50) NULL,
[Gender] VARCHAR (20) NULL
PRIMARY KEY CLUSTERED ([EmpId] ASC)
);

insert into EmployeeDetails1 values ('Suresh Dasari','Chennai','Male')
insert into EmployeeDetails1 values ('Rohini Alavala','Chennai','Female')
insert into EmployeeDetails1 values ('Praveen Alavala','Guntur','Male')
insert into EmployeeDetails1 values ('Sateesh Chandra','Vizag','Male')
insert into EmployeeDetails1 values ('Sushmitha','Vizag','Female')