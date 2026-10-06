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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            // Value devuelve un DateTime.
            DateTime fecha1 = dtpFecha.Value;

            // Conservamos el valor como DateTime.
            // La conversión a string se hace únicamente para mostrarlo.
            MessageBox.Show($"La Fecha Seleccionada es: {fecha1.ToString("dd/MM/yyyy")}");
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            // MonthCalendar permite trabajar con un rango de fechas.
            // SelectionStart devuelve el comienzo de la selección.
            DateTime fechaInicio = calFecha.SelectionStart;

            // SelectionEnd devuelve el final del rango seleccionado.
            DateTime fechaFin = calFecha.SelectionEnd;

            MessageBox.Show($"Inicio: {fechaInicio.ToString("dd/MM/yyyy")} - " + $"Fin: {fechaFin.ToString("dd/MM/yyyy")}");
        }
    }
}