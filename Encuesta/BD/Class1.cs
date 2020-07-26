using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
   public  class Class1
    {


        public bool acceso;


        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string Nombre, String Apellido, String Usuario, string Contra, string Ccontra)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into usuarios values ('" + Nombre + "','" + Apellido + "','" + Usuario + "','" + Contra + "','" + Ccontra + "')";

            comando.ExecuteNonQuery();



        }

        public void EliminarE(int ID_Encuesta)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EliminarEncuesta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEncuesta", ID_Encuesta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarP(int ID_Pregunta)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "ElimarP";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdP", ID_Pregunta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable MostrarMisEncuestas()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from encuestas where ID_usuario=" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarUsuarios()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select DISTINCT  r.ID_usuario, e.ID_encuesta from usuarios u inner join encuestas e on e.ID_usuario = u.ID_usuario inner join preguntas p on p.ID_encuesta = e.ID_encuesta inner join respuestas r on r.ID_pregunta = p.ID_pregunta where "+User.idEncuesta+" = p.ID_encuesta";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarUsuariosR()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select r.ID_pregunta, r.Respuesta from usuarios u inner join encuestas e on e.ID_usuario = u.ID_usuario inner join preguntas p on p.ID_encuesta = e.ID_encuesta inner join respuestas r on r.ID_pregunta = p.ID_pregunta where "+ User.idUser + " = r.ID_usuario and "+User.idEncuesta + " = e.ID_encuesta";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarEncuestas()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from encuestas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarPreguntas()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from preguntas where ID_encuesta=" + User.idEncuesta;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarMisPreguntas()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from preguntas where ID_encuesta=" + User.idEncuesta;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public void InsertarEncuesta(string NombreEncuesta)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into encuestas values ("+ User.user +" , '" + NombreEncuesta + "')";

            comando.ExecuteNonQuery();



        }

        public void InsertarP(string Pregunta)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into preguntas values (" + User.idEncuesta + " , '" + Pregunta + "')";

            comando.ExecuteNonQuery();



        }

        public void InsertarR(string Respuesta, string ID_pregunta)
        {
            int id_pregunta = Convert.ToInt32(ID_pregunta);
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into respuestas values (" + id_pregunta + " ," + User.user + " , '" + Respuesta + "')";

            comando.ExecuteNonQuery();



        }

        public void EditarE(int ID_Encuesta, string NombreEncuesta)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EditarE ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Idencuesta", User.user);
            comando.Parameters.AddWithValue("@nombreEncuesta", NombreEncuesta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }

        public void EditarP(int ID_Pregunta, string Pregunta)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EditarP ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdPregunta", ID_Pregunta);
            comando.Parameters.AddWithValue("@Pregunta", Pregunta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }


        public bool Login(string Usuario, string Contra)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "SELECT usuario, Contra FROM usuarios where Usuario='" + Usuario + "' And Contra='" + Contra + "'";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                acceso = true;
            }
            else
            {
                acceso = false;
            }

            Conexion.CerrarConexion();
            comando.Connection = Conexion.AbrirConexion();

            string query = "SELECT ID_usuario FROM usuarios where Usuario='" + Usuario + "' And Contra='" + Contra + "'";
            comando.CommandText = query;

            User.user = Convert.ToInt32(comando.ExecuteScalar());

            Conexion.CerrarConexion();


            return acceso;

        }
        public void idEnc(string idEnc) 
        {

            User.idEncuesta = Convert.ToInt32(idEnc);
        }
        public void idUser(string idUser)
        {

            User.idUser = Convert.ToInt32(idUser);
        }
    }
}
