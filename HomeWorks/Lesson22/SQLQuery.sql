--1. DrugstoreApp adında bir database qurulmalıdır.
CREATE DATABASE DrugstoreApp

-- DrugstoreApp bazasına qoşuluruq:
USE DrugstoreApp
--#################################################



--2. Owners (Sahibkarlar) adında bir table qurulmalıdır: 
CREATE TABLE Owners (
    Id int PRIMARY KEY IDENTITY,
    Name nvarchar(50),
	Surname nvarchar(50),
);

--3. Drugstores (Apteklər) adında bir table qurulmalıdır: 
CREATE TABLE Drugstores (
    id int PRIMARY KEY IDENTITY,
	Name nvarchar(50),
	Address nvarchar(250),
	ContactNumber nvarchar(20) UNIQUE,
	CreationDate datetime
);

--4. Pharmacists (Əczaçılar) adında bir table qurulmalıdır: 
CREATE TABLE Pharmacists (
    id int PRIMARY KEY IDENTITY,
	Name nvarchar(50),
	Surname nvarchar(50),
	Age int,
	Experience nvarchar(300),
	
);

--5. Drugs (Dərmanlar) adında bir table qurulmalıdır:
CREATE TABLE Drugs (
	id int PRIMARY KEY IDENTITY,
	Name nvarchar(50),
	Price decimal,
	Count decimal,
);
--#################################################



----2.1. Sahibkarın bir neçə apteki ola bilər.
ALTER TABLE Owners
ADD DrugStoreId int FOREIGN KEY REFERENCES Drugstores(Id);

----3.1. Aptekin yalnız bir sahibkarı var.
----3.2. Aptekin çoxlu sayda əczaçısı ola bilər.
----3.3. Aptekin çoxlu sayda dərmanı ola bilər.
ALTER TABLE Drugstores
ADD OwnerId int UNIQUE FOREIGN KEY REFERENCES Owners(id)

ALTER TABLE Drugstores
ADD PharmacistId int UNIQUE FOREIGN KEY REFERENCES Pharmacists(Id)

ALTER TABLE Drugstores
ADD DrugId int UNIQUE FOREIGN KEY REFERENCES Drugs(Id)

----4.1 Əczaçının yalnız bir apteki var.
ALTER TABLE Pharmacists
ADD StoreId int UNIQUE FOREIGN KEY REFERENCES Drugstores(Id)

----5.1 Dərmanın yalnız bir apteki var.
ALTER TABLE Drugs
ADD DrugStoreId int UNIQUE FOREIGN KEY REFERENCES Drugstores(Id)
--#################################################



SELECT * FROM Owners 
SELECT * FROM Drugstores 
SELECT * FROM Pharmacists 
SELECT * FROM Drugs 