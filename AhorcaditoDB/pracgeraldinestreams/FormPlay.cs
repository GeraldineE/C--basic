using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace PracGeraldineStreams
{
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();
        }
        bool gana = false;
        bool pierde = false;
        int errores = 0;
        int exitos = 0;
        string adivinadas = String.Empty;
        private void FormPlay_Load(object sender, EventArgs e)
        {
            labelLetrasJugadas.Text = string.Empty;
            labelPalabraOculta.Visible = false;
            labelPalabraOculta.Text = String.Empty;
            string palabra = ArchivosPalabras.cargarPalabraDB();//palabra sera igual a una palabra seleccionada del archivo
            if (String.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("No se pudo extraer una palabra del archivo de palabras. \nLa pantalla de juego no se abrirá.", "Palabras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                //Si la palabra si se extrajo del archivo, esa palabra que se extrajo la lleva ala ubicacion al label de palabra oculta
                labelPalabraOculta.Text = palabra;
                foreach (char c in palabra)
                {
                    labelLetrasJugadas.Text += "_ "; //crea los espacios en el label 
                }
                MessageBox.Show("Una palabra fue cargada.\nUse las teclas del teclado para sugerir letras en la palabra. \nEl jugador actual es "+this.Text, "Juegue!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormPlay_KeyDown(object sender, KeyEventArgs e)
        {
            //if (gana)
            //    MessageBox.Show("FELICITACINES GANASTE!!!.");
            //else
            //    if (pierde)
            //    MessageBox.Show("GAME OVER!! PERDISTE!!! sal y vuelve a intentarlo");
            //string c = Convert.ToChar(e.KeyData).ToString().ToLower(); //letra que sera ingresada por teclado
            //string palabra = labelPalabraOculta.Text.ToLower();
            //string palabraVisible = labelLetrasJugadas.Text.ToLower();
            //if (palabra.Contains(c)) //si la letra ingresada existe en palabra 
            //{
            //    if (!adivinadas.Contains(c)) //si la letra existe en la palabra adivinada 
            //    {
            //        for (int pos = 0; pos < palabra.Length; pos++) //recorre el tamaño de la palabra
            //        {
            //            if (palabra[pos].ToString() == c)//si la posicion de esa palabra es igual a la letra digitada
            //            {
            //                adivinadas += c;//adivinadas aumenta y los existos tambien aumenta de a 1
            //                exitos++;
            //                string parteAdivinada = c + " ";//ubica la letra de la palabra adivinada 
            //                if (pos == 0)
            //                    palabraVisible = parteAdivinada + palabraVisible.Substring(2);
            //                else
            //                {
            //                    string parteIzq = palabraVisible.Substring(0, (pos) * 2);
            //                    string parteDer = palabraVisible.Substring((pos + 1) * 2);
            //                    palabraVisible = parteIzq + parteAdivinada + parteDer;
            //                }
            //            }
            //        }
            //        labelLetrasJugadas.Text = palabraVisible;
            //        if (exitos == palabra.Length)
            //        {
            //            MessageBox.Show("TU GANAS!!!.", "AHORCADITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            gana = true;
            //        }
            //    }
            //}
            //else
            //{
            //    errores++;
            //    if (errores == 1) label1.Visible = true;
            //    if (errores == 2) label2.Visible = true;
            //    if (errores == 3) label3.Visible = true;
            //    if (errores == 4) label4.Visible = true;
            //    if (errores == 5) label5.Visible = true;
            //    if (errores == 6) label6.Visible = true;
            //    if (errores == 6)
            //    {
            //        label6.Visible = true;
            //        MessageBox.Show("TU PIERDES!!!.", "AHORCADITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        labelPalabraOculta.Visible = true;
            //        pierde = true;
            //    }
            //}
        }

        private void labelLetrasJugadas_Click(object sender, EventArgs e)
        {

        }

        private void labelPalabraOculta_Click(object sender, EventArgs e)
        {

        }

        private void buttonLetra_Click(object sender, EventArgs e)
        {
            Button presionado = (Button)sender;
            String c = presionado.Text.ToLower();
            if (gana)
                MessageBox.Show("FELICITACINES GANASTE!!!.");
            else
                if (pierde)
                    MessageBox.Show("GAME OVER!! PERDISTE!!! sal y vuelve a intentarlo");
            string palabra = labelPalabraOculta.Text.ToLower();
            string palabraVisible = labelLetrasJugadas.Text.ToLower();
            if (palabra.Contains(c)) //si la letra ingresada existe en palabra 
            {
                if (!adivinadas.Contains(c)) //si la letra existe en la palabra adivinada 
                {
                    for (int pos = 0; pos < palabra.Length; pos++) //recorre el tamaño de la palabra
                    {
                        if (palabra[pos].ToString() == c)//si la posicion de esa palabra es igual a la letra digitada
                        {
                            adivinadas += c;//adivinadas aumenta y los existos tambien aumenta de a 1
                            exitos++;
                            string parteAdivinada = c + " ";//ubica la letra de la palabra adivinada 
                            if (pos == 0)
                                palabraVisible = parteAdivinada + palabraVisible.Substring(2);
                            else
                            {
                                string parteIzq = palabraVisible.Substring(0, (pos) * 2);
                                string parteDer = palabraVisible.Substring((pos + 1) * 2);
                                palabraVisible = parteIzq + parteAdivinada + parteDer;
                            }
                        }
                    }
                    labelLetrasJugadas.Text = palabraVisible;
                    if (exitos == palabra.Length)
                    {
                        MessageBox.Show("TU GANAS!!!.", "AHORCADITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gana = true;

                        int posPuntaje = this.Text.IndexOf(":");
                        string nombreUsuario = this.Text.Substring(0,posPuntaje);
                        int puntos = 100;
                        darPuntaje(nombreUsuario,puntos);
                    }
                }
            }
            else
            {
                errores++;
                if (errores == 1) label1.Visible = true;
                if (errores == 2) label2.Visible = true;
                if (errores == 3) label3.Visible = true;
                if (errores == 4) label4.Visible = true;
                if (errores == 5) label5.Visible = true;
                if (errores == 6) label6.Visible = true;
                if (errores == 6)
                {
                    label6.Visible = true;
                    MessageBox.Show("TU PIERDES!!!.", "AHORCADITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelPalabraOculta.Visible = true;
                    pierde = true;
                }
            }
        }

        private void darPuntaje(string nombreJugador, int puntosPorGanar)
        {
            var connString = ConfigurationManager.ConnectionStrings["DBAhorcaditoConnectionString"].ConnectionString;//se conecta a la bases??
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString);//que hace cada parte de linea de codigo?
            conn.Open();//abre la conexión
            string querystr = "UPDATE Usuarios SET puntaje=puntaje + " + puntosPorGanar.ToString() + " WHERE nombre='" + nombreJugador + "'";
            System.Data.SqlClient.SqlCommand query = new System.Data.SqlClient.SqlCommand(querystr, conn);//que es qurystr?
            query.ExecuteNonQuery();// que hace la linea de codigo?
            conn.Close();//cierra la conexión
        }
    }
}  
