using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracGeraldineStreams
{
    static class ArchivoUsuarios
    {
        //Leer todos los registros del archivo en un arreglo.
        public static string[] leerUsuarios()
        {
            //si el archivo existe, se leen todos los registros
            if (System.IO.File.Exists(@"GerUsuarios.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"GerUsuarios.txt");
                return lines;
            }
            else
                return null;
        }

        //Crear un usuario a partir de tres campos, y escribirlo al final del archivo
        public static void crearUsuario(string nombre, string email, string clave)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"GerUsuarios.txt", true)) 
            {
                //los campos en el archivo de texto se separan por ; (punto y coma)
                file.WriteLine(email+";"+nombre+";"+clave+";"+"0");
            }
        }


        //Buscar en el archivo a ver si existe un usuario. la clave es el email
        public static bool UsuarioExiste(string email)
        {
            //si aun no existe archvo de usuarios, no existe el usuario
            if (!System.IO.File.Exists(@"GerUsuarios.txt")) return false;

            //leer todos los registros en un arreglo
            string[] registros = leerUsuarios();

            //recorrer los registros buscando si existe un email igual
            foreach (string usuario in registros)
            {
                //separar los campos. El separador es ; (punto y coma)
                string[] reg = usuario.Split(new char[] { ';' });

                // si algún registro tiene un email igual al buscado, es porque existe
                if (reg[0] == email) return true;
            }
            return false;
        }
    }
}
