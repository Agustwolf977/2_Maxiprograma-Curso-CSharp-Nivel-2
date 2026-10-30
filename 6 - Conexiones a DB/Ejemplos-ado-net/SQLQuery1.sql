



SELECT * FROM ELEMENTOS

SELECT * FROM POKEMONS

SELECT Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion AS Tipo, D.Descripcion AS Debilidad
FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D
WHERE E.Id = P.IdTipo
AND D.Id = P.IdDebilidad


UPDATE POKEMONS SET UrlImagen = '' WHERE Numero = 143