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
    public partial class frmConsultaEntrenador : Form
    {
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;
        string varRutaAccesoBD = "DEPORTE.accdb";
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEntrenadoresConsulta.DataSource = null;
            dgvEntrenadoresConsulta.Rows.Clear();
            clsEntrenador objEntrenador= new clsEntrenador();
            objEntrenador.Listar(dgvEntrenadoresConsulta);
        }

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
