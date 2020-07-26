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
    public partial class Responder : Form
    {

        clase obj = new clase();

        public Responder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {              
                string ID_Pregunta = dataGridView1.CurrentRow.Cells["ID_pregunta"].Value.ToString();            
                string nomR = textBox1.Text;
                obj.InsertarR(nomR, ID_Pregunta);
                MessageBox.Show("Se agrego correctamente  ");
                textBox1.Clear();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
            
            
        }
        private void MostrarPreguntas()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.MostrarPreguntas();
        }

        private void Responder_Load(object sender, EventArgs e)
        {
            
            MostrarPreguntas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             
                Tomar_encuesta ss = new Tomar_encuesta();
                ss.Show();
               this.Hide();
           
            
        }
    }
}
