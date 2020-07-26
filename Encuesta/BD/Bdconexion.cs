using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Bdconexion
    {
     
            private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-UPF8V7O;DataBase=Encuesta;Integrated Security=true");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;


            }

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;


            }


        
    }
}

