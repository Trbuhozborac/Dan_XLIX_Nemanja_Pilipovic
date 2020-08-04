IF DB_ID('HotelDB') IS NULL
CREATE DATABASE HotelDB
GO

USE HotelDB
IF EXISTS (SELECT NAME FROM sys.sysobjects WHERE NAME = 'tblAbsences')
DROP TABLE tblAbsences
IF EXISTS (SELECT NAME FROM sys.sysobjects WHERE NAME = 'tblManagers')
DROP TABLE tblManagers
IF EXISTS (SELECT NAME FROM sys.sysobjects WHERE NAME = 'tblStaff')
DROP TABLE tblStaff


CREATE TABLE tblManagers(
Id INT PRIMARY KEY IDENTITY (1,1),
Name varchar(20),
Surname varchar(50),
DateOfBirth date,
Mail varchar(30),
Username varchar(20),
HashedPassword varchar(100),
HotelLevel int,
YearsOfExperience int,
QualificationLevel int
);

CREATE TABLE tblStaff(
Id INT PRIMARY KEY IDENTITY (1,1),
Name varchar(20),
Surname varchar(50),
DateOfBirth date,
Mail varchar(30),
Username varchar(20),
HashedPassword varchar(100),
HotelLevel int,
Gender char,
Citizenship varchar(20),
Engagement varchar(20),
Salary money
);

CREATE TABLE tblAbsences(
Id INT PRIMARY KEY IDENTITY (1,1),
FirstDay date,
LastDay date,
Cause varchar(50),
FkStaff int
);

ALTER TABLE tblAbsences ADD FOREIGN KEY(FkStaff) REFERENCES tblStaff(Id);

