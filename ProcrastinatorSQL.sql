--CREATE DATABASE ProcrastinatorDB;
--USE ProcrastinatorDB;

--CREATE TABLE [User] (UserID INT IDENTITY (1,1) PRIMARY KEY,
--FirstName NVARCHAR(255),
--LastName NVARCHAR(255),
--Email NVARCHAR(255),
--PhotoUrl NVARCHAR(255),
--Display NVARCHAR(255)
--);

--CREATE TABLE Task (UserID INT FOREIGN KEY REFERENCES [User] (UserId )NOT NULL,
--TaskID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
--Task NVARCHAR(255),
--Deadline DATE,
--Details NVARCHAR(255),
--IsComplete BIT
--);

--CREATE TABLE MealPlanner (UserID INT FOREIGN KEY REFERENCES [User] (UserId) NOT NULL,
--MealID INT IDENTITY (1,1) PRIMARY KEY,
--Title NVARCHAR(255), 
--[Url] NVARCHAR(255), 
--[Like] BIT, 
--IsCompleted BIT
--);

--ALTER TABLE Task
--ADD Created Date;
