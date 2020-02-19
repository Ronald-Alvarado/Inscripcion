CREATE DATABASE InscripcionDb
GO
USE InscripcionDb
GO
CREATE TABLE Estudiantes(
	PersonaId int primary key identity,
	Nombre varchar (max),
	Apellido varchar (max),
	Telefono varchar (max),
	Cedula varchar (max),
	Direccion varchar(max),
	FechaNacimiento datetime,
	Balance int
);
GO
CREATE TABLE Inscripciones(
	Inscripcion int primary key identity,
	fecha datetime,
	PersonaId int,
	Monto int,
	Balance int
);