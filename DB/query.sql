CREATE DATABASE Ventas
USE Ventas
GO

CREATE TABLE UserType (
    UserTypeId INT IDENTITY(1,1) PRIMARY KEY
    , Description NVARCHAR(100) 
)
GO

CREATE TABLE User (
    UserId INT IDENTITY(1,1) PRIMARY KEY
    , UserName VARCHAR(10)
    , Password VARBINARY
    , ImagePath VARCHAR(256)
    , UserTypeId INT REFERENCES UserType (UserTypeId)
)
GO