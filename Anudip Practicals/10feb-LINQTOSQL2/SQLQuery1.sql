CREATE TABLE [dbo].[EmployeeDetails](
[EmpId] INT IDENTITY (1, 1) NOT NULL,
[EmpName] VARCHAR (50) NULL,
[Location] VARCHAR (50) NULL,
[Gender] VARCHAR (20) NULL
PRIMARY KEY CLUSTERED ([EmpId] ASC)
);

insert into EmployeeDetails(EmpName,Location,Gender)values('achal','mumbai','female');
insert into EmployeeDetails(EmpName,Location,Gender)values('apoorva','pune','female');