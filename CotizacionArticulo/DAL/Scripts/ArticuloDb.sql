CREATE DATABASE ArticuloDb
GO
USE ArticuloDb
GO

CREATE TABLE Articulos
(
ArticuloID int primary Key identity,
Descripcion varchar (max) NOT NULL,
Precio decimal,
Existencia int,
CantidadCotizada int,
FechaVencimiento datetime

);