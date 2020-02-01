CREATE DATABASE InscripcionDb
GO
USE InscripcionDb
GO
CREATE TABLE Estudiante(
	PersonaId int primary key identity,
	Nombre varchar(50),
	Apellido varchar(50),
	Telefono varchar(15),
	Cedula varchar(15),
	Direccion varchar(max),
	FechaNacimiento date,
	Balance int 	 
);
GO

CREATE TABLE Inscripcion(
	InscripcionId int primary key identity,
	Fecha date,
	PersonaId int,
	Comentario varchar(50),
	Monto int,
	Balance int
);