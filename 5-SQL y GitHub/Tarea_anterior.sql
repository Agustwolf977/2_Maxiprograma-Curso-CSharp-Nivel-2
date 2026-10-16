
/* A partir de la base de datos DISCOS_DB te propongo que realices las siguientes consultas SQL a modo de práctica:

1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo
   (no el id, sino la descripción).

2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

3. Insertar al menos dos discos nuevos cargando correctamente su información.

4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.

5. Borrar un disco a elección.

6. Traer todos los estilos que estén asociados a algún disco.

7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

8. Traer todos los discos que contengan en su nombre la sílaba "ho". */


SELECT D.Titulo, D.FechaLanzamiento, E.Descripcion FROM DISCOS D, ESTILOS E WHERE E.Id = D.IdEstilo

INSERT INTO ESTILOS (Descripcion)
VALUES ('Cumbia');
INSERT INTO ESTILOS (Descripcion)
VALUES ('Cachaca');
INSERT INTO TIPOSEDICION (Descripcion)
VALUES ('Cassette');

INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)
VALUES ('En Tu Piel', '20140328', 13, 'https://onlineradiobox.com/album/853428628-en-tu-piel', 5, 2)
INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)
VALUES ('Caramelito', '20071220', 15, 'https://music.apple.com/cr/album/caramelito/1709331252', 6, 2)

UPDATE DISCOS SET CantidadCanciones = 16 WHERE id = 4

DELETE FROM DISCOS WHERE Id = 1;

SELECT E.Descripcion FROM ESTILOS E, DISCOS D WHERE E.Id = D.IdEstilo

SELECT Titulo, IdEstilo, IdTipoEdicion FROM DISCOS

SELECT * FROM DISCOS WHERE Titulo LIKE '%ho%';