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
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;

        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmCargarEntrenador()
        {
            InitializeComponent();
        }

        private void txtNombreEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void frmCargarEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarEntrenador_Click(object sender, EventArgs e)
        {
           
            string CodigoEntrenador = mskCodigoEntrenador.Text;
            string Nombre = txtNombreEntrenador.Text;
            string Apellido = txtApellidoEntrenador.Text;
            string Direccion = Convert.ToString(txtDireccionEntrenador.Text);
            string Provincia = txtProvinciaEntrenador.Text;
            string Deporte = Convert.ToString(lstDeporteEntrenador.SelectedItem);
            try
            {
                conexionBase = new OleDbConnection(varRutaAccesoBD);
                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();

                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.Text;

                queQuieroDeLaBase.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO ENTRENADOR], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    " VALUES ('" + CodigoEntrenador + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";

                queQuieroDeLaBase.ExecuteNonQuery();
                MessageBox.Show("Entrenador Cargado");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el entrenador");
            }

            conexionBase.Close();
        }
    }
}
