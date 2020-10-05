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
    public partial class formRecepcionistas : Form
    {
        public formRecepcionistas()
        {
            InitializeComponent();
        }

        List<Usuarios> lista = new List<Usuarios>();

        public void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtRango.Clear();
            txtDUI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void actualizar()
        {
            dgvRecepcionistas.DataSource = null;
            dgvRecepcionistas.DataSource = lista;
        }

        private bool vacio()
        {
            bool vacio = true;
            if (txtNombre.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtNombre, "no se permite espacios vacios");
            }
            if (txtUsuario.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtUsuario, "no se permite espacios vacios");
            }
            if (txtContra.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtContra, "no se permite espacios vacios");
            }
            if (txtRango.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtRango, "no se permite espacios vacios");
            }
            if (txtTelefono.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtTelefono, "no se permite espacios vacios");
            }
            if (txtDUI.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtDUI, "no se permite espacios vacios");
            }
            if (txtEmail.Text == "")
            {
                vacio = false;
                errorProvider1.SetError(txtEmail, "no se permite espacios vacios");
            }

            return vacio;

        }

        private bool restrinciones()
        {
            bool restrinciones = true;
            if (txtNombre.Text == "")
            {
                restrinciones = false;
                errorProvider1.SetError(txtNombre, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones;
        }

        private bool restrinciones1()
        {
            bool restrinciones1 = true;
            if (txtUsuario.Text == "")
            {
                restrinciones1 = false;
                errorProvider1.SetError(txtUsuario, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones1;
        }

        private bool restrinciones2()
        {
            bool restrinciones2 = true;
            if (txtContra.Text == "")
            {
                restrinciones2 = false;
                errorProvider1.SetError(txtContra, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones2;
        }

        private bool restrinciones3()
        {
            bool restrinciones3 = true;
            if (txtRango.Text == "")
            {
                restrinciones3 = false;
                errorProvider1.SetError(txtRango, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones3;
        }

        private bool restrinciones4()
        {
            bool restrinciones4 = true;
            if (txtTelefono.Text == "")
            {
                restrinciones4 = false;
                errorProvider1.SetError(txtTelefono, "SOLO SE PERMITEN NÚMEROS");
            }
            return restrinciones4;
        }

        private bool restrinciones5()
        {
            bool restrinciones5 = true;
            if (txtDUI.Text == "")
            {
                restrinciones5 = false;
                errorProvider1.SetError(txtDUI, "SOLO SE PERMITEN NÚMEROS");
            }
            return restrinciones5;
        }

        private bool restrinciones6()
        {
            bool restrinciones6 = true;
            if (txtEmail.Text == "")
            {
                restrinciones6 = false;
                errorProvider1.SetError(txtEmail, "SOLO SE PERMITEN LETRAS");
            }
            return restrinciones6;
        }

        private void borrar()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContra, "");
            errorProvider1.SetError(txtRango, "");
            errorProvider1.SetError(txtDUI, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtEmail, "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();
            Usuarios usuarios = new Usuarios();

            if (vacio())
            {
                usuarios.Nombre = txtNombre.Text;
                usuarios.Usuario = txtUsuario.Text;
                usuarios.Contra = txtContra.Text;
                usuarios.Rango = txtRango.Text;
                usuarios.Dui = txtDUI.Text;
                usuarios.Telefono = txtTelefono.Text;
                usuarios.Email = txtEmail.Text;
                lista.Add(usuarios);
                actualizar();
                Limpiar();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                restrinciones();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
                restrinciones1();
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
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
                restrinciones5();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                restrinciones4();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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
