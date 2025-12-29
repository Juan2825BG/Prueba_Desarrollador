CREATE DATABASE GestionBiblioteca;
GO

USE GestionBiblioteca;
GO

CREATE TABLE Autores (
    AutorID INT PRIMARY KEY IDENTITY(1,1), 
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Libros (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    AutorID INT NOT NULL,
    
    CONSTRAINT FK_Libros_Autores FOREIGN KEY (AutorID) 
    REFERENCES Autores(AutorID)
);

INSERT INTO Autores (Nombre) 
VALUES 
('Isaac Asimov'),       
('William Gibson'),     
('Frank Herbert');      
GO

INSERT INTO Libros (Titulo, AutorID) VALUES 
('Fundación', 1),
('Yo, Robot', 1),
('Neuromante', 2);
GO

