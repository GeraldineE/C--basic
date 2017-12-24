using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PracGeraldineStreams
{
    public partial class FormGerJugar : Form
    {
        public FormGerJugar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            Form crearUsr = new FormUsuario();
            crearUsr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //esta es la vieja forma de lista de usuarios y sus pnutajes
            //            Form listarUsr = new FormListaPuntajes();
            //listarUsr.Show();
            Form listarUsr = new FrmAdminUsuarios();
            listarUsr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form jugar = new FrmAdminPalagras();
            jugar.Show();
        }

        private void FormGerJugar_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            listBox1.Items.Clear();
            var connString = ConfigurationManager.ConnectionStrings["DBAhorcaditoConnectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new System.Data.SqlClient.SqlCommand(@"SELECT nombre, puntaje FROM Usuarios", conn);
            da.Fill(ds, "Usuarios");
            dt = ds.Tables["Usuarios"];

            foreach (DataRow dr in dt.Rows)
            {
                string nombre = dr["nombre"].ToString();
                string puntos = dr["puntaje"].ToString();
                string mostrar = nombre + ": " + puntos;
                listBox1.Items.Add(mostrar);
            }

        }
        private void btnPalabras_Click(object sender, EventArgs e)
        {
            Form listarPal = new FormListarPalabras();
            listarPal.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (label2.Text != string.Empty) {
                Form jugarA = new FormPlay();
                jugarA.Text = label2.Text;
                jugarA.Show();
        }
        else
                MessageBox.Show("Debe seleccionar un jugador");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listarUsuarios();
            label2.Text = String.Empty;
        }  
    }
}
