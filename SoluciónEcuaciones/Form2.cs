using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoluciónEcuaciones
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicativo para la solucion de ecuaciones lineales.\nDesarrollado por:\nChristian David Avendaño Mora\nGina Alexandra Reyes Motato\nTrabajo para la asignatura de Métodos Numéricos, impartida por Juan Carlos Cruz A.", "ACERCA DE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario 2");
        }
    }
}
