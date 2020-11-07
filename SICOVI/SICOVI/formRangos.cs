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
    public partial class formRangos : Form
    {
        public formRangos()
        {
            InitializeComponent();
            actualizarDataGridView();
            modoEditable(true);
        }

        Rangos rango;
        RangosD rangosD;
        int id;
        List<Rangos> listaRangos;

        private void actualizarDataGridView()
        {
            dgvRangos.DataSource = null;
            listaRangos = new List<Rangos>();
            RangosD rangosD = new RangosD();


            listaRangos = rangosD.obtenerRangos();
            dgvRangos.DataSource = listaRangos;
            dgvRangos.Columns[0].Visible = false;
            dgvRangos.Columns[1].HeaderText = "Nombre de rango";
        }

        private void modoEditable(bool estado)
        {
            checkPacientes.Enabled = !estado;
            checkRangos.Enabled = !estado;
            checkUsuarios.Enabled = !estado;
            checkVacunas.Enabled = !estado;
            checkBitacora.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnLimpiar.Enabled = estado;
        }
        private bool validar()
        {
            bool validar = true;
            if (txtNombreRango.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtNombreRango, "NO SE PERMITEN ESPSCIOS VACIOS");
            }
            return validar;

        }
        private void borrar()
        {
            errorProvider1.SetError(txtNombreRango, "");
        }

        private void limpiar()
        {
            txtNombreRango.Clear();
            checkBitacora.Checked = false;
            checkPacientes.Checked = false;
            checkRangos.Checked = false;
            checkUsuarios.Checked = false;
            checkVacunas.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            if (validar())
            {
                try
                {
                    rango = new Rangos();
                    rangosD = new RangosD();

                    rango.Nombre_rango = txtNombreRango.Text;

                    rangosD.insertarRangos(rango);
                    MessageBox.Show("Datos ingresados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                modoEditable(true);
                actualizarDataGridView();
                limpiar();

            }
        }

        private void dgvRangos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    List<string> listaFormularios = new List<string>();
                    object value = dgvRangos.Rows[e.RowIndex].Cells[0].Value;
                    id = Convert.ToInt32(value);
                    rango = new Rangos();
                    rangosD = new RangosD();

                    rango = rangosD.obtenerUnRango(id);
                    listaFormularios = rangosD.obtenerFormularios(id);

                    foreach (var form in listaFormularios)
                    {
                        if (form.Trim() == "btnPaciente")
                        {
                            checkPacientes.Checked = true;
                        }
                        if (form.Trim() == "btnControles")
                        {
                            checkBitacora.Checked = true;
                        }
                        if (form.Trim() == "btnVacuna")
                        {
                            checkVacunas.Checked = true;
                        }
                        if (form.Trim() == "btnUsuario")
                        {
                            checkUsuarios.Checked = true;
                        }
                        if (form.Trim() == "btnRangos")
                        {
                            checkRangos.Checked = true;
                        }
                    }

                    

                    id = rango.Id_Rango;
                    txtNombreRango.Text = rango.Nombre_rango;
                    modoEditable(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
