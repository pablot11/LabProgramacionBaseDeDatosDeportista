using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresBaseDeDatos
{
    public partial class frmEliminarOModificarDeportistas : Form
    {
        public frmEliminarOModificarDeportistas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarDeportista_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigoDeportistaBusqueda.Text;
            clsDeportista objclsDeportista = new clsDeportista();
            objclsDeportista.Buscar(varCodigo);
            if (objclsDeportista.CDeportista != varCodigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
                btnEliminarDeportista.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                LimpiarControles();

            }
            else
            {
                txtCodigoDeportista.Text = objclsDeportista.CDeportista;
                txtNombreDeportista.Text = objclsDeportista.Nombre;
                txtApellidoDeportista.Text = objclsDeportista.Apellido;
                txtDireccionDeportista.Text = objclsDeportista.Direccion;
                mskTelefonoDeportistaModificar.Text = Convert.ToString(objclsDeportista.Telefono);
                mskEdadDeportistaModificar.Text = Convert.ToString(objclsDeportista.Edad);
                txtDeporteDeportista.Text = Convert.ToString(objclsDeportista.Deportes);
                btnEliminarDeportista.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;

            }
       


        }

        private void btnEliminarDeportista_Click(object sender, EventArgs e)
        {
            string varCodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista EliminarDeportista = new clsDeportista();
            EliminarDeportista.Eliminar(varCodigoDeportista);
            MessageBox.Show("Dato del deportista eliminado");
            LimpiarControles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NoLecturaCajasDeTexto();
            btnModificar.Enabled = false;
            btnBuscarDeportista.Enabled = false;
            txtCodigoDeportistaBusqueda.ReadOnly = true;
            btnEliminarDeportista.Enabled = false;
            btnGuardar.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista ModificarED = new clsDeportista();
            ModificarED.Direccion = txtDireccionDeportista.Text;
            ModificarED.Telefono = Convert.ToInt32(mskTelefonoDeportistaModificar.Text);
            ModificarED.Edad = Convert.ToInt32(mskEdadDeportistaModificar.Text);
            ModificarED.Deportes = txtDeporteDeportista.Text;
            ModificarED.Telefono = Convert.ToInt32(mskTelefonoDeportistaModificar.Text);
            ModificarED.Modificar(CodigoDeportista);
      
            btnModificar.Enabled = true;
            txtCodigoDeportistaBusqueda.ReadOnly = false;
            btnBuscarDeportista.Enabled = true;
            btnEliminarDeportista.Enabled = true;
            btnGuardar.Enabled = false;
            LecturaCajasDeTexto();
        }

      
        private void LimpiarControles()
        {
            txtCodigoDeportista.Text = "";
            txtNombreDeportista.Text = "";
            txtApellidoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            mskTelefonoDeportistaModificar.Text = "";
            mskEdadDeportistaModificar.Text = "";
            txtDeporteDeportista.Text = "";
            txtCodigoDeportistaBusqueda.Text = "";
        }

       

        private void txtCodigoDeportistaBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtCodigoDeportistaBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoDeportistaBusqueda.Text != "")
            {
                btnBuscarDeportista.Enabled = true;
            }
            else
            {
                btnBuscarDeportista.Enabled = false;
            }
        }
        private void frmEliminarOModificarDeportistas_Load(object sender, EventArgs e)
        {
            mskTelefonoDeportistaModificar.ReadOnly = true;
            mskEdadDeportistaModificar.ReadOnly = true;
        }


        private void LecturaCajasDeTexto()
        {
            mskTelefonoDeportistaModificar.ReadOnly = true;
            mskEdadDeportistaModificar.ReadOnly = true;
            txtDeporteDeportista.ReadOnly = true;
            txtDireccionDeportista.ReadOnly = true;
            txtDeporteDeportista.ReadOnly = true;
        }
        private void NoLecturaCajasDeTexto()
        {

            mskTelefonoDeportistaModificar.ReadOnly = false;
            mskEdadDeportistaModificar.ReadOnly = false;
            txtDeporteDeportista.ReadOnly = false;
            txtDireccionDeportista.ReadOnly = false;
            txtDeporteDeportista.ReadOnly = false;

        }
        private void txtDeporteDeportista_KeyPress(object sender, KeyPressEventArgs e)
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
