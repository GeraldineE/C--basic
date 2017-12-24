using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class ReservaAvionn : Form
    {
        public ReservaAvionn(int cantPasajeros)
        {
            this.cantPasajeros = cantPasajeros;
            InitializeComponent();
        }

        public int cantPasajeros;

        Reservas NPasajeros = new Reservas();
        int pasajeros;


        

        private void ReservaAvionn_Load(object sender, EventArgs e)
        {

            pasajeros = NPasajeros.cantidadPasajeros;
          //  MessageBox.Show(this.cantPasajeros + "");
            int[] vector = mandar(this.cantPasajeros);
           txtCuarenta.Text = Convert.ToString(vector[0]);
            txtOchenta.Text  = Convert.ToString(vector[1]);
            txtOcup4.Text = Convert.ToString(vector[2]);
            txtOcup8.Text = Convert.ToString(vector[3]);
        }

        /// <summary>
        /// ///
        /// </summary>
        /// <returns></returns>
        public int[] mandar(int CPasaeros)
        {
            int[] vector = new int[4];

            //int CPasaeros = pasajeros, Modulo = CPasaeros % 80, Division = CPasaeros / 80;
            //MessageBox.Show(CPasaeros + "");
            if (CPasaeros <= 40)
            {
                vector[0] = 1;
                vector[1] = 0;
                vector[2] = CPasaeros;
                vector[3] = 0;
            } else
                if (CPasaeros > 40 && CPasaeros <= 80)
                {
                    vector[0] = 0;
                    vector[1] = 1;
                    vector[2] = 0;
                    vector[3] = CPasaeros;

                }else
                    if (CPasaeros > 80)
                    {
                        int AvionesOchenta = CPasaeros / 80;
                      
                        vector[1] = AvionesOchenta;
                        vector[3] = AvionesOchenta * 80;
                        if (CPasaeros % 80 != 0)
                        {
                            if (CPasaeros % 80 <= 40)
                            {
                                vector[0] = 1;
                                vector[2] = CPasaeros % 80;

                            }
                            else
                            {
                                vector[0] = 0;
                                vector[1] = AvionesOchenta + 1;
                                vector[2] = 0;
                                vector[3] = vector[3] + CPasaeros % 80;
                            }
                        }
                        else
                        {
                            vector[0] = 0;
                            vector[2] = 0;
                        }

                    }

            return vector;
             
        }

        private void txtAviones_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
