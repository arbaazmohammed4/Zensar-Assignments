USE ITFIRM

------------------------------------------CREATING CLIENTS TABLE----------------------------------------------

/*CREATE TABLE CLIENTS
(Client_ID NUMERIC(4) Primary Key,
CName NVARCHAR(40) Not Null,
Adress NVARCHAR(30), 
Email NVARCHAR(30) Unique,
Phone NUMERIC(10),
Business NVARCHAR(20) Not Null )*/

----------------------------------CREATING EMPLOYEES TABLE----------------------------------------------------------
 
/*CREATE TABLE EMPLOYEES
(EMPNO NUMERIC(4) PRIMARY KEY,
ENAME VARCHAR(20) NOT NULL,
JOB NVARCHAR(15),
SALARY NUMERIC(7) CHECK(SALARY>0),
DEPTNO NUMERIC(2) FOREIGN KEY REFERENCES DEPARTMENTS(DEPTNO))*/

-----------------------------------------CREATING DEPARTMENTS TABLE------------------------------------------------

/*CREATE TABLE DEPARTMENTS
(DEPTNO NUMERIC(2) PRIMARY KEY,
DNAME VARCHAR(15) NOT NULL,
LOC VARCHAR(20))*/

---------------------------------------CREATING PROJECTS TABLE-----------------------------------------------------

/*CREATE TABLE PROJECTS
(PROJECT_ID NUMERIC(3) PRIMARY KEY,
DESCR VARCHAR(20) NOT NULL,
START_DATE DATE,
PLANNED_END_DATE DATE,
ACTUAL_END_DATE DATE,
--CHECK(ACTUAL_END_DATE > PLANNED_END_DATE),
BUDGET NUMERIC(10) CHECK(BUDGET>0),
Client_ID NUMERIC(4) FOREIGN KEY REFERENCES CLIENTS(Client_ID))*/

------------------------------------CREATING EmpProjectTasks TABLE------------------------------------------------

/*CREATE TABLE EmpProjectTasks
(PROJECT_ID NUMERIC(3) FOREIGN KEY REFERENCES PROJECTS(PROJECT_ID),
EMPNO NUMERIC(4)  FOREIGN KEY REFERENCES EMPLOYEES(EMPNO),
START_DATE DATE,
END_DATE DATE,
TASK VARCHAR(25) NOT NULL,
STATUS VARCHAR(15) NOT NULL)*/

-------------------------------------------------INSERTING---------------------------------------------------------------

/*INSERT INTO CLIENTS VALUES
(1001,'ACME Utilities','Noida','contact@acmeutil.com', 9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')*/

SELECT * FROM CLIENTS
------------------------------------------------------------------------------------------------------------------

/*INSERT INTO EMPLOYEES VALUES
(7001	,'Sandeep',	'Analyst',	25000,	10),
(7002	,'Rajesh',	'Designer',	30000,	10),
(7003,	'Madhav',	'Developer',	40000,	20),
(7004,	'Manoj'	,'Developer'	,40000,	20),
(7005,	'Abhay',	'Designer',	35000,	10),
(7006,	'Uma'	,'Tester'	,30000	,30),
(7007,	'Gita',	'Tech. Writer'	,30000,	40),
(7008,	'Priya',	'Tester'	,35000	,30),
(7009,	'Nutan',	'Developer'	,45000,	20),
(7010	,'Smita'	,'Analyst'	,20000	,10),
(7011	,'Anand','Project Mgr',65000,10)*/

SELECT * FROM EMPLOYEES
--------------------------------------------------------------------------------------------------------------

/*INSERT INTO DEPARTMENTS VALUES
(10	,'Design',	'Pune'),
(20	,'Development',	'Pune'),
(30	,'Testing',	'Mumbai'),
(40	,'Document',	'Mumbai')*/

SELECT * FROM DEPARTMENTS
--------------------------------------------------------------------------------------------------------------

/*INSERT INTO PROJECTS VALUES
(401,	'Inventory',	'01-Apr-11',	'01-Oct-11',	'31-Oct-11',	150000,	1001),
(402,	'Accounting',	'01-Aug-11',	'01-Jan-12', '' ,		500000,	1002),
(403,	'Payroll'	,'01-Oct-11',	'31-Dec-11',	''	,75000	,1003),
(404,	'Contact Mgmt'	,'01-Nov-11',	'31-Dec-11',	'',	50000,	1004)*/

SELECT * FROM PROJECTS

-------------------------------------------------------------------------------------------------------------

/*INSERT INTO EmpProjectTasks VALUES
(401,	7001,	'01-Apr-11',	'20-Apr-11',	'System Analysis',	'Completed'),
(401,	7002,	'21-Apr-11',	'30-May-11',	'System Design',	'Completed'),
(401,	7003,	'01-Jun-11',	'15-Jul-11',	'Coding',	'Completed'),
(401,	7004,	'18-Jul-11',	'01-Sep-11',	'Coding',	'Completed'),
(401,	7006,	'03-Sep-11',	'15-Sep-11',	'Testing',	'Completed'),
(401,	7009,	'18-Sep-11',	'05-Oct-11',	'Code Change',	'Completed'),
(401,	7008,	'06-Oct-11',	'16-Oct-11',	'Testing',  	'Completed'),
(401,	7007,	'06-Oct-11',	'22-Oct-11',	'Documentation',	'Completed'),
(401,	7011,	'22-Oct-11',	'31-Oct-11',	'Sign off'	, 'Completed'),
(402,	7010,	'01-Aug-11',	'20-Aug-11',	'System Analysis',	'Completed'),
(402,	7002,	'22-Aug-11',	'30-Sep-11',	'System Design',	'Completed'),
(402,	7004,	'01-Oct-11',     NULL, 		       'Coding',	'In Progress')*/

SELECT * FROM EmpProjectTasks






