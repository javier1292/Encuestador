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
    public partial class Tomar_encuesta : Form
    {
        clase obja = new clase();
        public Tomar_encuesta()
        {
            InitializeComponent();
        }

        private void Tomar_encuesta_Load(object sender, EventArgs e)
        {
            MostarEncuestas();
        }

        private void MostarEncuestas()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.MostrarEncuestas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idEnc = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                obja.idEnc(idEnc);
                Responder ss = new Responder();
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
            Menu ss = new Menu();
            ss.Show();
            this.Hide();
        }
    }
}
