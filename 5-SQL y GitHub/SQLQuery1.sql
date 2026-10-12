-- Consultas SQL

-- LEER:

--Select * From TIPOSEDICION
--Select * From DISCOS
Select D.Titulo, D.CantidadCanciones, E.Descripcion Estilo From DISCOS D, ESTILOS E
Where D.IdEstilo = E.Id

--Select * From ESTILOS

--Select * From DISCOS Where IdEstilo = 2 AND CantidadCanciones = 12

-- ESCRIBIR:
Insert into DISCOS (Titulo, CantidadCanciones)
values ('El titulo...', 10)
--
Insert into DISCOS values
('El titulo...', getdate(), 10, 'qwe', 1, 2)

-- MODIFICAR:
Update ESTILOS set Descripcion = 'Country' where id = 1

-- ELIMINAR:
Delete from DISCOS where CantidadCanciones = 10