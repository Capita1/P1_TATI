CREATE DATABASE onu;
USE onu;
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    data DATE NOT NULL,
    pais VARCHAR(100) NOT NULL,
    org VARCHAR(100) NOT NULL,
    sexo ENUM('M', 'F') NOT NULL,
    foto VARCHAR(100) NOT NULL
);
