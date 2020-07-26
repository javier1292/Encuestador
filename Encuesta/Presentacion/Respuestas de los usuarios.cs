using Metodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Respuestas_de_los_usuarios : Form
    {
        public Respuestas_de_los_usuarios()
        {
            InitializeComponent();
        }

        private void Respuestas_de_los_usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuariosR();
            Mostrarp();
        }
        private void MostrarUsuariosR()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.MostrarUsuariosR();
         
        }
        private void Mostrarp()
        {
            clase obj = new clase();
            
            dataGridView2.DataSource = obj.MostrarPreguntas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear_encuaesta ss = new Crear_encuaesta();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_respuesta_usuario  ss = new ver_respuesta_usuario();
            ss.Show();
            this.Hide();
        }
    }
}
