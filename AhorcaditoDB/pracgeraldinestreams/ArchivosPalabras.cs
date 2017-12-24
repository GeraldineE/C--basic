using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace PracGeraldineStreams
{
    class ArchivosPalabras
    {
        public static string[] leerPalabras()
        {


            if (System.IO.File.Exists(@"PalabrasAhorcado.txt"))
            {
                string[] Filelines = System.IO.File.ReadAllLines(@"PalabrasAhorcado.txt");
                return Filelines;
            }
            else
                return null;
        }

        public static string cargarPalabra()
        {
            if (System.IO.File.Exists(@"PalabrasAhorcado.txt"))
            {
                string[] Filelines = System.IO.File.ReadAllLines(@"PalabrasAhorcado.txt");
                int cuantas = Filelines.Length-1;
                Random r = new Random(); //cargar la clase aleatoria
                int posicionAleatoria = r.Next(cuantas);
                string palabraSeleccionada = Filelines[posicionAleatoria];
                return palabraSeleccionada;
            }
            else
                return null;
        }

       public static string cargarPalabraDB()
        {
             var connString = ConfigurationManager.ConnectionStrings["DBAhorcaditoConnectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new System.Data.SqlClient.SqlCommand(@"SELECT palabra FROM Palabras", conn);
            da.Fill(ds, "Palabras");
            dt = ds.Tables["Palabras"];

            int cuantas = dt.Rows.Count;
            Random r = new Random();
            int posicionAleatoria = r.Next(cuantas);

            int pos = 1;
            foreach (DataRow dr in dt.Rows)
            {
                pos = pos + 1;
                if (pos == posicionAleatoria) 
                    return dr["palabra"].ToString();
            }
            return null;
        }

        public static void nuevasPalabras(string nuevaPal)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"PalabrasAhorcado.txt", true))
            {
                file.WriteLine(nuevaPal);
            }
        }

        public static bool PalabrasExiste(string newPalabras)
        {
            if (!System.IO.File.Exists(@"PalabrasAhorcado.txt")) return false;

            string[] registros = leerPalabras();
            foreach (string palabra in registros)
            {
               string[] regPal= palabra.Split(new char[] {';'});

                if (regPal[0] == newPalabras) return true;

            }
            return false;
        }
    }
}
