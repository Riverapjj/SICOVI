using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace SICOVI
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            inicializarSubMenu();
        }

        private void inicializarSubMenu()
        {
            panelSubMenuUsuario.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuUsuario.Visible == true)
                panelSubMenuUsuario.Visible = false;
        }

        private void mostrarSubMenu()
        {
            if (panelSubMenuUsuario.Visible == false)
            {
                ocultarSubMenu();
                panelSubMenuUsuario.Visible = true;
            }
            else 
            {
                panelSubMenuUsuario.Visible = false;
            }
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormHijo(new formAdmin());
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormHijo(new formDoctores());
        }

        private void btnRecepcionista_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormHijo(new formRecepcionistas());
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnControles_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new formControles());
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new formPacientes());
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new formVacunas());
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
