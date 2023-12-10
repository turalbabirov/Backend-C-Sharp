--1. DemoApp adında bir database yaradılmalıdır:
CREATE DATABASE DemoApp 


--2.  Users adında bir table yaradılmalıdır:
USE DemoApp
CREATE TABLE Users 
(
	Id int,
	Name nvarchar(50),
	Surname nvarchar(50),
	Email nvarchar(50),
	ContactNumber nvarchar(50),
	Age int,
	Address nvarchar(50)
)


--<<Üç user bir query altında həmin bu table-a set olunmalıdır>>
INSERT INTO Users
VALUES (1, 'Tural', 'Babirov', 'turalbabirov@mail.com', '0557977129', 30, 'Baku, Qaradag'),
(2, 'Name1', 'Surname1', 'name1surname@gmail.com', '0123456789', 33, 'Baku, Sahil'),
(3, 'Name2', 'Surname2', 'name2surname@gmail.com', '9876543210', 33, 'Baku, Sahil')


--3. Categories adında bir table yaradılmalıdır:
CREATE TABLE Categories 
(
	Id int,
	Name nvarchar(50),
	Slug nvarchar(50),
	CreatedAt datetime,
	IsActive bit 
)

--<<Üç category bir query altında həmin bu table-a set olunmalıdır>>
INSERT INTO Categories
VALUES (1, 'Tural', 'SlugNedir?', '10.12.2023', '1'),
(2, 'Name1', 'SlugNedir?', '11.12.2023', '0'),
(2, 'Name2', 'SlugNedir?', '12.12.2023', '1')


--4. Bütün Users Select olunmalıdır. (Yalnız Name, Surname, Email)
SELECT Name, Surname, Email FROM Users

--5. Bütün Categories Select olunmalıdır. (Yalnız Name və IsActive)
SELECT Name, IsActive FROM Categories