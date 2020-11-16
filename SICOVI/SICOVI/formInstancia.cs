using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Clases;
using SICOVI.Data;
using SICOVI.Modelos;

namespace SICOVI
{
    public partial class formInstancia : Form
    {
        public formInstancia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosSesion.NomInstancia = lblInstancia.Text.Trim();
            if (MessageBox.Show("¿Instancia ingresada correctamente?", "Bienvenido/a", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formLogin formlogin = new formLogin();
                formlogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese de nuevo el nombre de la instancia.");
            }
        }
    }
}
