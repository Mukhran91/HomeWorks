-- 1 

select Firstname, Lastname from Students WHERE DoB < '1990'

--2
go 

select Firstname, Lastname,  YEAR(GETDATE()) - YEAR(DoB) as age from Students 
where Country in ('Georgia','Libya')

GO

--3

INSERT INTO [dbo].[Students]
(Firstname, Lastname,EMail,Country)
	VALUES
		(N'Mukhrani', N'Kakhadze','Mukhran91@gmail.com', 'Georgia');


GO

--4

SELECT TOP(5) WITH TIES Firstname, MIddleTest FROM Students order by MiddleTest ASC

GO

--5

DELETE from Students OUTPUT deleted. * where FinalTest = 19;

GO

--6

UPDATE Students set FinalTest = 0 OUTPUT inserted. * where MiddleTest = 1;

GO

--PERSONS

--1

SELECT * from Persons where PrivateId LIKE '163%';

GO

--2

SELECT * from Persons where Lastname = City

GO

--3

SELECT * from Persons where Country in ('Canada ', 'Monaco');

GO

--4

select Firstname, Lastname, PrivateId from Persons where Email is NULL;

GO

--5

select * from Persons where Country in ('Spain', 'Turkey') and Salary BETWEEN 1000 and 3000;

GO

--6

SELECT Workplace FROM Persons WHERE Workplace LIKE '%LLC%' or Workplace LIKE 'PC' or Workplace LIKE 'LLP';

GO

--7

SELECT Email,
    CASE
        WHEN LEN(Email) - LEN(REPLACE(Email, '.', '')) > 2 THEN 'more than 2 dots'
        ELSE 'less than 2 dots'
    END AS MailInfo 
FROM Persons;

GO

--8 

SELECT * FROM Persons WHERE PINcode LIKE '%51';

GO

--9 

SELECT COUNTRY, AVG(Salary) as average from Persons GROUP by Country;

GO
