
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace winform_app
{
    public partial class fmPokemons : Form
    {
        private List<Pokemon> listaPokemon;

        public fmPokemons()
        {
            InitializeComponent();
        }

        private void fmPokemons_Load(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemon = negocio.listar();

                dgvPokemons.DataSource = listaPokemon;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los Pokémon.\n\n" +
                    "Detalle: " + ex.Message
                );
            }
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow == null)
            {
                pbxPokemon.Image = null;
                return;
            }

            Pokemon seleccionado =
                dgvPokemons.CurrentRow.DataBoundItem as Pokemon;

            if (seleccionado != null)
            {
                cargarImagen(seleccionado.UrlImagen);
            }
            else
            {
                pbxPokemon.Image = null;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imagen))
                {
                    pbxPokemon.Image = null;
                    return;
                }

                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbxPokemon.Image = null;
            }
        }
    }
}