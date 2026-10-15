
-- ============================================================
-- CONSULTAS SQL - DISCOS_DB
-- Ejemplos de las operaciones básicas sobre una base de datos
-- ============================================================

USE DISCOS_DB;
GO

-- IMPORTANTE:
-- Los ejemplos INSERT, UPDATE y DELETE están comentados.
-- Para probarlos, seleccioná y ejecutá la instrucción deseada.
-- Antes de modificar datos, verificá la base seleccionada.


-- ============================================================
-- 1. LEER REGISTROS (SELECT)
-- ============================================================

-- Obtener todos los tipos de edición.
SELECT * FROM TIPOSEDICION;

-- Obtener todos los discos.
SELECT * FROM DISCOS;

-- Obtener todos los estilos.
SELECT * FROM ESTILOS;


-- ============================================================
-- 2. CONSULTAR VARIAS TABLAS
-- ============================================================

-- Obtener título, cantidad de canciones y nombre del estilo.
-- D y E son alias de las tablas.
-- WHERE establece la relación entre sus registros.

SELECT D.Titulo,
       D.CantidadCanciones,
       E.Descripcion AS Estilo
FROM DISCOS D, ESTILOS E
WHERE D.IdEstilo = E.Id;


-- ============================================================
-- 3. FILTRAR REGISTROS (WHERE)
-- ============================================================

-- Obtener los discos cuyo estilo sea 2 y tengan 12 canciones.

SELECT *
FROM DISCOS
WHERE IdEstilo = 2 AND CantidadCanciones = 12;


-- ============================================================
-- 4. INSERTAR REGISTROS (INSERT INTO)
-- ============================================================

-- Primera forma: especificando las columnas.
-- Las columnas omitidas deben admitir un valor predeterminado,
-- NULL o algún mecanismo de generación automática.

-- INSERT INTO DISCOS (Titulo, CantidadCanciones)
-- VALUES ('El titulo...', 10);


-- Segunda forma: sin especificar las columnas.
-- Los valores deben respetar el orden correspondiente.
-- GETDATE() obtiene la fecha y hora actuales del servidor.

-- INSERT INTO DISCOS
-- VALUES ('El titulo...', GETDATE(), 10, 'qwe', 1, 2);


-- ============================================================
-- 5. MODIFICAR REGISTROS (UPDATE)
-- ============================================================

-- Modificar la descripción del estilo con Id = 1.
-- ATENCIÓN: sin WHERE se modificarían todos los registros.

-- UPDATE ESTILOS
-- SET Descripcion = 'Country'
-- WHERE Id = 1;


-- ============================================================
-- 6. ELIMINAR REGISTROS (DELETE)
-- ============================================================

-- Consultar previamente qué registros serían eliminados.

SELECT *
FROM DISCOS
WHERE CantidadCanciones = 10;

-- Eliminar los discos que tengan exactamente 10 canciones.
-- ATENCIÓN: sin WHERE se intentarían eliminar todas las filas.

-- DELETE FROM DISCOS
-- WHERE CantidadCanciones = 10;