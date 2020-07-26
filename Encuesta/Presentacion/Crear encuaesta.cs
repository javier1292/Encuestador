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
    public partial class Crear_encuaesta : Form
    {
        private string ID_Encuesta;
        private bool EditarE = false;
        clase obj = new clase();

        private void MostarMisEncuestas()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.mostrar();
        }

        public Crear_encuaesta()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            textBox1.Clear();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EditarE == false)
            {
                try
                {

                    string nomE = textBox1.Text;
                    obj.InsertarEncuesta(nomE);
                    MessageBox.Show("Se agrego correctamente  ");
                    MostarMisEncuestas();
                    limpiar();
         

                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el contacto  " + ex);
                }
                limpiar();
            }
            if (EditarE == true)
            {
                try
                {
                    int idEncuesta= Int32.Parse(ID_Encuesta);
                    obj.EditarE(textBox1.Text, idEncuesta);
                    
                    MessageBox.Show("Se edito correctamente   ");
                   
                    EditarE = false;
                    MostarMisEncuestas();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos   " + ex);
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Crear_encuaesta_Load(object sender, EventArgs e)
        {
            MostarMisEncuestas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {    
                string idEnc = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                obj.idEnc(idEnc);
                Ver_encuesta ss = new Ver_encuesta();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
            

           
           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID_Encuesta = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                obj.EliminiarE(ID_Encuesta);

                MessageBox.Show("se elmino la encuesta");
                MostarMisEncuestas();
            }
            else
            {
                MessageBox.Show("seleccione una encuesta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                limpiar();
                EditarE = true;
                ID_Encuesta = dataGridView1.CurrentRow.Cells["ID_encuesta"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre_encuesta"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
