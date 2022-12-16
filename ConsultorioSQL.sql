CREATE DATABASE [Consultorio]
GO
USE [Consultorio]
GO

CREATE TABLE ObrasSociales(
	idObraSocial int IDENTITY(1,1) NOT NULL,
	nombreObraSocial varchar(50) NOT NULL,
 CONSTRAINT [PK_ObrasSociales] PRIMARY KEY (idObraSocial)
 )

CREATE TABLE Pacientes(
	numeroHC int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	obraSocial int NOT NULL,
	sexo int NOT NULL,
	fechaNacimiento date NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY (numeroHC),
 constraint fk_obra_social foreign key (obraSocial)
	references ObrasSociales (idObraSocial)
)

insert into ObrasSociales (nombreObraSocial)
values('APROSS')
insert into ObrasSociales (nombreObraSocial)
values('MET')
insert into ObrasSociales (nombreObraSocial)
values('OSDE')
insert into ObrasSociales (nombreObraSocial)
values('DASUTEN')
insert into ObrasSociales (nombreObraSocial)
values('DASPU')
insert into ObrasSociales (nombreObraSocial)
values('PAMI')


insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento)
values('Marcos',	3	,	2	,'15/12/2001')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) 
values('Ramirin',	5	,	2	,'15/12/2001')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) 
values('Enzo',	4	,	2	,'05/12/2004')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) 
values('Renata',	2	,	1	,'08/03/2007')
