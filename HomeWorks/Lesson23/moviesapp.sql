--#################################################
--1. MoviesApp adında bir database yaradılmalıdır.
CREATE DATABASE MoviesApp 


USE MoviesApp
--#################################################



--2. Directors (Rejissorlar) adında table yaradılmalıdır.
CREATE TABLE Directors (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(50),
	Surname nvarchar(50)
)


--3. Movies (Filmlər) adında table yaradılmalıdır.
CREATE TABLE Movies (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(100),
	Description nvarchar(250),
	CoverPhoto nvarchar(300)
)


--4. Actors (Aktyorlar) adında table yaradılmalıdır.
CREATE TABLE Actors (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(50),
	Surname nvarchar(50)
)


--5. Genres (Janrlar) adında table yaradılmalıdır.
CREATE TABLE Genres (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(20)
)



--6. Languages (Dillər) adında table yaradılmalıdır.
CREATE TABLE Languages (
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(20)
)


--#################################################


--2.1 Rejissorun bir-neçə filmi ola bilər.
ALTER TABLE Directors
ADD MovieId int FOREIGN KEY REFERENCES Movies(Id)


--3.1 Bir filmdə bir-neçə aktyor iştirak edə bilər.
ALTER TABLE Movies
ADD ActorId int UNIQUE FOREIGN KEY REFERENCES Actors(Id)
--3.2 Bir filmin bir-neçə janrı ola bilər.
ALTER TABLE Movies
ADD GenreId int UNIQUE FOREIGN KEY REFERENCES Genres(Id)
--3.3 Bir filmin yalnız bir dili ola bilər (NOTE: Burdakı məntiq filmin yalnız əsas dili üçün nəzərdə tutulub, flmin müxtəlif dillərə tərcüməsi nəzərə alınmır)
ALTER TABLE Movies
ADD LanguageId int UNIQUE FOREIGN KEY REFERENCES Languages(Id)


--4.1 Bir aktyor bir-neçə filmdə rol ala bilər.
ALTER TABLE Actors
ADD MovieId int UNIQUE FOREIGN KEY REFERENCES Movies(Id)


--5.1 Bir janrda bir-neçə film ola bilər.
ALTER TABLE Genres
ADD GenreId int UNIQUE FOREIGN KEY REFERENCES Movies(Id)


--6.1 Bir dildə bir neçə film ola bilər (NOTE: Burdakı məntiq filmin yalnız əsas dili üçün nəzərdə tutulub, filmin müxtəlif dillərə tərcüməsi nəzərə alınmır)
ALTER TABLE Languages
ADD MovieId int UNIQUE FOREIGN KEY REFERENCES Movies(Id)


--#################################################


--7. Hər table-a relation-ı ilə birlikdə 3-4 data insert əlavə olunmalıdır.
INSERT INTO Movies
VALUES ('Leave the World Behind','A familys getaway to a luxurious rental home takes an ominous turn when a cyberattack knocks out their devices, and two strangers appear at their door.','https://popcornreviewss.com/wp-content/uploads/2023/12/Leave-The-World-Behind-2023-Mystery-Thriller-English-Movie-Review.jpg',1,1,1)

INSERT INTO Directors
VALUES ('Sem','Esmayl',1)

INSERT INTO Languages
VALUES ('English',1)

INSERT INTO Genres
VALUES ('Genres',1),
('Mystery',1),
('Thriller',1)

INSERT INTO Actors
VALUES ('Amanda','Sandford',1),
('Clay','Sandford',1),
('Archie','Sandford',1)



--Niyə error atır anlamıram.


--#################################################

SELECT * FROM Directors
SELECT * FROM Movies
SELECT * FROM Actors
SELECT * FROM Genres
SELECT * FROM Languages

DROP TABLE Directors
DROP TABLE Movies
DROP TABLE Actors
DROP TABLE Genres
DROP TABLE Languages

DROP DATABASE MoviesApp

--#################################################