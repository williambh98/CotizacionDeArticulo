CREATE DATABASE ArticuloDb
GO
USE ArticuloDb
GO

CREATE TABLE Articulos
(
ArticuloID int primary Key identity,
Descripcion varchar (30),
Precio decimal,
Existencia int,
CantidadCotizada int,
FechaVencimiento datetime

);