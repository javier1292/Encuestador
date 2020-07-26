using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
    public class Bdconexion
    {
        public object acceso;
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-UPF8V7O;DataBase=Encuestas;Integrated Security=true");

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

        public void Insertar(string nombre, string apellido, string nombre_usuario, string contraseña, string confirmar_contraseña)
        {
            throw new NotImplementedException();
        }

        public void Login(string usuario, string contraseña)
        {
            throw new NotImplementedException();
        }
    }
}
