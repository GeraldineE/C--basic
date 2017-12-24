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
    public partial class FormListaPuntajes : Form
    {
        public FormListaPuntajes()
        {
            InitializeComponent();
        }

        private void FormListaPuntajes_Load(object sender, EventArgs e)
        {
            string[] lista = ArchivoUsuarios.leerUsuarios();
            if (lista != null)
            {
                foreach (string reg in lista)
                {
                    string[] usuario = reg.Split(new char[] { ';' });
                    string mostrar = usuario[0] + " /  Puntaje = " + usuario[3];
                    listBox1.Items.Add(mostrar);
                }
            }
            else
            {
                listBox1.Items.Add("No hay usuarios registrados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
