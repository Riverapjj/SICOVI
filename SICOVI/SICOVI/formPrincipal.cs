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
using SICOVI.Clases;
using SICOVI.Data;

namespace SICOVI
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            inicializarSubMenu();
        }

        public int ID_Rango;
        public string NomUsuario;

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

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            formCreditos formcreditos = new formCreditos();
            formcreditos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRangos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new formRangos());
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            List<string> listaFormularios = new List<string>();
            RangosD rangosD = new RangosD();
            listaFormularios = rangosD.obtenerFormularios(ID_Rango);

            btnControles.Hide();
            btnRangos.Hide();
            btnUsuario.Hide();
            btnVacuna.Hide();
            btnPaciente.Hide();

            foreach (string form in listaFormularios)
            {
                if (form.Trim() == "btnPaciente")
                {
                    btnPaciente.Show();
                }
                /**/
                if (form.Trim() == "btnVacuna")
                {
                    btnVacuna.Show();
                }
                /**/
                if (form.Trim() == "btnControles")
                {
                    btnControles.Show();
                }
                /**/
                if (form.Trim() == "btnUsuario")
                {
                    btnUsuario.Show();
                }
                /**/
                if (form.Trim() == "btnRangos")
                {
                    btnRangos.Show();
                }
            }
        }
    }
}
