CREATE DATABASE [Consultorio]
GO
USE [Consultorio]
GO

CREATE TABLE [dbo].[ObrasSociales](
	[idObraSocial] [int] IDENTITY(1,1) NOT NULL,
	[nombreObraSocial] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ObrasSociales] PRIMARY KEY CLUSTERED 
(
	[idObraSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Pacientes](
	[numeroHC] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[obraSocial] [int] NOT NULL,
	[sexo] [int] NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[numeroHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into ObrasSociales (nombreObraSocial) values(	'APROSS')
insert into ObrasSociales (nombreObraSocial) values(	'MET')
insert into ObrasSociales (nombreObraSocial) values(	'OSDE')
insert into ObrasSociales (nombreObraSocial) values(	'DASUTEN')
insert into ObrasSociales (nombreObraSocial) values(	'DASPU')
insert into ObrasSociales (nombreObraSocial) values(	'PAMI')


insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) values(	'Marcos',	3	,	2	,'15/12/2001')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) values(	'Ramirin',	5	,	2	,'15/12/2001')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) values(	'Enzo',	4	,	2	,'05/12/2004')
insert into Pacientes (nombre, obraSocial, sexo, fechaNacimiento) values(	'Renata',	2	,	1	,'08/03/2007')
