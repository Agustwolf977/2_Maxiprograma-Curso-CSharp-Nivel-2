using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool datosCorrectos = true;

            if (txbApellido.Text == "")
            {
                txbApellido.BackColor = Color.Red;
                datosCorrectos = false;
            }
            else
            {
                txbApellido.BackColor = Color.White;
            }

            if (txbNombre.Text == "")
            {
                txbNombre.BackColor = Color.Red;
                datosCorrectos = false;
            }
            else
            {
                txbNombre.BackColor = Color.White;
            }

            if (txbEdad.Text == "")
            {
                txbEdad.BackColor = Color.Red;
                datosCorrectos = false;
            }
            else
            {
                txbEdad.BackColor = Color.White;
            }

            if (txbDireccion.Text == "")
            {
                txbDireccion.BackColor = Color.Red;
                datosCorrectos = false;
            }
            else
            {
                txbDireccion.BackColor = Color.White;
            }
        

            if (datosCorrectos)
            {
                txbResultado.Text =
                    "Apellido y Nombre: " +
                    txbApellido.Text.ToUpper() + " " +
                    txbNombre.Text.ToUpper() +
                    Environment.NewLine +
                    "Edad: " + txbEdad.Text.ToUpper() +
                    Environment.NewLine +
                    "Dirección: " + txbDireccion.Text.ToUpper();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}