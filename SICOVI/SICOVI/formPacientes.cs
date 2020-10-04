using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICOVI
{
    public partial class formPacientes : Form
    {
        public formPacientes()
        {
            InitializeComponent();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            formPacienteVacuna formvac = new formPacienteVacuna();
            formvac.Show();

        }
    }
}
