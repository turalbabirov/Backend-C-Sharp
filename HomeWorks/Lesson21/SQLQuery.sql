--########################################################################
-- 1. DemoApp adında bir database yaradılmalıdır:
ALTER DATABASE DemoApp MODIFY NAME = DemoAppX --Keçən dərsdə yazdığım DemoApp-i DemoAppX-ə dəyişdim
CREATE DATABASE DemoApp --Lakin buna baxmayaraq yenidən DemoApp yarada bilmirəm. Error verir. 

--Bu sbəbdən başqa adla yaradıram databazanı:
CREATE DATABASE DemoAppNext1



--########################################################################
-- 2.  Users adında bir table yaradılmalıdır:
USE DemoAppNext1

CREATE TABLE Users (
    Id int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(50) NOT NULL,
	Surname nvarchar(50) NOT NULL,
	Email nvarchar(50) UNIQUE,
	RegistrationDate date DEFAULT CURRENT_TIMESTAMP CHECK(RegistrationDate<=CURRENT_TIMESTAMP),
	ContactNumber nvarchar(50) DEFAULT '+994000000000',
	Age int CHECK(Age>18),
	Address nvarchar(150)
);

-- 3 user bir query altında həmin bu table-a set olunmalıdır.

--#Ilk variantda filed-lərin hamısını manual doldururam:
INSERT INTO Users 
VALUES('Name1', 'Surname1', 'email1@gmail.com', '2025/01/01', '99411111111111', 32, 'Name1 Surname1 Adress')

--#İkinci variantda isə bir field-i doldurmuram. Əvəzinə default dəyər gəlsin deyə:
INSERT INTO Users(Name, Surname, Email, ContactNumber, Age, Address) 
VALUES('Name2', 'Surname2', 'email2@gmail.com', '9942222222222', 19, 'Name2 Surname2 Adress'),
('Name3', 'Surname3', 'email3@gmail.com', '99433333333333', 20, 'Name3 Surname3 Adress')


SELECT * FROM Users;


--########################################################################
-- 3. Categories adında bir table yaradılmalıdır:

CREATE TABLE Categories (
    Id int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(50) NOT NULL,
	CreatedAt date DEFAULT CURRENT_TIMESTAMP CHECK(CreatedAt<=CURRENT_TIMESTAMP),
	IsActive BIT
);

--3 category bir query altında həmin bu table-a set olunmalıdır.
INSERT INTO Categories(Name, IsActive) 
VALUES('Name1', 1),
('Name1', 0),
('Name1', 0)



--########################################################################
-- 4. Bütün Users Select olunmalıdır. (Yalnız Name, Surname, Email)
SELECT Name, Surname, Email FROM Users;



--########################################################################
-- 5. Bütün Categories Select olunmalıdır. (Yalnız Name və IsActive)
SELECT Name, IsActive FROM Categories;