
using System.Collections.Generic;
using System.Data.SqlClient;

namespace winform_app
{
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();

            string connectionString =
                "Server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand())
            {
                comando.CommandText =
                    "SELECT Numero, Nombre, P.Descripcion, UrlImagen, " +
                    "E.Descripcion AS Tipo, D.Descripcion AS Debilidad " +
                    "FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D " +
                    "WHERE E.Id = P.IdTipo " +
                    "AND D.Id = P.IdDebilidad";

                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Pokemon aux = new Pokemon();

                        aux.Numero = lector.GetInt32(0);
                        aux.Nombre = (string)lector["Nombre"];
                        aux.Descripcion = (string)lector["Descripcion"];
                        aux.UrlImagen = (string)lector["UrlImagen"];

                        aux.Tipo = new Elemento();
                        aux.Tipo.Descripcion = (string)lector["Tipo"];

                        aux.Debilidad = new Elemento();
                        aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                        lista.Add(aux);
                    }
                }
            }

            return lista;
        }
    }
}