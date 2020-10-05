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
    public partial class formVacunas : Form
    {
        private List<Vacunas> lista = new List<Vacunas>();
   
        public formVacunas()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            dgvVacunas.DataSource = null;
            dgvVacunas.DataSource = lista;
        }
        private void limpiar()
        {
            txNombre.Clear();
            txtEdad.Clear();
        }

      
            private void borrar()
            {
                errorProvider1.SetError(txtEdad, "");
                errorProvider1.SetError(txNombre, "");
            }
        private bool validar()
        {
            bool validar = true;
            if (txtEdad.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtEdad, "NO SE PERMITEN ESPSCIOS VACIOS");
            }
            if(txNombre.Text == "")
            {
                errorProvider1.SetError(txNombre, "NO SE PERMITEN ESPACIOS VACIOS");
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
            Vacunas control = new Vacunas();
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
                control.Nombre_vacuna = txNombre.Text;
                control.Edad_aplicacion = edad;
                lista.Add(control);
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
    }
}
