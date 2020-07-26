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
    public partial class Ver_encuesta : Form
    {
        private bool EditarP = false;
        private string ID_Pregunta;
        clase obja = new clase();

        public Ver_encuesta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Crear_encuaesta ss = new Crear_encuaesta();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (EditarP == false)
            {
                try
                {
                    string nomP = textBox1.Text;
                    obja.InsertarP(nomP);
                    MessageBox.Show("Se inserto correctamente");
                    MostarMisPreguntas();
                    textBox1.Text = "";


                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el contacto  " + ex);
                }
                limpiar();
            }
            if (EditarP == true)
            {
                try
                {
                    int idPregunta = Int32.Parse(ID_Pregunta);
                    obja.EditarP(textBox1.Text, idPregunta);

                    MessageBox.Show("Se edito correctamente   ");

                    EditarP = false;
                    MostarMisPreguntas();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos   " + ex);
                }
            }


            
        }

        private void Ver_encuesta_Load(object sender, EventArgs e)
        {
            MostarMisPreguntas();
        }

        private void MostarMisPreguntas()
        {
            clase obj = new clase();
            dataGridView1.DataSource = obj.mostrarP();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID_Pregunta = dataGridView1.CurrentRow.Cells["ID_pregunta"].Value.ToString();
                obja.EliminiarP(ID_Pregunta);

                MessageBox.Show("se elmino la encuesta");
                MostarMisPreguntas();
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
                EditarP = true;
                ID_Pregunta = dataGridView1.CurrentRow.Cells["ID_pregunta"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Pregunta"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }


        }
        private void limpiar()
        {
            textBox1.Clear();



        }
    }
}
