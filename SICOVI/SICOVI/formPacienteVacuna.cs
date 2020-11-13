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
    public partial class formPacienteVacuna : Form
    {
        public formPacienteVacuna()
        {
            InitializeComponent();
            
        }

        public string NomPaciente;
        public List<string> listaVacunas;

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            this.Close();
        }

        private void formPacienteVacuna_Load(object sender, EventArgs e)
        {
            txtNombre.Text = NomPaciente;

            foreach (string vacunas in listaVacunas)
            {
                cmbVacunas.Items.Add(vacunas);  
            }
        }
    }
}
