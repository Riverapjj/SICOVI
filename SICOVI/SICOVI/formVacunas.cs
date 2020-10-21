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
        List<Vacunas> listaVacunas;

        public formVacunas()
        {
            InitializeComponent();
            actualizar();
        }
        private void actualizar()
        {
            try
            {
                
                //dgvVacunas.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                        vacunas.Nombre_vacuna = txtNombre.Text;
                        vacunas.Descripción_vacuna = txtDescripcion.Text;
                        vacunas.Edad_aplicacion = edad;

                        vacunasD.insertarVacuna(vacunas);
                        MessageBox.Show("Datos ingresados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    actualizar();
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
                    
                    MessageBox.Show("Datos actualizados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
