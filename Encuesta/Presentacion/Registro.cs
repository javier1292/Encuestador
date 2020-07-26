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
    public partial class Registro : Form
    {


        clase objetoc =  new clase ();



        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string ape = txtApellido.Text;
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            string passc = txtCcontra.Text;

            if (nom != "" || ape != "" || user != "" || pass != "" || passc != "")
            {
                if (pass.Equals(passc))
                {
                    try
                    {

                        objetoc.Insertar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text, txtCcontra.Text);
                        MessageBox.Show("Registro completado ");


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo registrar " + ex);
                    }

                    Inicio ss = new Inicio();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Aun faltan campos por llenar");
            }
        }
    }
}
