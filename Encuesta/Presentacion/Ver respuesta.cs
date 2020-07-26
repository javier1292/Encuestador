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
    public partial class Ver_respuesta : Form
    {
        clase obja = new clase();

        public Ver_respuesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idEnc = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                obja.idEnc(idEnc);
                ver_respuesta_usuario ss = new ver_respuesta_usuario();
                ss.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }
    

        private void Ver_respuesta_Load(object sender, EventArgs e)
        {
            MostarMisEncuestas();
        }

        private void MostarMisEncuestas()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu ss = new Menu();
            ss.Show();
            this.Hide();

        }
    }
}
