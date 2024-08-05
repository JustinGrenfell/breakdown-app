CREATE DATABASE BreakdownDB;

USE BreakdownDB;

CREATE TABLE Breakdowns (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    BreakdownReference VARCHAR(255) NOT NULL UNIQUE,
    CompanyName VARCHAR(255) NOT NULL,
    DriverName VARCHAR(255) NOT NULL,
    RegistrationNumber VARCHAR(255) NOT NULL,
    BreakdownDate DATETIME NOT NULL
);