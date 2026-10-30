use master
go
create database POKEDEX_DB
go
use POKEDEX_DB
go

/****** Object:  Table [dbo].[ELEMENTOS] ******/
CREATE TABLE [dbo].[ELEMENTOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_ELEMENTOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO

/****** Object:  Table [dbo].[POKEMONS] ******/
CREATE TABLE [dbo].[POKEMONS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[UrlImagen] [varchar](1000) NULL,
	[IdTipo] [int] NULL,
	[IdDebilidad] [int] NULL,
	[Activo] [bit] DEFAULT 1,
 CONSTRAINT [PK_POKEMONS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO

-- Inserción de Elementos iniciales
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Fuego')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Agua')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Planta')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Eléctrico')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Normal')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Fantasma')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Veneno')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Bicho')
INSERT INTO ELEMENTOS (Descripcion) VALUES ('Psíquico')
GO

-- Inserción de Pokemons iniciales
-- IdTipo e IdDebilidad referencian al Id de la tabla ELEMENTOS
-- Campo Activo en 1 (True) para el manejo de baja lógica que enseña más adelante
INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) 
VALUES (1, 'Bulbasaur', 'Este Pokémon nace con una semilla en el lomo, que brota con el paso del tiempo.', 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png', 3, 1, 1)

INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) 
VALUES (4, 'Charmander', 'Prefiere las cosas calientes. Dicen que cuando llueve le sale vapor de la punta de la cola.', 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png', 1, 2, 1)

INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) 
VALUES (7, 'Squirtle', 'Cuando retrae su largo cuello en el caparazón, dispara agua a una presión increíble.', 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png', 2, 3, 1)

INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) 
VALUES (25, 'Pikachu', 'Cuando se enfada, descarga de forma inmediata la energía acumulada en sus mejillas.', 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png', 4, 3, 1)

INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo)
VALUES (143, 'Snorlax', 'No está satisfecho hasta que ingiere 400 kg de comida cada día. Al terminar, se duerme.', 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/143.png', 5, 1, 1)
GO
