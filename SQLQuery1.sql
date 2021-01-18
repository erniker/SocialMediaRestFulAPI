CREATE TABLE Seguridad
(
	IdSeguridad int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Usuario varchar(50) NOT NULL,
	NombreUsuario varchar(100) NOT NULL,
	Contrasena varchar(200) NOT NULL,
	Rol varchar(15) NOT NULL
)