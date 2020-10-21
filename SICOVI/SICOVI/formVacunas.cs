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

namespace SICOVI
{
    public partial class formVacunas : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string stringCon;
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder cmdBuilder;
        private int id;

        public formVacunas()
        {
            InitializeComponent();
            
            Conexion conexion = new Conexion();
            conexion.conectar();
            stringCon = conexion.cadena;

            conn = new SqlConnection(stringCon);
            actualizar();
        }
        private void actualizar()
        {
            try
            {
                DataSet dataSet = new DataSet();
                string select = "SELECT Nombre, Descripcion, Edad_Aplicacion AS [Edad de aplicación] FROM Vacunas";
                dataAdapter = new SqlDataAdapter(select, conn);
                cmdBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet);

                dgvVacunas.DataSource = dataSet.Tables[0];
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
                        cmd = new SqlCommand("Insertar_Vacuna", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                        cmd.Parameters.Add("@Edad_Aplicacion", SqlDbType.Char).Value = txtEdad.Text;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

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
                    cmd = new SqlCommand("Actualizar_Vacuna", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID_Vacuna", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                    cmd.Parameters.Add("@Edad_Aplicacion", SqlDbType.Char).Value = txtEdad.Text;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

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
            string select = "SELECT ID_Vacuna FROM VACUNAS WHERE Nombre = @Nombre AND Descripcion = @Descripcion AND Edad_Aplicacion = @Edad";
            string select2 = "SELECT Nombre, Descripcion, Edad_Aplicacion FROM Vacunas WHERE ID_Vacuna = @ID_Vacuna";
            cmd = new SqlCommand(select, conn);

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
            cmd.Parameters.Add("@Edad", SqlDbType.Char).Value = txtEdad.Text;
            conn.Open();
            id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            cmd = new SqlCommand(select2, conn);
            cmd.Parameters.Add("@ID_Vacuna", SqlDbType.Int).Value = id;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
