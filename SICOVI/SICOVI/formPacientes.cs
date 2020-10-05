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
        private List<Paciente> lista = new List<Paciente>();
        public formPacientes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txNombre.Clear();
            txtEdad.Clear();
            txtNomMadre.Clear();
            txtNomPadre.Clear();
            txtTel.Clear();
        }
        private void actualizar()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = lista;
        }
        private bool vacio()
        {
            bool vacio = true;
            if (txNombre.Text == "")
            {
              vacio = false;
                errorProvider1.SetError(txNombre, "no se permite espacios vacios");
            }
                if (txtNomPadre.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtNomPadre, "no se permite espacios vacios");
            }

            if (txtEdad.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtEdad, "no se permite espacios vacios");
            }
            if (txtTel.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtTel, "no se permite espacios vacios");
            }

            return vacio;

        }
    

        private bool restrinciones()
        {
            bool restrinciones = true;
            if (txNombre.Text == "")
            {
                restrinciones = false;
                errorProvider1.SetError(txNombre, "SOLO SE PERMITEN LETRAS");
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
            if (txtEdad.Text == "")
            {
                restrinciones4 = false;
                errorProvider1.SetError(txtEdad, "SOLO SE PERMiTEN NUMEROS");
            }
            return restrinciones4;
        }
        private bool restrinciones5()
        {
            bool restrinciones5 = true;
            if (txtEdad.Text == "")
            {
                restrinciones5 = false;
                errorProvider1.SetError(txtTel, "SOLO SE PERMiTEN NUMEROS");
            }
            return restrinciones5;
        }

        private void borrar()
        {
            errorProvider1.SetError(txNombre, "");
            errorProvider1.SetError(txtNomPadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txtNomMadre, "");
            errorProvider1.SetError(txNombre, "");
            errorProvider1.SetError(txtTel, "");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            formPacienteVacuna formvac = new formPacienteVacuna();
            formvac.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            Paciente bebe = new Paciente();
            if (vacio())
            {
                int edad = int.Parse( txtEdad.Text);
                if(edad > 100)
                {
                    MessageBox.Show("EDAD NO EXISTE");
                    
                }
                else
                {
                    bebe.Nombre_paciente = txNombre.Text;
                    bebe.Nombre_madre = txtNomMadre.Text;
                    bebe.Nombre_padre = txtNomPadre.Text;


                    lista.Add(bebe);
                    actualizar();
                    Limpiar();
                }
                
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
    }
}
