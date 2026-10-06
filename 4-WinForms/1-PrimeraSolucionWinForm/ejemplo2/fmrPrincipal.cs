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
    public partial class fmrPrincipal : System.Windows.Forms.Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Application.OpenForms contiene los formularios que están abiertos actualmente.
            foreach (var item in Application.OpenForms)
            {
                // GetType() obtiene el tipo real del objeto.
                // typeof(Form1) representa el tipo Form1.
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar allí...");

                    // Finaliza la ejecución del método para evitar abrir otra instancia.
                    return;
                }
            }

            Form1 ventana = new Form1();

            // Convierte esta ventana en hija MDI de la ventana actual (this).
            ventana.MdiParent = this;

            // Para una ventana hija MDI utilizamos Show().
            ventana.Show();
        }
    }
}