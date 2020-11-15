using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Data;
using SICOVI.Modelos;
using SICOVI.Clases;

namespace SICOVI
{
    public partial class formPacienteVacuna : Form
    {
        public formPacienteVacuna()
        {
            InitializeComponent();
            formPrincipal formprinciapl = new formPrincipal();
        }

        public string NomPaciente;
        string NomUsuario = DatosSesion.NomUsuario;
        BitacoraD bitacoraD;
        public List<string> listaVacunas;

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            this.Hide();
        }

        private void formPacienteVacuna_Load(object sender, EventArgs e)
        {
            txtNombre.Text = NomPaciente;
            foreach (string vacunas in listaVacunas)
            {
                cmbVacunas.Items.Add(vacunas);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (cmbVacunas.SelectedItem.ToString() != "")
            {
                try
                {
                    
                    bitacoraD = new BitacoraD();

                    bitacoraD.insertarBitacora(cmbVacunas.SelectedItem.ToString() , NomUsuario, NomPaciente, txtObservaciones.Text);
                    MessageBox.Show("Datos ingresados correctamente.");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);   
                }
            }
        }
    }
}
