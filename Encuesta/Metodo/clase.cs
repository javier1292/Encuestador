using BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    public class clase
    {
        public bool acceso;
        public int ID_usuario;
        

        private Class1 objetocd = new Class1();

      

        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void EditarE(string NombreEncuesta, int ID_Encuesta)
        {

            objetocd.EditarE(ID_Encuesta, NombreEncuesta);

        }

        public void EditarP(string Pregunta, int ID_Pregunta)
        {

            objetocd.EditarP(ID_Pregunta, Pregunta);

        }

        public void Insertar(string Nombre, String Apellido, String Usuario, string Contra, string Ccontra)
        {
            objetocd.Insertar(Nombre, Apellido, Usuario, Contra, Ccontra);


        }
        public DataTable mostrar()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarMisEncuestas();
            return tabla;
        }
        public DataTable MostrarEncuestas()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarEncuestas();
            return tabla;
        }

        public DataTable MostrarUsuarios()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarUsuarios();
            return tabla;
        }
        
        public DataTable MostrarUsuariosR()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarUsuariosR();
            return tabla;
        }

        public DataTable mostrarP()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarMisPreguntas();
            return tabla;
        }
        public DataTable MostrarPreguntas()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarPreguntas();
            return tabla;
        }

        public void InsertarEncuesta(string NombreEncuesta)
        {
            objetocd.InsertarEncuesta(NombreEncuesta );


        }

        public void InsertarP(string Pregunta)
        {
            objetocd.InsertarP(Pregunta);


        }

        public void InsertarR(string Respuesta, string ID_pregunta)
        {
            objetocd.InsertarR(Respuesta, ID_pregunta);


        }

        public void Login(string Usuario, string Contra)
        {

            objetocd.Login(Usuario, Contra);
            acceso = objetocd.acceso;

        }
        public void idEnc(string idEnc)
        {
            objetocd.idEnc(idEnc);
        }
        public void idUser(string idUser)
        {
            objetocd.idUser(idUser);
        }

        public void EliminiarE(String ID_Encuesta)
        {

            objetocd.EliminarE(Convert.ToInt32(ID_Encuesta));

        }

        public void EliminiarP(String ID_Pregunta)
        {

            objetocd.EliminarP(Convert.ToInt32(ID_Pregunta));

        }
    }
}
