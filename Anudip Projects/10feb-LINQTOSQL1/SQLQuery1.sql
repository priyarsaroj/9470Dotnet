Create table StudentData  
(  
    RollNumber int primary key,  
    StudentName varchar(50),  
    FatherName varchar(50),  
    MotherName varchar(50)    
)  

Insert into StudentData(RollNumber,StudentName,FatherName,MotherName) values(101,'Akshay','Rakesh Tyagi','Samlesh Tyagi')  
Insert into StudentData(RollNumber,StudentName,FatherName,MotherName) values(102,'Vaishali','Ashok Tyagi','Munesh Tyagi')  
Insert into StudentData(RollNumber,StudentName,FatherName,MotherName) values(103,'Arpita','Arvind Rai','Anni Rai')  

Select *from StudentData;

