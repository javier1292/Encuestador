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
    public partial class ver_respuesta_usuario : Form
    {
        clase obja= new clase();
        public ver_respuesta_usuario()
        {
            InitializeComponent();
        }

        private void ver_respuesta_usuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.MostrarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {               
                string idUser = dataGridView1.CurrentRow.Cells["ID_usuario"].Value.ToString();
                string idEnc = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                obja.idEnc(idEnc); 
                obja.idUser(idUser);
                Respuestas_de_los_usuarios ss = new Respuestas_de_los_usuarios();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ver_respuesta ss = new Ver_respuesta();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu ss = new Menu();
            ss.Show();
            this.Hide();
        }
    }
}
