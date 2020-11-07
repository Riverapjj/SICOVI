using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Modelos;
using SICOVI.Data;

namespace SICOVI
{
    public partial class formVacunas : Form
    {
        VacunasD vacunasD;
        Vacunas vacunas;
        string nombreVac;
        int id;
        List<Vacunas> listaVacunas;

        public formVacunas()
        {
            InitializeComponent();
            actualizarDataGridView();
        }

        private void actualizarDataGridView()
        {
            dgvVacunas.DataSource = null;
            listaVacunas = new List<Vacunas>();
            VacunasD vacunasD = new VacunasD();

            
            listaVacunas = vacunasD.obtenerVacunas();
            dgvVacunas.DataSource = listaVacunas;
            dgvVacunas.Columns[0].Visible = false;
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtDescripcion.Clear();
        }

      
        private void borrar()
        {
            errorProvider1.SetError(txtEdad, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtDescripcion, "");
        }

        private bool validar()
        {
            bool validar = true;
            if (txtEdad.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtEdad, "NO SE PERMITEN ESPSCIOS VACIOS");
            }
            if(txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "NO SE PERMITEN ESPACIOS VACIOS");
            }
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "NO SE PERMITEN ESPACIOS VACIOS");
            }
            return validar;

        }
        private bool validar2()
        {

            bool restrinciones2 = true;
            if (txtEdad.Text == "")
            {
                restrinciones2 = false;
                errorProvider1.SetError(txtEdad, "SOlO SE PERMITEN NUMEROS");
            }
            return restrinciones2;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            if (validar())
            {
              
            
            int edad = int.Parse(txtEdad.Text);
           
                if(edad > 100)
                {
                    MessageBox.Show("EDAD NO EXISTE");
                    limpiar();
                }
                else
                {
                    try
                    {
                        vacunas = new Vacunas();
                        vacunasD = new VacunasD();

                        vacunas.Nombre = txtNombre.Text;
                        vacunas.Descripcion = txtDescripcion.Text;
                        vacunas.Edad = edad;

                        vacunasD.insertarVacuna(vacunas);
                        MessageBox.Show("Datos ingresados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    actualizarDataGridView();
                    limpiar();

                }

             }
               
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                validar2();
               
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            borrar();
            if (validar())
            {
                try
                {
                    vacunasD = new VacunasD();
                    vacunas = new Vacunas();

                    vacunas.ID_Vacuna = id;
                    vacunas.Nombre = txtNombre.Text;
                    vacunas.Descripcion = txtDescripcion.Text;
                    vacunas.Edad = Convert.ToInt32(txtEdad.Text);

                    vacunasD.actualizarVacunas(vacunas);

                    MessageBox.Show("Datos actualizados correctamente.");
                    actualizarDataGridView();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    object value = dgvVacunas.Rows[e.RowIndex].Cells[1].Value;
                    nombreVac = Convert.ToString(value);
                    vacunas = new Vacunas();
                    vacunasD = new VacunasD();

                    vacunas = vacunasD.obtenerUnaVacuna(nombreVac);

                    id = vacunas.ID_Vacuna;
                    txtNombre.Text = vacunas.Nombre;
                    txtDescripcion.Text = vacunas.Descripcion;
                    txtEdad.Text = vacunas.Edad.ToString();
                    modoEditable(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void modoEditable(bool estado)
        {
            txtNombre.Enabled = !estado;
            txtDescripcion.Enabled = !estado;
            txtEdad.Enabled = !estado;
            btnModificar.Enabled = !estado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            modoEditable(false);
        }
    }
}
