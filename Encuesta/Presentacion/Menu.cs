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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear_encuaesta ss = new Crear_encuaesta();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tomar_encuesta ss = new Tomar_encuesta();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio ss = new Inicio();
            ss.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ver_respuesta ss = new Ver_respuesta();
            ss.Show();
            this.Hide();
        }
    }
}
