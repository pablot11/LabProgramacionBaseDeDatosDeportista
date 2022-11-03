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
    public partial class frmConsultaDeportista : Form
    {
       
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;
        string varRutaAccesoBD = "DEPORTE.accdb";
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //
            dgvDeportistasConsulta.DataSource = null;
            dgvDeportistasConsulta.Rows.Clear();
            clsDeportista objDeportista = new clsDeportista();
            objDeportista.Listar(dgvDeportistasConsulta);
        }

        private void dgvDeportistasConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
