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
    public partial class FormListarPalabras : Form
    {
        public FormListarPalabras()
        {
            InitializeComponent();
        }





        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormListarPalabras_Load(object sender, EventArgs e)
        {
            string[] lista = ArchivosPalabras.leerPalabras();
            if (lista != null)
            {
                foreach (string reg in lista)
                {
                    string[] palabra = reg.Split(new char[] { ';' });
                    string mostrar = palabra[0];
                    listPalabras.Items.Add(mostrar);
                }
            }
            else
            {
                listPalabras.Items.Add("No hay palabras registradas");
            }
        }

        private void listPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
