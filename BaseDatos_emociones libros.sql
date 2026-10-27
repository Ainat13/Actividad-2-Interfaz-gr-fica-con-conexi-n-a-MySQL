#CREATE DATABASE emociones_libros; //Se crea la BD

USE emociones_libros; # Para guardar las tablas en la base de datos

#Crear tabla de Libros
CREATE TABLE tabla_emociones (
	id_emociones INT AUTO_INCREMENT PRIMARY KEY,
    nombre_emocion VARCHAR (150) NOT NULL
    );

CREATE TABLE tabla_libros (
	id_libro INT AUTO_INCREMENT PRIMARY KEY,
	titulo_libro VARCHAR(150) NOT NULL,
	autor_libro VARCHAR (150) NOT NULL,
	descripción TEXT,
	id_emociones INT NOT NULL,
    FOREIGN KEY (id_emociones) 
		REFERENCES tabla_emociones(id_emociones)
);
