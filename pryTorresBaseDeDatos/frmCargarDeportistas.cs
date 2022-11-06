using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryTorresBaseDeDatos
{
    public partial class frmCargarDeportistas : Form
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
        public frmCargarDeportistas()
        {
            InitializeComponent();
        }

        private void frmCargarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarDeportista_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            string Nombre = txtNombreDeportista.Text;
            string Apellido = txtApellidoDeportista.Text;
            string Direccion = Convert.ToString(txtDireccionDeportista.Text);
            string Telefono = mskTelefonoDeportista.Text;
            string Edad = mskEdadDeportista.Text;
            string Deporte = Convert.ToString(lstDeporteDeportista.SelectedItem);
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
                comandoBd.CommandText = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    " VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";
                //ejecuta el comando
                comandoBd.ExecuteNonQuery();
                MessageBox.Show("Deportista Cargado");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show("No se pudo cargar el deportista" + mensaje.Message);
            }
            LimpiarControles();

            conexionBd.Close();
        }

        private void btncargarrr_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            txtCodigoDeportista.Text = "";
            txtNombreDeportista.Text = "";
            txtApellidoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            mskEdadDeportista.Text = "";
            mskTelefonoDeportista.Text = "";
            lstDeporteDeportista.SelectedIndex = -1;

        }
        private void ChequearControles()
        {
            if (txtCodigoDeportista.Text != "" && txtNombreDeportista.Text != "" && txtApellidoDeportista.Text != "" && txtDireccionDeportista.Text != "" 
                && mskEdadDeportista.Text != "" && mskTelefonoDeportista.Text != "" && lstDeporteDeportista.SelectedIndex != -1)
            {
                btnCargarDeportista.Enabled = true;    
            }
            else
            {
                btnCargarDeportista.Enabled = false;
            }

        }

        private void mskCodigoDeportista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ChequearControles();
        }

        private void txtNombreDeportista_TextChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void txtApellidoDeportista_TextChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void txtDireccionDeportista_TextChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void txtTelefonoDeportista_TextChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void txtEdadDeportista_TextChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void lstDeporteDeportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChequearControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtApellidoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }
    }   
}
