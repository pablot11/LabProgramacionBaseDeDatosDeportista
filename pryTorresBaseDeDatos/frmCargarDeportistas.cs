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
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;

        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmCargarDeportistas()
        {
            InitializeComponent();
        }

        private void frmCargarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarDeportista_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = mskCodigoDeportista.Text;
            string Nombre = txtNombreDeportista.Text;
            string Apellido = txtApellidoDeportista.Text;
            string Direccion = Convert.ToString(txtDireccionDeportista.Text);
            string Telefono = txtTelefonoDeportista.Text;
            string Edad = txtEdadDeportista.Text;
            string Deporte = Convert.ToString(lstDeporteDeportista.SelectedItem);
            try
            {
                conexionBase = new OleDbConnection(varRutaAccesoBD);
                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();

                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.Text;

                queQuieroDeLaBase.CommandText = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    " VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";

                queQuieroDeLaBase.ExecuteNonQuery();
                MessageBox.Show("Deportista Cargado");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show("No se pudo cargar el deportista" + mensaje.Message);
            }
            LimpiarControles();

            conexionBase.Close();
        }

        private void btncargarrr_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            mskCodigoDeportista.Text = "";
            txtNombreDeportista.Text = "";
            txtApellidoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            txtEdadDeportista.Text = "";
            txtTelefonoDeportista.Text = "";
            lstDeporteDeportista.SelectedIndex = -1;

        }
        private void ChequearControles()
        {
            if (mskCodigoDeportista.Text != "" && txtNombreDeportista.Text != "" && txtApellidoDeportista.Text != "" && txtDireccionDeportista.Text != "" 
                && txtEdadDeportista.Text != "" && txtTelefonoDeportista.Text != "" && lstDeporteDeportista.SelectedIndex != -1)
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
    }   
}
