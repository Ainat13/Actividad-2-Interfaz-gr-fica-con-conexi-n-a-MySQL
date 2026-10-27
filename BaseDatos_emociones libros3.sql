SELECT * FROM tabla_emociones;
SELECT * FROM tabla_libros;

#Verificar que coincidan las 2 tablas
SELECT
    l.id_libro,
    l.titulo_libro,
    l.autor_libro,
    l.descripción,
    e.nombre AS emocion
FROM tabla_libros AS l
INNER JOIN tabla_emociones AS e
    ON l.id_emociones = e.id_emocion;