CREATE TABLE [dbo].[Employees](    
    [Id] [int] IDENTITY(1,1) NOT NULL,    
    [Name] [nvarchar](50) NULL,    
    [Gender] [char](10) NULL,    
    [Age] [int] NULL,    
    [Position] [nvarchar](50) NULL,    
    [Office] [nvarchar](50) NULL,    
    [Salary] [int] NULL,    
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED     
(    
    [Id] ASC    
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]    
) ON [PRIMARY]    
    
GO    
    
CREATE TABLE [dbo].[Department](    
    [Id] [int] IDENTITY(1,1) NOT NULL,    
    [DepartmentName] [nvarchar](50) NULL,    
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED     
(    
    [Id] ASC    
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]    
) ON [PRIMARY]    
    
GO    
    
CREATE TABLE [dbo].[Incentive](    
    [Id] [int] IDENTITY(1,1) NOT NULL,    
    [IncentiveAmount] [int] NULL,    
 CONSTRAINT [PK_Incentive] PRIMARY KEY CLUSTERED     
(    
    [Id] ASC    
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]    
) ON [PRIMARY]    
    
GO