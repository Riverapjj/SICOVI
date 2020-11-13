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
    public partial class formPacientes : Form
    {
        PacientesD pacientesD;
        Paciente paciente;
        string id;
        List<Paciente> listaPacientes;
        formPacienteVacuna formvac = new formPacienteVacuna();

        public formPacientes()
        {
            InitializeComponent();
            actualizarDataGridView();
        }
        private void Limpiar()
        {
            txtNomPaciente.Clear();
            txtISSS.Clear();
            txtNomMadre.Clear();
            txtNomPadre.Clear();
            txtDUI.Clear();
            txtISSS.Clear();
            txtNomRespon.Clear();
            btnModificar.Enabled = false;
        }
        private void actualizarDataGridView()
        {
            dgvPacientes.DataSource = null;
            listaPacientes = new List<Paciente>();
            PacientesD pacientesD = new PacientesD();


            listaPacientes = pacientesD.obtenerPacientes();
            dgvPacientes.DataSource = listaPacientes;
            dgvPacientes.Columns[0].HeaderText = "Nombre de paciente";
            dgvPacientes.Columns[1].HeaderText = "Fecha de nacimiento";
            dgvPacientes.Columns[2].Visible = false;
            dgvPacientes.Columns[3].Visible = false;
            dgvPacientes.Columns[4].HeaderText = "Nombre de responsable";
            dgvPacientes.Columns[5].HeaderText = "DUI de responsable";
            dgvPacientes.Columns[6].HeaderText = "N° ISS";
            dgvPacientes.Columns[7].Visible = false;
        }
        private bool vacio()
        {
            bool vacio = true;
            if (txtNomPaciente.Text == "")
            {
              vacio = false;
                errorProvider1.SetError(txtNomPaciente, "no se permite espacios vacios");
            }
            if (txtNomPadre.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtNomPadre, "no se permite espacios vacios");
            }
            if (txtNomMadre.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtNomMadre, "no se permite espacios vacios");
            }
            if (txtNomRespon.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtNomRespon, "no se permite espacios vacios");
            }
            if (txtISSS.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtISSS, "no se permite espacios vacios");
            }
            if (txtDUI.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtDUI, "no se permite espacios vacios");
            }

            return vacio;

        }
    

        private bool restrinciones()
        {
            bool restrinciones = true;
            if (txtNomPaciente.Text == "")
            {
                restrinciones = false;
                errorProvider1.SetError(txtNomPaciente, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones;
        }
        private bool restrinciones2()
        {
            bool restrinciones2 = true;
            if (txtNomPadre.Text == "")
            {
                restrinciones2 = false;
                errorProvider1.SetError(txtNomPadre, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones2;
}
        private bool restrinciones3()
        {
            bool restrinciones3 = true;
            if (txtNomMadre.Text == "")
            {
                restrinciones3 = false;
                errorProvider1.SetError(txtNomMadre, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones3;
        }
        private bool restrinciones4()
        {
            bool restrinciones4 = true;
            if (txtISSS.Text == "")
            {
                restrinciones4 = false;
                errorProvider1.SetError(txtISSS, "SOLO SE PERMiTEN NUMEROS");
            }
            return restrinciones4;
        }
        private bool restrinciones5()
        {
            bool restrinciones5 = true;
            if (txtISSS.Text == "")
            {
                restrinciones5 = false;
                errorProvider1.SetError(txtDUI, "SOLO SE PERMiTEN NUMEROS");
            }
            return restrinciones5;
        }

        private bool restrinciones6()
        {
            bool restrinciones6 = true;
            if (txtNomRespon.Text == "")
            {
                restrinciones6 = false;
                errorProvider1.SetError(txtNomRespon, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones6;
        }

        public void modoEditable(bool estado)
        {
            txtNomPaciente.Enabled = !estado;
            txtNomPadre.Enabled = !estado;
            txtNomMadre.Enabled = !estado;
            txtNomRespon.Enabled = !estado;
            txtDUI.Enabled = !estado;
            txtISSS.Enabled = !estado;
            dtpFechaNac.Enabled = !estado;
            btnModificar.Enabled = !estado;
        }
        private void borrar()
        {
            errorProvider1.SetError(txtNomPaciente, "");
            errorProvider1.SetError(txtNomPadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txtNomRespon, "");
            errorProvider1.SetError(txtNomPaciente, "");
            errorProvider1.SetError(txtDUI, "");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            
            formvac.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            if (vacio())
            {
                string formatoDUI = txtDUI.Text;
                if (formatoDUI.Count(char.IsDigit) == 9)
                {
                    if (formatoDUI[8] == '-')
                    {
                        try
                        {
                            paciente = new Paciente();
                            pacientesD = new PacientesD();

                            paciente.Nombre_paciente = txtNomPaciente.Text;
                            paciente.Nombre_madre = txtNomMadre.Text;
                            paciente.Nombre_padre = txtNomPadre.Text;
                            paciente.Nombre_responsable = txtNomRespon.Text;
                            paciente.Num_dui_resposable = txtDUI.Text;
                            paciente.Num_seguro_responsable = txtISSS.Text;
                            paciente.Fecha_nacimiento = dtpFechaNac.Value;

                            pacientesD.insertarPacientes(paciente);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El formato del DUI es incorrecto. Ej: 00000000-0 2");
                        Limpiar();
                    }

                }
                else 
                {
                    MessageBox.Show("El formato del DUI es incorrecto. Ej: 00000000-0 1");
                    Limpiar();
                }
                

                actualizarDataGridView();
                Limpiar();
            }


            
                

        }

        private void txNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                restrinciones();
            }
        }

        private void txtNomPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                restrinciones2();
            }

        }

        private void txtNomMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                restrinciones3();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                restrinciones4();

            }

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            //borrar();
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            ////para tecla backspace
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}



            //else
            //{
            //    e.Handled = true;
            //    restrinciones5();

            //}

        }

        private void txtNomRespon_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                restrinciones6();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            borrar();
            if (vacio())
            {
                try
                {
                    pacientesD = new PacientesD();
                    paciente = new Paciente();

                    paciente.ID_Paciente = id;
                    paciente.Nombre_paciente = txtNomPaciente.Text;
                    paciente.Nombre_padre = txtNomPadre.Text;
                    paciente.Nombre_madre = txtNomMadre.Text;
                    paciente.Nombre_responsable = txtNomRespon.Text;
                    paciente.Num_dui_resposable = txtDUI.Text;
                    paciente.Num_seguro_responsable = txtISSS.Text;
                    paciente.Fecha_nacimiento = dtpFechaNac.Value.Date;

                    pacientesD.actualizarPaciente(paciente);

                    MessageBox.Show("Datos actualizados correctamente.");
                    actualizarDataGridView();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    object value = dgvPacientes.Rows[e.RowIndex].Cells[7].Value;
                    id = Convert.ToString(value);
                    paciente = new Paciente();
                    pacientesD = new PacientesD();

                    paciente = pacientesD.obtenerUnPaciente(id);

                    txtNomPaciente.Text = paciente.Nombre_paciente;
                    txtNomMadre.Text = paciente.Nombre_madre;
                    txtNomPadre.Text = paciente.Nombre_padre;
                    txtNomRespon.Text = paciente.Nombre_responsable;
                    txtDUI.Text = paciente.Num_dui_resposable;
                    txtISSS.Text = paciente.Num_seguro_responsable;
                    dtpFechaNac.Value = Convert.ToDateTime(paciente.Fecha_nacimiento).Date;

                    formvac.NomPaciente = paciente.Nombre_paciente;
                    formvac.listaVacunas = pacientesD.obtenerVacunasXPaciente(txtNomPaciente.Text.Trim());

                    modoEditable(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            modoEditable(false);
        }
    }
}
