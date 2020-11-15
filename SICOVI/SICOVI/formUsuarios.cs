using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Data;
using SICOVI.Modelos;

namespace SICOVI
{
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
            llenarCmbRangos();
            actualizarDataGridView();
        }

        List<Usuarios> listaUsuarios;
        List<string> listaRangos;
        int id;
        RangosD rangosD;
        Usuarios usuarios;
        UsuariosD usuariosD;

        private void llenarCmbRangos()
        {
            try
            {
                rangosD = new RangosD();
                listaRangos = rangosD.obtenerNombreRangos();
                foreach (string rango in listaRangos)
                {
                    cmbRangos.Items.Add(rango);
                }
            }
            catch
            { 
            
            }
        }

        public void modoEditable(bool estado)
        {
            txtNombre.Enabled = !estado;
            txtUsuario.Enabled = !estado;
            txtContra.Enabled = !estado;
            txtEmail.Enabled = !estado;
            txtDUI.Enabled = !estado;
            txtTelefono.Enabled = !estado;
            cmbRangos.Enabled = !estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnLimpiar.Enabled = estado;
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtDUI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
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

        private void actualizarDataGridView()
        {
            dgvAdmin.DataSource = null;
            listaUsuarios = new List<Usuarios>();
            UsuariosD usuariosD = new UsuariosD();


            listaUsuarios = usuariosD.obtenerUsuarios();
            dgvAdmin.DataSource = listaUsuarios;
            dgvAdmin.Columns[0].Visible = false;
            dgvAdmin.Columns[1].HeaderText = "Nombre";
            dgvAdmin.Columns[2].HeaderText = "Nombre de usuario";
            dgvAdmin.Columns[3].HeaderText = "Clave";
            dgvAdmin.Columns[4].HeaderText = "DUI";
            dgvAdmin.Columns[5].Visible = false;
            dgvAdmin.Columns[6].HeaderText = "Rango";
            dgvAdmin.Columns[7].HeaderText = "Telefono";
            dgvAdmin.Columns[8].HeaderText = "Email";
        }

        private void borrar()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContra, "");
            errorProvider1.SetError(txtDUI, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtEmail, "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar();

            if (vacio())
            {
                string formatoNomUsuario = txtUsuario.Text;
                string formatoDUI = txtDUI.Text;
                string fomatoEmail = txtEmail.Text;
                if (formatoNomUsuario.Count(char.IsLetter) == 2)
                {
                    if (formatoNomUsuario.Count(char.IsDigit) == 8)
                    {
                        bool confirmarFormatoUsuario = Regex.IsMatch(formatoNomUsuario, @"^[A-Z]{2}\d*");
                        if (confirmarFormatoUsuario)
                        {
                            bool confirmarFormatoDUI = Regex.IsMatch(formatoDUI, @"^[0-9]{8}\-\d*");
                            if (confirmarFormatoDUI)
                            {
                                if (IsEmailValid(fomatoEmail))
                                {
                                    usuarios = new Usuarios();
                                    usuariosD = new UsuariosD();
                                    rangosD = new RangosD();

                                    try
                                    {
                                        usuarios.Nombre = txtNombre.Text;
                                        usuarios.Usuario = formatoNomUsuario;
                                        usuarios.Contra = txtContra.Text;
                                        usuarios.Dui = formatoDUI;
                                        usuarios.Rango = rangosD.obtenerIdRango(cmbRangos.SelectedItem.ToString().Trim());
                                        usuarios.NomRango = cmbRangos.SelectedItem.ToString();
                                        usuarios.Email = txtEmail.Text;
                                        usuarios.Telefono = txtTelefono.Text;

                                        usuariosD.insertarUsuario(usuarios);

                                        MessageBox.Show("Datos ingresados existosamente.");

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El formato de correo no es válido.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El DUI debe contener 9 carácteres (Ej. 0000000-0).");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario debe contener 2 letras al inicio.2");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario debe contener 8 dígitos.");
                    }
                }
                else 
                {
                    MessageBox.Show("El nombre de usuario debe contener 2 letras al inicio.1");
                }
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
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else
            //{
            //    e.Handled = true;
            //    restrinciones1();
            //}
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
            //borrar();
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else
            //{
            //    e.Handled = true;
            //    restrinciones3();
            //}
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else
            //{
            //    e.Handled = true;
            //    restrinciones5();
            //}
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtTelefono.Text.Length > 7)
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        public bool IsEmailValid(string email)
        {
            try
            {
                MailAddress formatoEmail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrar();
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            //else
            //{
            //    e.Handled = true;
            //    restrinciones6();
            //}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            borrar();
            if (vacio())
            {
                try
                {
                    usuariosD = new UsuariosD();
                    usuarios = new Usuarios();
                    rangosD = new RangosD();

                    usuarios.ID_Usuario = id;
                    usuarios.Nombre = txtNombre.Text;
                    usuarios.NomRango = cmbRangos.SelectedItem.ToString();
                    usuarios.Contra = txtContra.Text;
                    usuarios.Telefono = txtTelefono.Text;
                    usuarios.Usuario = txtUsuario.Text;
                    usuarios.Rango = rangosD.obtenerIdRango(cmbRangos.SelectedItem.ToString());
                    usuarios.Email = txtEmail.Text;
                    usuarios.Dui = txtDUI.Text;


                    usuariosD.actualizarUsuarios(usuarios);

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

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    object value = dgvAdmin.Rows[e.RowIndex].Cells[0].Value;
                    id = (int) value;
                    usuarios = new Usuarios();
                    usuariosD = new UsuariosD();

                    usuarios = usuariosD.obtenerUnUsuario(id);

                    txtNombre.Text = usuarios.Nombre;
                    txtUsuario.Text = usuarios.Usuario;
                    txtContra.Text = usuarios.Contra;
                    txtDUI.Text = usuarios.Dui;
                    txtTelefono.Text = usuarios.Telefono;
                    txtEmail.Text = usuarios.Email;
                    cmbRangos.SelectedItem = usuarios.NomRango;

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
