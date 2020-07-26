using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
   public  class metodo {

        public bool acceso;

        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public void Insertar(string Nombre, String apellido, String usuario, string contra, string confirmar)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into rregistro values ('" + Nombre + "','" + apellido + "','" + usuario + "','" + contra + "','" + confirmar + "')";

            comando.ExecuteNonQuery();



        }
       

    }
}
