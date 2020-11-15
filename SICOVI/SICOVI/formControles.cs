using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Modelos;
using SICOVI.Data;

namespace SICOVI
{
    public partial class formControles : Form
    {
        public formControles()
        {
            InitializeComponent();
            actualizarDataGridView();
            llenarCmbPacientes();
            cmbPacientes.SelectedItem = "Todos";
        }

        List<Bitacora> listaBitacora;
        List<string> listaDePacientes;
        BitacoraD bitacoraD;

        private void llenarCmbPacientes()
        {
            bitacoraD = new BitacoraD();
            listaDePacientes = bitacoraD.llenarCmbPacientes();

            foreach (string paciente in listaDePacientes)
            {
                cmbPacientes.Items.Add(paciente);
            }
        }
        
        private void actualizarDataGridView()
        {
            dgvControles.DataSource = null;
            listaBitacora = new List<Bitacora>();
            bitacoraD = new BitacoraD();


            listaBitacora = bitacoraD.obtenerBitacora();
            dgvControles.DataSource = listaBitacora;
            dgvControles.Columns[0].Visible = false;
            dgvControles.Columns[1].Visible = false;
            dgvControles.Columns[2].Visible = false;
            dgvControles.Columns[3].HeaderText = "Nombre de paciente";
            dgvControles.Columns[4].HeaderText = "Nombre de vacuna";
            dgvControles.Columns[5].HeaderText = "Nombre de doctor";
            dgvControles.Columns[6].HeaderText = "Fecha de aplicación";
            dgvControles.Columns[7].HeaderText = "Observaciones";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                listaBitacora = new List<Bitacora>();
                bitacoraD = new BitacoraD();

                string paciente = cmbPacientes.SelectedItem.ToString();
                listaBitacora = bitacoraD.obtenerBitacoraXPaciente(paciente);

                dgvControles.DataSource = listaBitacora;
                dgvControles.Columns[0].Visible = false;
                dgvControles.Columns[1].Visible = false;
                dgvControles.Columns[2].Visible = false;
                dgvControles.Columns[3].HeaderText = "Nombre de paciente";
                dgvControles.Columns[4].HeaderText = "Nombre de vacuna";
                dgvControles.Columns[5].HeaderText = "Nombre de doctor";
                dgvControles.Columns[6].HeaderText = "Fecha de aplicación";
                dgvControles.Columns[7].HeaderText = "Observaciones";

                if (paciente == "Todos")
                    actualizarDataGridView();
            }
            catch 
            {
            
            }
        }
    }
}
