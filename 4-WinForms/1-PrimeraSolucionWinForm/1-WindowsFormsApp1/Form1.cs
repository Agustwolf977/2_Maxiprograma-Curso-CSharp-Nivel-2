using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    // Form1 hereda de Form, por eso posee el comportamiento de una ventana de WinForms.
    // partial permite que la misma clase Form1 esté dividida entre
    // Form1.cs y Form1.Designer.cs.
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Inicializa los controles y configuraciones creados desde el Diseñador.
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            // Los programas WinForms trabajan mediante eventos.
            // Este método se ejecuta cuando ocurre el evento Click del botón.

            //MessageBox.Show("HOLA MUNDO");

            string texto = txtNombre.Text;
            lblSaludo.Text = $"HOLA {texto}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Este método está asociado al evento FormClosing del formulario.

            //MessageBox.Show("Gracias por usar la app");
        }
    }
}