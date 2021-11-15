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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicativo para la solucion de ecuaciones lineales.\nDesarrollado por: Christian David Avendaño Mora y Gina Alexandra Reyes Motato\nTrabajo para la asignatura de Métodos Numéricos, impartida por Juan Carlos Cruz A.", "ACERCA DE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.SelectedIndex.Equals(-1))
                MessageBox.Show("Por favor, seleccione una opción válida", "Upps!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cmbOpciones.SelectedIndex.Equals(0))
            {
                Form2 Opcion1 = new Form2();
                Opcion1.ShowDialog();
            };

            if (cmbOpciones.SelectedIndex.Equals(1))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(2))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(3))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(4))
                MessageBox.Show("Por favor, seleccione una opción válida", "Upps!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cmbOpciones.SelectedIndex.Equals(5))
            {

            };


            if (cmbOpciones.SelectedIndex.Equals(6))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(7))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(8))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(9))
                MessageBox.Show("Por favor, seleccione una opción válida", "Upps!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cmbOpciones.SelectedIndex.Equals(10))
            {

            };

            if (cmbOpciones.SelectedIndex.Equals(11))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(12))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(13))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };

            if (cmbOpciones.SelectedIndex.Equals(14))
            {
                /*Form3 Opcion1 = new Form3();
                Opcion1.ShowDialog();*/
            };


        }
    }
}
