using conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encuesta
{
    public class Class1
    {
        private Bdconexion objetocd = new Bdconexion();


        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private object acceso;

        public void Insertar(string Nombre, String apellido, String usuario, string contra, string confirmar)
        {
            objetocd.Insertar(Nombre, apellido, usuario, contra, confirmar);


        }

        public void Login(string Usuario, string Contraseña)
        {

            objetocd.Login(Usuario, Contraseña);
            acceso = objetocd.acceso;

        }
    }
}
