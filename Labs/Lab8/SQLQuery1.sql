--1
CREATE DATABASE Academy
USE Academy


--2
CREATE TABLE Groups (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(50) NOT NULL
)




CREATE TABLE Students (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(50) NOT NULL,
	Surname nvarchar(50) NOT NULL,
	GrupId int NOT NULL FOREIGN KEY REFERENCES Groups(Id)
)


--3
ALTER TABLE Students
ADD Grade int NOT NULL


--4
INSERT INTO Groups
VALUES ('P228'), ('P124'), ('P221')

INSERT INTO Students
VALUES ('Senan', 'Memmedov', 3, 60), 
('Mirze', 'Rzayev', 1, 90), 
('Zaur', 'Hesenov', 1, 30),  
('Tagi', 'Ehmedov', 1, 50)


--5
SELECT *
FROM Groups
INNER JOIN Students
ON Groups.Id = Students.GrupId
WHERE Groups.Name='P228'


--6
SELECT Qrup.Name, COUNT(GrupId) AS [Count]
FROM Groups AS Qrup
INNER JOIN Students
ON Qrup.Id = Students.GrupId
GROUP BY Qrup.Name


--7
CREATE VIEW usv_getAllStudentsInfo AS
SELECT st.Name 'StName',gr.Name 'GrName',st.Surname,st.Grade 
FROM Students AS st
JOIN Groups AS gr
ON gr.Id = st.GrupId

SELECT * FROM usv_getAllStudentsInfo


--8
CREATE PROCEDURE usp_ToHighGrade @Grade int AS 
SELECT *
FROM Students
WHERE Grade > @Grade


EXEC usp_ToHighGrade 50


--9
CREATE OR ALTER FUNCTION HOWMANYTELEBE(@GroupName nvarchar)
RETURNS int
AS
BEGIN

DECLARE @COUNT int
SELECT @COUNT = COUNT(*)
FROM Groups
INNER JOIN Students
ON Groups.Id = Students.GrupId
WHERE Groups.Name='P221'

RETURN @COUNT

END

SELECT dbo.HOWMANYTELEBE('P221') 





SELECT * FROM Groups
SELECT * FROM Students

DROP TABLE Groups
DROP TABLE Students

