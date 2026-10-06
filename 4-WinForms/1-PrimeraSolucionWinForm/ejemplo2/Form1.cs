using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lvElementos.Items.Add(elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;

            // Operador ternario: equivalente a una decisión if/else expresada en una línea.
            string chocolate = ckbChocolate.Checked == true
                ? "Le gusta el chocolate"
                : "No le gusta el chocolate";

            string tipo;

            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            // SelectedItem devuelve el elemento seleccionado del ComboBox.
            // Como en este ejemplo cargamos strings, lo transformamos a string.
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = $"{chocolate} - Es {tipo} - Su Color Favorito es: {colorFavorito} - Su Número Favorito es: {numeroFavorito}";

            MessageBox.Show($"Nombre: {nombre} - Fecha de Nacimiento: {fecha} - {mensaje}");
        }
    }
}