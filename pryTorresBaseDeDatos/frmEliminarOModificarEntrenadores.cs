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
    public partial class frmEliminarOModificarEntrenadores : Form
    {
        public frmEliminarOModificarEntrenadores()
        {
            InitializeComponent();
        }

        private void btnBuscarEntrenador_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigoEntrenadorBusqueda.Text;
            clsEntrenador objclsEntrenador = new clsEntrenador();
            objclsEntrenador.Buscar(varCodigo);
            if (objclsEntrenador.varBandera == false)
            {
                txtCodigoEntrenador.Text = objclsEntrenador.CEntrenador;
                txtNombreEntrenador.Text = objclsEntrenador.Nombre;
                txtApellidoEntrenador.Text = objclsEntrenador.Apellido;
                txtDireccionEntrenador.Text = objclsEntrenador.Direccion;
                txtProvinciaEntrenador.Text = objclsEntrenador.Provincia;
                txtDeporteEntrenador.Text = objclsEntrenador.Deportes;
                btnEliminarEntrenador.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;


            }
            else
            {
                MessageBox.Show("No esta registrado en la base de datos");
                btnEliminarEntrenador.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                LimpiarControles();
            }
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NoLecturaCajasDeTexto();
            btnModificar.Enabled = false;
            btnBuscarEntrenador.Enabled = false;
            txtCodigoEntrenadorBusqueda.ReadOnly = true;
            btnEliminarEntrenador.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void frmEliminarOModificarEntrenadores_Load(object sender, EventArgs e)
        {
         
        }

        private void btnEliminarEntrenador_Click(object sender, EventArgs e)
        {
            string varCodigoEntrenador = txtCodigoEntrenador.Text;
            clsEntrenador EliminarEntrenador = new clsEntrenador();
            EliminarEntrenador.Eliminar(varCodigoEntrenador);
            MessageBox.Show("Dato del deportista eliminado");
            LimpiarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenador = txtCodigoEntrenador.Text;
            clsEntrenador ModificarED = new clsEntrenador();
            ModificarED.Direccion = txtDireccionEntrenador.Text;
            ModificarED.Deportes = txtDeporteEntrenador.Text;
            ModificarED.Provincia = txtProvinciaEntrenador.Text;
            ModificarED.Modificar(CodigoEntrenador);
    
            btnModificar.Enabled = true;
            txtCodigoEntrenadorBusqueda.ReadOnly = false;
            btnBuscarEntrenador.Enabled = true;
            btnEliminarEntrenador.Enabled = true;
            btnGuardar.Enabled = false;
            LecturaCajasDeTexto();
        }

        private void LimpiarControles()
        {
            txtCodigoEntrenadorBusqueda.Text = "";
            txtCodigoEntrenador.Text = "";
            txtNombreEntrenador.Text = "";
            txtApellidoEntrenador.Text = "";
            txtCodigoEntrenador.Text = "";
            txtDireccionEntrenador.Text = "";
            txtProvinciaEntrenador.Text = "";
            txtDeporteEntrenador.Text = "";
        }

        private void mskCodigoEntrenadorBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoEntrenadorBusqueda.Text != "")
            {
                btnBuscarEntrenador.Enabled = true;
            }
            else
            {
                btnBuscarEntrenador.Enabled = false;
            }
        }

        private void txtProvinciaEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void LecturaCajasDeTexto()
        {
            txtDeporteEntrenador.ReadOnly = true;
            txtDireccionEntrenador.ReadOnly = true;
            txtProvinciaEntrenador.ReadOnly = true;

        }
        private void NoLecturaCajasDeTexto()
        {
            txtDeporteEntrenador.ReadOnly = false;
            txtDireccionEntrenador.ReadOnly = false;
            txtProvinciaEntrenador.ReadOnly = false;
        }

        private void txtDeporteEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtCodigoEntrenadorBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar indica si la tecla presionada ya que recoge el numero ascii de la tecla y verifica que no sea numeros,caracteres especiales
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //El handled controla el evento y permite que no se muestren los valores
                e.Handled = true;
            }
        }

        private void txtCodigoEntrenadorBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoEntrenadorBusqueda.Text != "")
            {
                btnBuscarEntrenador.Enabled = true;
            }
            else
            {
                btnBuscarEntrenador.Enabled = false;
            }
        }

        private void mrcBuscarEntrenador_Enter(object sender, EventArgs e)
        {

        }
    }
}
