USE emociones_libros;

SHOW tables;
select * from tabla_emociones;
#Valores de la tabla emociones
 INSERT INTO tabla_emociones (nombre_emocion)
VALUES 
	("Alegría"),
    ("Tristeza"),
    ("Miedo"),
    ("Ansiedad"),
    ("Nostalgia");   
    
 #Valores de la tabla libros   
INSERT INTO tabla_libros (titulo_libro, autor_libro, descripción, id_emociones)
VALUES 
	('Ana la de Tejas Verdes', 'Lucy Maud Montgomery', 'Una historia de una joven huerfana
		que llega a cambiar la vida de dos hermanos y un pequeño pueblo.', 1),
	('La casa en el mar más azul', 'TJ Klune', 'Linus Baker, un funcionario del Departamento de Jóvenes
		Mágicos, es enviado a una isla para supervisar un orfanato con seis niños mágicos 
        considerados peligrosos. Allí conocerá a su misterioso cuidador y enfrentará 
        sus propios miedos y prejuicios.', 2),
	('El caballero de la armadura oxidad', ' Robert Fisher', 'El caballero de la armadura oxidada narra la historia 
		de un caballero que queda atrapado en su armadura por usarla durante años, alejándose de su esposa y su hijo. 
        Para liberarse, emprende un viaje lleno de desafíos y aprendizajes que lo llevarán al autoconocimiento.Con la 
        ayuda de nuevos amigos, aprenderá a reconocer sus emociones y descubrir su verdadero ser.', 3),
	('Aquí no hay nada que ver', 'Kevin Wilson', 'Lillian, una joven infeliz y sin motivación para cambiar su vida,
		recibe una propuesta de trabajo de su amiga de la infancia, Madison. Aunque no tiene experiencia como niñera,
        deberá cuidar a los hijastros de Madison, quienes esconden un extraño secreto. Los niños tienen la peculiaridad 
        de que, ocasionalmente, ¡estallan en llamas!', 4),
	('La emoción de las cosas', 'Ángeles Mastretta', 'La emoción de las cosas es un canto de sirena que recupera el gozo
		casi infantil por escuchar historias, por descubrir otra forma de mirar la realidad, por reconocer aquellos fragmentos
        vitales acerca de la pasión, del asombro, de la emoción de las cosas.',5);
    
