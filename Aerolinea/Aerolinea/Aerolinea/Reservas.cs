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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
          
        }

            public int cantidadPasajeros = 0;
            public int sumVuelo = 0;
  
          
        
            ReservasC misReservas = new ReservasC();
            List<ReservasC> ListaReservas = new List<ReservasC>();
            static Random numVuelo = new Random();
           

      




        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumVuelo.Text = numVuelo.Next(1000, 9000) + "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           //string cantPasajeros;
         /*
             misReservas = new ReservasC();
           //misReservas.txtNombre = txtNombre.Text;

            misReservas.Nombre = txtNombre.Text;
            misReservas.NumVuelo = txtNumVuelo.Text;
            misReservas.Apellido=txtApellido.Text;
            misReservas.Cedula = txtCedula.Text;
            misReservas.FechaNaci = txtFechaNaci.Text;
            misReservas.Destino = cmbDestino.Text;
            misReservas.HoraSalida = dateTimePicker1.Value;
            misReservas.NumPasajeros = txtNumPas.Text;

           ListaReservas.Add(misReservas);
            */
            ///////////VALIDACIONES DE LAS CAJAS DE TEXTO////////////////////
                     if (txtNombre.Text == "")
                     {
                         MessageBox.Show("El campo Nombre no puede ser vacío");
                         return;
                     }

                     if (txtApellido.Text == "")
                     {
                         MessageBox.Show("El campo Apellido no puede ser vacío");
                         return;
                     }

                     if (txtCedula.Text == "")
                     {
                         MessageBox.Show("El campo Cedula no puede ser vacío");
                         return;
                     }

                     if (txtFechaNaci.Text == "")
                     {
                         MessageBox.Show("El campo Fecha de Nacimiento no puede ser vacío");
                         return;
                     }

                     if (txtNumVuelo.Text == "")
                     {
                         MessageBox.Show("El campo Numero de vuelo no puede ser vacío");
                         return;
                     }
                     if (txtNumPas.Text == "")
                     {
                         MessageBox.Show("El campo Numero de pasajeros no puede ser vacío.");
                         return;
                     }
                     if ( dateTimePicker3.Value == null)
                     {
                         MessageBox.Show("Escoja una hora de vuelo");
                         return;
                     }

                    
            ///LLAMA EL OTRO FORM Y ASIGNA NUMERO DE PASAJEROS/////////////
                    
                   
                     ReservaAvionn OtroForm = new ReservaAvionn(cantidadPasajeros);
                     this.Hide();
                     OtroForm.ShowDialog();
                     this.Show();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cantPasajeros;
            cantPasajeros = (txtNumPas.Text);
            cantidadPasajeros +=  int.Parse(cantPasajeros);
        
            
            misReservas = new ReservasC();
       

            misReservas.Nombre = txtNombre.Text;
            misReservas.NumV = txtNumVuelo.Text;
            misReservas.NumVuelo = Convert.ToInt32(txtNumVuelo.Text);
            misReservas.Apellido = txtApellido.Text;
            misReservas.Cedula = txtCedula.Text;
            misReservas.FechaNaci = txtFechaNaci.Text;
            misReservas.Destino = cmbDestino.Text;
            misReservas.HoraSalida = dateTimePicker1.Value;
            misReservas.NumPasajeros = txtNumPas.Text;

          
            ListaReservas.Add(misReservas);

           
             

             txtNumVuelo.Text = numVuelo.Next(1000, 9000) + "";
        
               GRIDListadeAviones.Rows.Clear();

            /////////////RECORRE LA LISTA//////////////////
            for(int i=0; i< ListaReservas.Count; i++){
             GRIDListadeAviones.Rows.Add(
                 
                 ListaReservas[i].Nombre,
                 ListaReservas[i].Apellido,
                 ListaReservas[i].Cedula,
                 ListaReservas[i].FechaNaci,
                 ListaReservas[i].NumPasajeros,
                 ListaReservas[i].NumVuelo,
                 ListaReservas[i].Destino,
                 ListaReservas[i].HoraSalida,
                 dateTimePicker3.Value

                 );

            }

           
          //GRIDListadeAviones.Rows.Add(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtFechaNaci.Text, txtNumPas.Text, sumVuelo, cmbDestino.Text, dateTimePicker1.Value, dateTimePicker3.Value);
            
           

        }

        private void GRIDListadeAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
      











    }
}


