using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresBaseDeDatos
{
    public partial class frmCargarEntrenador : Form
    {
        //Creacion de objetos
        //Nos permite conectar a la base de datos
        private OleDbConnection conexionBd = new OleDbConnection();
        //Con este objeto enviamos una orden a la BD
        private OleDbCommand comandoBd = new OleDbCommand();
        //Nos sirve para adaptar los datos de la BD a datos reconocidos por .NET
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();
        //variable para indicar la ruta de la BD
        private string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmCargarEntrenador()
        {
            InitializeComponent();
        }
        //El evento keypress sucede cuando el usuario hace foco en una txt
        private void txtNombreEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled nos permite ingresar el valor o sea visualizar la letra
                e.Handled = true;
            }
        }
        //El evento keypress sucede cuando el usuario hace foco en una txt
        private void txtApellidoEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled nos permite ingresar el valor o sea visualizar la letra
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }


        private void frmCargarEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarEntrenador_Click(object sender, EventArgs e)
        {
           
            string CodigoEntrenador = txtCodigoEntrenador.Text;
            string Nombre = txtNombreEntrenador.Text;
            string Apellido = txtApellidoEntrenador.Text;
            string Direccion = Convert.ToString(txtDireccionEntrenador.Text);
            string Provincia = txtProvinciaEntrenador.Text;
            string Deporte = Convert.ToString(lstDeporteEntrenador.SelectedItem);
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexionBd = new OleDbConnection(varRutaAccesoBD);
                //Abre la conexion de la BD, es un canal
                conexionBd.Open();
                //El comando toma la conexion
                comandoBd.Connection = conexionBd;
                //Se indica el tipo de comando el text es para instrucciones sql
                comandoBd.CommandType = CommandType.Text;
                //Se le indica el comando sql
                comandoBd.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO ENTRENADOR], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    " VALUES ('" + CodigoEntrenador + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";
                //ejecuta el comando
                comandoBd.ExecuteNonQuery();
                MessageBox.Show("Entrenador Cargado");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el entrenador");
            }

            conexionBd.Close();
        }

        private void mrcCargarEntrenador_Enter(object sender, EventArgs e)
        {
            txtCodigoEntrenador.Focus();
        }

        private void txtProvinciaEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled nos permite ingresar el valor o sea visualizar la letra
                e.Handled = true;
            }
        }

        private void VerificarControles()
        {
            if (txtCodigoEntrenador.Text != "" && txtNombreEntrenador.Text != "" && txtApellidoEntrenador.Text != "" && txtDireccionEntrenador.Text != "" && txtProvinciaEntrenador.Text != "" && lstDeporteEntrenador.SelectedIndex != -1)
            {
                btnCargarEntrenador.Enabled = true;
            }
            else
            {
                btnCargarEntrenador.Enabled = false;
            }




        }

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }

        private void txtCodigoEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled nos permite ingresar el valor o sea visualizar la letra
                e.Handled = true;
            }
        }

        private void txtNombreEntrenador_TextChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }

        private void txtApellidoEntrenador_TextChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }

        private void txtDireccionEntrenador_TextChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }

        private void lstDeporteEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
