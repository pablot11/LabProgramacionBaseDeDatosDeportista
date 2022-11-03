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
    public partial class frmMain : Form
    {
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;
        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public frmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarDeportistas objVentanaCargaDeportistas = new frmCargarDeportistas();
            objVentanaCargaDeportistas.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         
            try
            {
                lblFecha.Text = DateTime.Now.ToString();

                conexionBase = new OleDbConnection(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+
                    varRutaAccesoBD);

                conexionBase.Open();

                lblEstado.Text = "Conectado";

                statusPrincipal.BackColor = Color.GreenYellow;
            }
            catch (Exception mensajito)
            {
                lblEstado.Text = mensajito.Message;
      
                statusPrincipal.BackColor = Color.Red;
 
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCargarDeportistas objVentanaCargaDeportistas = new frmCargarDeportistas();
            objVentanaCargaDeportistas.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista objVentanaConsultaDeportista = new frmConsultaDeportista();
            objVentanaConsultaDeportista.ShowDialog();
         
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador objVentanaConsultaEntrenador = new frmConsultaEntrenador();
            objVentanaConsultaEntrenador.ShowDialog();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarEntrenador objVentanaCargarEntrenador = new frmCargarEntrenador();
            objVentanaCargarEntrenador.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEliminarOModificarDeportistas objVentanaDeportistas = new frmEliminarOModificarDeportistas();
            objVentanaDeportistas.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminarOModificarDeportistas objVentanaEliminarOModificarDeportista = new frmEliminarOModificarDeportistas();
            objVentanaEliminarOModificarDeportista.ShowDialog();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEliminarOModificarEntrenadores objVentanaEliminarOModificarEntrenador = new frmEliminarOModificarEntrenadores();
            objVentanaEliminarOModificarEntrenador.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
