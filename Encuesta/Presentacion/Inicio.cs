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
    public partial class Inicio : Form
    {
        clase obj = new clase();
        public bool acceso;
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro ss = new Registro();
            ss.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Contraseña = textBox2.Text;
            obj.Login(Usuario, Contraseña);

            acceso = obj.acceso;

            if (acceso == true)
            {
                Menu ss = new Menu();
                ss.Show();
                this.Hide();

                acceso = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
