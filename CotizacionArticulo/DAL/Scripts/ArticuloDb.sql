CREATE DATABASE ArticuloDb
GO
USE ArticuloDb
GO

CREATE TABLE Articulos
(
ArticuloID int primary Key identity,
Descripcion varchar(30) NOT NULL,
Precio float,
Existencia int,
CantidadCotizada int,
FechaVencimiento datetime

);