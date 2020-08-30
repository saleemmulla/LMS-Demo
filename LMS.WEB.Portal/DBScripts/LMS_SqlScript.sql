----1 Master
IF (OBJECT_ID(N'tbl_LeaveTypes',N'U') IS NULL)
BEGIN
	Create table tbl_LeaveTypes
	(
	LeaveTypeId int identity(1,1),
	LeaveTypeName varchar(200)
	primary key(leaveTypeID)
	)
	INSERT INTO tbl_LeaveTypes values('Earned Leave');
	INSERT INTO tbl_LeaveTypes values('Sick Leave ');
END
----2 Master Table
IF (OBJECT_ID(N'tbl_Status',N'U') IS NULL)
BEGIN
	CREATE TABLE tbl_Status 
	(
		StatusId int IDENTITY (1, 1) NOT NULL ,
		StatusName varchar (20) NOT NULL ,
		StatusDescription varchar (255) NULL 
	)
	Insert into tbl_Status values('Pending','Pending');
	Insert into tbl_Status values('Approved','Approved');
	Insert into tbl_Status values('Rejected','Rejected');
END

---3 Master table
IF (OBJECT_ID(N'tbl_LeaveMasters',N'U') IS NULL)
BEGIN
	create table tbl_LeaveMasters 
	(
			LeaveMasterId [int] IDENTITY (1, 1) NOT NULL ,
			LeaveTypeId int NOT NULL ,
			AllotedLeaves int default 0 ,
			UsedLeaves  int  default 0,
			BalanceLeave int default 0 ,
			Year int not null,
			UserName  nvarchar(50)	
	
	)

	INSERT INTO tbl_LeaveMasters(LeaveTypeId,AllotedLeaves,UserName,Year) values (1,15,'noushinmulla',2020);
	INSERT INTO tbl_LeaveMasters(LeaveTypeId,AllotedLeaves,UserName,Year) values (2,9,'noushinmulla',2020);
	INSERT INTO tbl_LeaveMasters(LeaveTypeId,AllotedLeaves,UserName,Year) values (1,15,'saleemmulla',2020);
	INSERT INTO tbl_LeaveMasters(LeaveTypeId,AllotedLeaves,UserName,Year) values (2,9,'saleemmulla',2020);
END
---- 4. Master table
IF (OBJECT_ID(N'tbl_Users',N'U') IS NULL)
BEGIN
CREATE TABLE tbl_Users
(
	UserName varchar(50) NOT NULL ,
	Password varchar (50)  NOT NULL ,
	Role varchar (50)  NOT NULL 
	Primary key(UserName)
)
 insert into tbl_Users values('admin','admin@123','Admin')
 Insert into tbl_Users values('saleemmulla','S@leem123','Manager');
 Insert into tbl_Users values('noushinmulla','Noushin@123','Employee');
 END

---5. MAster
 IF (OBJECT_ID(N'tbl_Departments',N'U') IS NULL)
BEGIN
Create table tbl_Departments
(
 ID int identity(1,1) ,
 departmentName varchar(255) NOT NULL
 PRIMARY KEY (ID)
)
 
INSERT INTO tbl_Departments values('IT');
INSERT INTO tbl_Departments values('HR');
END



 ---5. Main table
 IF (OBJECT_ID(N'tbl_EmpDetails',N'U') IS NULL)
BEGIN
 CREATE TABLE tbl_EmpDetails (
	BadgeNumber int IDENTITY (800, 1) NOT NULL ,
	FirstName varchar (50) NULL ,
	LastName varchar (50) NULL ,
	EmpDesigName varchar (50) NULL ,
	DeptId int NULL ,
	EmailId varchar (50) NULL ,
	ManagerBadgeNumber int NuLL,
	UserName varchar (50) NOT NULL 
)
 
insert into tbl_EmpDetails values ('admin','Admin','admin',1,'lmsappemail@gmail.com',null,'admin')
Insert into tbl_EmpDetails (FirstName,LastName,EmpDesigName,DeptId,EmailId,ManagerBadgeNumber,UserName)
Values('Saleem','Mulla','Principal Software Engineer',1,'saleemwld@gmail.com',800,'saleemmulla');

Insert into tbl_EmpDetails (FirstName,LastName,EmpDesigName,DeptId,EmailId,ManagerBadgeNumber,UserName)
Values('Noushin','Mulla','Software Engineer',1,'saleem.Nettechie@gmail.com',801,'noushinmulla');


END


---7. Main Table
  IF (OBJECT_ID(N'tbl_Leaves',N'U') IS NULL)
BEGIN      
Create table tbl_Leaves
(
 ID int identity(1,1)NOT NULL ,
 BadgeNumber int NOT NULL,
 EmployeeName Varchar(50) NOT NULL,
 DeptId int Not NULL,
 ManagerBadgeNumber int NOT NULL,
 LeaveTypeId int NOT NULL,
 LeaveFromDate Date NOT NULL,
 LeaveToDate Date NOT NULL,
 NumberOfLeaves int NOT NULL,
 RequestedOn Date NOT NULL,
 Reason varchar(500) Not Null,
 STATUS int default 1
 PRIMARY KEY (ID)
)

END
 
 
 