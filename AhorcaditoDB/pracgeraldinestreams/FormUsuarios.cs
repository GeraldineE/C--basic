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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArchivoUsuarios.UsuarioExiste(textBoxEmail.Text))
            {
                MessageBox.Show("El usuario con email '"+ textBoxEmail.Text + "' se encuentra registrado en el archivo de usuarios", "Usuarios", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre = TextBoxNombre.Text;
                string email = textBoxEmail.Text;
                string clave = textBoxClave.Text;
                string puntaje = "0";
                ArchivoUsuarios.crearUsuario(nombre, email, clave);
                MessageBox.Show("El usuario fue guardado","Usuario",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        } 
    }
}
