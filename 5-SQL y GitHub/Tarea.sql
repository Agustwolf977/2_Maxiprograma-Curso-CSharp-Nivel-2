
-- ============================================================
-- TAREA SQL - DISCOS_DB
-- Ejercicios prácticos sobre consultas y modificación de datos
-- ============================================================

USE DISCOS_DB;
GO

-- IMPORTANTE:
-- Los ejercicios que modifican datos están comentados.
-- Para realizarlos, descomentá y ejecutá cada instrucción
-- individualmente y en el orden de las consignas.
--
-- Los Id utilizados en los ejercicios 4 y 5 suponen que la
-- base tenía solamente los registros originales del script
-- antes de realizar las inserciones de esta tarea.


-- ============================================================
-- 1. Traer todos los discos con su respectivo estilo.
-- Mostrar nombre del disco, fecha de lanzamiento y estilo
-- (la descripción, no el identificador).
-- ============================================================

SELECT D.Titulo,
       D.FechaLanzamiento,
       E.Descripcion AS Estilo
FROM DISCOS D, ESTILOS E
WHERE D.IdEstilo = E.Id;


-- ============================================================
-- 2. Insertar al menos dos estilos nuevos y un tipo de edición.
-- ============================================================

-- INSERT INTO ESTILOS (Descripcion)
-- VALUES ('Cumbia');

-- INSERT INTO ESTILOS (Descripcion)
-- VALUES ('Cachaca');

-- INSERT INTO TIPOSEDICION (Descripcion)
-- VALUES ('Cassette');


-- ============================================================
-- 3. Insertar al menos dos discos con sus datos completos.
-- ============================================================

-- Los IdEstilo 5 y 6 corresponden a los estilos recién
-- insertados si partimos de la base original sin cambios.
-- Las URL son páginas de álbumes y no imágenes directas.

-- INSERT INTO DISCOS
-- (Titulo, FechaLanzamiento, CantidadCanciones,
--  UrlImagenTapa, IdEstilo, IdTipoEdicion)
-- VALUES
-- ('En Tu Piel', '20140328', 13,
--  'https://onlineradiobox.com/album/853428628-en-tu-piel',
--  5, 2);

-- INSERT INTO DISCOS
-- (Titulo, FechaLanzamiento, CantidadCanciones,
--  UrlImagenTapa, IdEstilo, IdTipoEdicion)
-- VALUES
-- ('Caramelito', '20071220', 15,
--  'https://music.apple.com/cr/album/caramelito/1709331252',
--  6, 2);


-- ============================================================
-- 4. Actualizar un disco modificando cantidad de canciones
--    Y fecha de lanzamiento. No olvidar WHERE.
-- ============================================================

-- CORRECCIÓN:
-- Antes solamente modificábamos CantidadCanciones.
-- Ahora también modificamos FechaLanzamiento.
-- La fecha indicada es un ejemplo de práctica.

-- UPDATE DISCOS
-- SET CantidadCanciones = 16,
--     FechaLanzamiento = '20071221'
-- WHERE Id = 4;


-- ============================================================
-- 5. Borrar un disco a elección.
-- ============================================================

-- Consultar primero el registro elegido.

SELECT * FROM DISCOS WHERE Id = 1;

-- Eliminar el registro seleccionado.

-- DELETE FROM DISCOS
-- WHERE Id = 1;


-- ============================================================
-- 6. Traer todos los estilos asociados a algún disco.
-- ============================================================

-- CORRECCIÓN:
-- DISTINCT evita devolver repetidamente un mismo estilo.

SELECT DISTINCT E.Descripcion AS Estilo
FROM ESTILOS E, DISCOS D
WHERE E.Id = D.IdEstilo;


-- ============================================================
-- 7. Traer todos los discos con el formato:
--    Nombre, Estilo, Edición (todo texto).
-- ============================================================

-- CORRECCIÓN:
-- Se relacionan las tres tablas para obtener descripciones
-- en lugar de identificadores numéricos.

SELECT D.Titulo AS Nombre,
       E.Descripcion AS Estilo,
       T.Descripcion AS Edicion
FROM DISCOS D, ESTILOS E, TIPOSEDICION T
WHERE D.IdEstilo = E.Id
  AND D.IdTipoEdicion = T.Id;


-- ============================================================
-- 8. Traer todos los discos que contengan "ho" en su nombre.
-- ============================================================

SELECT *
FROM DISCOS
WHERE Titulo LIKE '%ho%';