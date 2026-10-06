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
    public partial class miPrimerAplicacion : System.Windows.Forms.Form
    {
        public miPrimerAplicacion()
        {
            InitializeComponent();
        }

        private void miPrimerAplicacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void miPrimerAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau ..");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (txb1.Text == "") txb1.BackColor = Color.Red;
            else txb1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void miPrimerAplicacion_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presionaste el botón Izquierdo", "Atención");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presionaste el Botón Derecho", "Atención");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presionaste el botón del Medio", "Atención");
            }
        }

        private void lbl1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl1.BackColor = Color.Cyan;
            lbl1.Cursor = Cursors.Hand;

        }
        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.BackColor = System.Drawing.SystemColors.Control;
            lbl1.Cursor = Cursors.Arrow;
        }

        private void txb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) e.Handled = true;
        }

        private void txb2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txb2.Text.Length + " Caracteres");
        }
    }
}