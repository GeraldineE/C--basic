using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracGeraldineStreams
{
    public partial class JugarPalabras : Form
    {
        public JugarPalabras()
        {
            InitializeComponent();
        }

        private void JugarPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ArchivosPalabras.PalabrasExiste(txtAgPal.Text))
            {
                MessageBox.Show("La palabra '" + txtAgPal.Text + "' se encuentra registrado en el archivo de nuevas palabras", "Palabras",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Palabras = txtAgPal.Text;

                ArchivosPalabras.nuevasPalabras(Palabras);
                MessageBox.Show("La palabra fue guardada con exito", "Palabras",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form listarPal = new FormListarPalabras();
            listarPal.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
