# EntityCRUD 


Aplicación web de ASP.NET Core (MVC): 

Esta plantilla también puede usarse para servicios RESTful HTTP. 

.Herramientas: 
-EntityFrameworkCore.SqlServer
-EntityFrameworkCore.Tools 


* Script de la Base de Datos: 

CREATE DATABASE ENTITYCRUD
USE ENTITYCRUD

CREATE TABLE Usuarios(
Id int identity(1,1) primary key, 
Nombre varchar(50), 
Fecha date, 
Clave varchar(50)
) 