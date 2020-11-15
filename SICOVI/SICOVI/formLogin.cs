using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOVI.Data;
using SICOVI.Modelos;
using SICOVI.Clases;

namespace SICOVI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            Thread thread = new Thread(ejecutarSplash);
            thread.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            thread.Abort();
        }


        public void ejecutarSplash()
        {
            Application.Run(new formSplash());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtClave.Text.Trim() != "")
            {
                Usuarios usuarios = new Usuarios();
                UsuariosD usuariosD = new UsuariosD();

                usuarios = usuariosD.login(txtUsuario.Text, txtClave.Text);

                if (usuarios != null)
                {
                    formPrincipal formprincipal = new formPrincipal();

                    formprincipal.ID_Rango = usuarios.Rango;
                    DatosSesion.NomUsuario = usuarios.Nombre;
                    formprincipal.Show();

                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Usuario y/o contraseña erróneo.");
                    txtClave.Clear();
                    txtUsuario.Clear();
                }
            }
            else 
            {
                MessageBox.Show("Ingrese usuario y/o contraseña.");
                txtClave.Clear();
                txtUsuario.Clear();
            }
        }
    }
}
