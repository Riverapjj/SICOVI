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
        private void Limpiar()
        {
            txNomPaciente.Clear();
            txtISSS.Clear();
            txtNomMadre.Clear();
            txtNomPadre.Clear();
            txtDUI.Clear();
            txtISSS.Clear();
            txtNomRespon.Clear();
        }
        private void actualizar()
        {
        }
        private bool vacio()
        {
            bool vacio = true;
            if (txNomPaciente.Text == "")
            {
              vacio = false;
                errorProvider1.SetError(txNomPaciente, "no se permite espacios vacios");
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
            if (txNomPaciente.Text == "")
            {
                restrinciones = false;
                errorProvider1.SetError(txNomPaciente, "SOLO SE PERMITEN LETRAS");
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

        private void borrar()
        {
            errorProvider1.SetError(txNomPaciente, "");
            errorProvider1.SetError(txtNomPadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txtNomRespon, "");
            errorProvider1.SetError(txNomPaciente, "");
            errorProvider1.SetError(txtDUI, "");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            formPacienteVacuna formvac = new formPacienteVacuna();
            formvac.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            if (vacio())
            {
                actualizar();
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
                restrinciones5();

            }

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
    }
}
