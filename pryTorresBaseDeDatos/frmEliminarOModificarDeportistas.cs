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
            string varCodigo = mskCodigoDeportistaBusqueda.Text;
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
                txtTelefonoDeportista.Text = Convert.ToString(objclsDeportista.Telefono);
                txtEdadDeportista.Text = Convert.ToString(objclsDeportista.Edad);
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
            txtTelefonoDeportista.ReadOnly = false;
            txtEdadDeportista.ReadOnly = false;
            txtDeporteDeportista.ReadOnly = false;
            txtDireccionDeportista.ReadOnly = false;
            btnModificar.Enabled = false;
            btnBuscarDeportista.Enabled = false;
            mskCodigoDeportistaBusqueda.ReadOnly = true;
            btnEliminarDeportista.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista ModificarED = new clsDeportista();
            ModificarED.Direccion = txtDireccionDeportista.Text;
            ModificarED.Telefono = Convert.ToInt32(txtTelefonoDeportista.Text);
            ModificarED.Edad = Convert.ToInt32(txtEdadDeportista.Text);
            ModificarED.Deportes = txtDeporteDeportista.Text;
            ModificarED.Modificar(CodigoDeportista);
            ModificarED.Telefono = Convert.ToInt32(txtTelefonoDeportista.Text);
            btnModificar.Enabled = true;
            mskCodigoDeportistaBusqueda.ReadOnly = false;
            btnBuscarDeportista.Enabled = true;
            btnEliminarDeportista.Enabled = true;
        }

        private void mrcDatosDeportistas_Enter(object sender, EventArgs e)
        {

        }

        private void mskCodigoDeportistaBusqueda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
        private void LimpiarControles()
        {
            txtCodigoDeportista.Text = "";
            txtNombreDeportista.Text = "";
            txtApellidoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            txtTelefonoDeportista.Text = "";
            txtEdadDeportista.Text = "";
            txtDeporteDeportista.Text = "";
            mskCodigoDeportistaBusqueda.Text = "";
        }

        private void mskCodigoDeportistaBusqueda_MaskChanged(object sender, EventArgs e)
        {
       

        }

        private void mskCodigoDeportistaBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (mskCodigoDeportistaBusqueda.Text != "")
            {
                btnBuscarDeportista.Enabled = true;
            }
            else
            {
                btnBuscarDeportista.Enabled = false;
            }
        }
    }
}
