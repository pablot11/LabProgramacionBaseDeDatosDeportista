namespace pryTorresBaseDeDatos
{
    partial class frmEliminarOModificarDeportistas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarOModificarDeportistas));
            this.mrcBuscarDeportista = new System.Windows.Forms.GroupBox();
            this.lblCodigoDeportistaBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarDeportista = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mskCodigoDeportistaBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoDeportistaBusqueda = new System.Windows.Forms.TextBox();
            this.mrcDatosDeportistas = new System.Windows.Forms.GroupBox();
            this.lblDeporteDeportista = new System.Windows.Forms.Label();
            this.txtDeporteDeportista = new System.Windows.Forms.TextBox();
            this.txtEdadDeportista = new System.Windows.Forms.TextBox();
            this.lblEdadDeportista = new System.Windows.Forms.Label();
            this.lblTelefonoDeportista = new System.Windows.Forms.Label();
            this.lblDireccionDeportista = new System.Windows.Forms.Label();
            this.lblApellidoDeportista = new System.Windows.Forms.Label();
            this.lblNombreDeportista = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.txtTelefonoDeportista = new System.Windows.Forms.TextBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.btnEliminarDeportista = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mrcBuscarDeportista.SuspendLayout();
            this.mrcDatosDeportistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcBuscarDeportista
            // 
            this.mrcBuscarDeportista.Controls.Add(this.lblCodigoDeportistaBusqueda);
            this.mrcBuscarDeportista.Controls.Add(this.btnBuscarDeportista);
            this.mrcBuscarDeportista.Controls.Add(this.btnSalir);
            this.mrcBuscarDeportista.Controls.Add(this.mskCodigoDeportistaBusqueda);
            this.mrcBuscarDeportista.Controls.Add(this.txtCodigoDeportistaBusqueda);
            this.mrcBuscarDeportista.Location = new System.Drawing.Point(10, 12);
            this.mrcBuscarDeportista.Name = "mrcBuscarDeportista";
            this.mrcBuscarDeportista.Size = new System.Drawing.Size(238, 87);
            this.mrcBuscarDeportista.TabIndex = 0;
            this.mrcBuscarDeportista.TabStop = false;
            this.mrcBuscarDeportista.Text = "Buscar Deportista:";
            // 
            // lblCodigoDeportistaBusqueda
            // 
            this.lblCodigoDeportistaBusqueda.AutoSize = true;
            this.lblCodigoDeportistaBusqueda.Location = new System.Drawing.Point(17, 32);
            this.lblCodigoDeportistaBusqueda.Name = "lblCodigoDeportistaBusqueda";
            this.lblCodigoDeportistaBusqueda.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoDeportistaBusqueda.TabIndex = 6;
            this.lblCodigoDeportistaBusqueda.Text = "Codigo Deportista:";
            // 
            // btnBuscarDeportista
            // 
            this.btnBuscarDeportista.Enabled = false;
            this.btnBuscarDeportista.Location = new System.Drawing.Point(134, 58);
            this.btnBuscarDeportista.Name = "btnBuscarDeportista";
            this.btnBuscarDeportista.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDeportista.TabIndex = 2;
            this.btnBuscarDeportista.Text = "Buscar";
            this.btnBuscarDeportista.UseVisualStyleBackColor = true;
            this.btnBuscarDeportista.Click += new System.EventHandler(this.btnBuscarDeportista_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(36, 58);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mskCodigoDeportistaBusqueda
            // 
            this.mskCodigoDeportistaBusqueda.Location = new System.Drawing.Point(126, 32);
            this.mskCodigoDeportistaBusqueda.Mask = "AAAAA";
            this.mskCodigoDeportistaBusqueda.Name = "mskCodigoDeportistaBusqueda";
            this.mskCodigoDeportistaBusqueda.Size = new System.Drawing.Size(83, 20);
            this.mskCodigoDeportistaBusqueda.TabIndex = 1;
            this.mskCodigoDeportistaBusqueda.MaskChanged += new System.EventHandler(this.mskCodigoDeportistaBusqueda_MaskChanged);
            this.mskCodigoDeportistaBusqueda.TextChanged += new System.EventHandler(this.mskCodigoDeportistaBusqueda_TextChanged);
            // 
            // txtCodigoDeportistaBusqueda
            // 
            this.txtCodigoDeportistaBusqueda.Location = new System.Drawing.Point(134, 32);
            this.txtCodigoDeportistaBusqueda.Name = "txtCodigoDeportistaBusqueda";
            this.txtCodigoDeportistaBusqueda.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoDeportistaBusqueda.TabIndex = 0;
            // 
            // mrcDatosDeportistas
            // 
            this.mrcDatosDeportistas.Controls.Add(this.lblDeporteDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtDeporteDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtEdadDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblEdadDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblTelefonoDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblDireccionDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblApellidoDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblNombreDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.lblCodigoDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtNombreDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtApellidoDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtDireccionDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtTelefonoDeportista);
            this.mrcDatosDeportistas.Controls.Add(this.txtCodigoDeportista);
            this.mrcDatosDeportistas.Location = new System.Drawing.Point(11, 105);
            this.mrcDatosDeportistas.Name = "mrcDatosDeportistas";
            this.mrcDatosDeportistas.Size = new System.Drawing.Size(237, 240);
            this.mrcDatosDeportistas.TabIndex = 1;
            this.mrcDatosDeportistas.TabStop = false;
            this.mrcDatosDeportistas.Text = "Datos Deportista";
            this.mrcDatosDeportistas.Enter += new System.EventHandler(this.mrcDatosDeportistas_Enter);
            // 
            // lblDeporteDeportista
            // 
            this.lblDeporteDeportista.AutoSize = true;
            this.lblDeporteDeportista.Location = new System.Drawing.Point(16, 185);
            this.lblDeporteDeportista.Name = "lblDeporteDeportista";
            this.lblDeporteDeportista.Size = new System.Drawing.Size(48, 13);
            this.lblDeporteDeportista.TabIndex = 13;
            this.lblDeporteDeportista.Text = "Deporte:";
            // 
            // txtDeporteDeportista
            // 
            this.txtDeporteDeportista.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDeporteDeportista.Location = new System.Drawing.Point(108, 185);
            this.txtDeporteDeportista.Name = "txtDeporteDeportista";
            this.txtDeporteDeportista.ReadOnly = true;
            this.txtDeporteDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtDeporteDeportista.TabIndex = 12;
            // 
            // txtEdadDeportista
            // 
            this.txtEdadDeportista.Location = new System.Drawing.Point(157, 159);
            this.txtEdadDeportista.Name = "txtEdadDeportista";
            this.txtEdadDeportista.ReadOnly = true;
            this.txtEdadDeportista.Size = new System.Drawing.Size(51, 20);
            this.txtEdadDeportista.TabIndex = 11;
            // 
            // lblEdadDeportista
            // 
            this.lblEdadDeportista.AutoSize = true;
            this.lblEdadDeportista.Location = new System.Drawing.Point(16, 159);
            this.lblEdadDeportista.Name = "lblEdadDeportista";
            this.lblEdadDeportista.Size = new System.Drawing.Size(35, 13);
            this.lblEdadDeportista.TabIndex = 10;
            this.lblEdadDeportista.Text = "Edad:";
            // 
            // lblTelefonoDeportista
            // 
            this.lblTelefonoDeportista.AutoSize = true;
            this.lblTelefonoDeportista.Location = new System.Drawing.Point(16, 133);
            this.lblTelefonoDeportista.Name = "lblTelefonoDeportista";
            this.lblTelefonoDeportista.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoDeportista.TabIndex = 9;
            this.lblTelefonoDeportista.Text = "Telefono:";
            // 
            // lblDireccionDeportista
            // 
            this.lblDireccionDeportista.AutoSize = true;
            this.lblDireccionDeportista.Location = new System.Drawing.Point(16, 107);
            this.lblDireccionDeportista.Name = "lblDireccionDeportista";
            this.lblDireccionDeportista.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionDeportista.TabIndex = 8;
            this.lblDireccionDeportista.Text = "Dirección:";
            // 
            // lblApellidoDeportista
            // 
            this.lblApellidoDeportista.AutoSize = true;
            this.lblApellidoDeportista.Location = new System.Drawing.Point(16, 81);
            this.lblApellidoDeportista.Name = "lblApellidoDeportista";
            this.lblApellidoDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoDeportista.TabIndex = 7;
            this.lblApellidoDeportista.Text = "Apellido:";
            // 
            // lblNombreDeportista
            // 
            this.lblNombreDeportista.AutoSize = true;
            this.lblNombreDeportista.Location = new System.Drawing.Point(16, 55);
            this.lblNombreDeportista.Name = "lblNombreDeportista";
            this.lblNombreDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDeportista.TabIndex = 6;
            this.lblNombreDeportista.Text = "Nombre:";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(16, 32);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoDeportista.TabIndex = 5;
            this.lblCodigoDeportista.Text = "Codigo Deportista:";
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.Location = new System.Drawing.Point(108, 55);
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.ReadOnly = true;
            this.txtNombreDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDeportista.TabIndex = 4;
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.Location = new System.Drawing.Point(108, 81);
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.ReadOnly = true;
            this.txtApellidoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDeportista.TabIndex = 3;
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.Location = new System.Drawing.Point(108, 107);
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.ReadOnly = true;
            this.txtDireccionDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionDeportista.TabIndex = 2;
            // 
            // txtTelefonoDeportista
            // 
            this.txtTelefonoDeportista.Location = new System.Drawing.Point(108, 133);
            this.txtTelefonoDeportista.Name = "txtTelefonoDeportista";
            this.txtTelefonoDeportista.ReadOnly = true;
            this.txtTelefonoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDeportista.TabIndex = 1;
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(157, 32);
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.ReadOnly = true;
            this.txtCodigoDeportista.Size = new System.Drawing.Size(51, 20);
            this.txtCodigoDeportista.TabIndex = 0;
            // 
            // btnEliminarDeportista
            // 
            this.btnEliminarDeportista.Enabled = false;
            this.btnEliminarDeportista.Location = new System.Drawing.Point(10, 351);
            this.btnEliminarDeportista.Name = "btnEliminarDeportista";
            this.btnEliminarDeportista.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDeportista.TabIndex = 7;
            this.btnEliminarDeportista.Text = "Eliminar";
            this.btnEliminarDeportista.UseVisualStyleBackColor = true;
            this.btnEliminarDeportista.Click += new System.EventHandler(this.btnEliminarDeportista_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(173, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(92, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEliminarOModificarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 381);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.mrcDatosDeportistas);
            this.Controls.Add(this.btnEliminarDeportista);
            this.Controls.Add(this.mrcBuscarDeportista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarOModificarDeportistas";
            this.Text = "Gestion Deportistas";
            this.mrcBuscarDeportista.ResumeLayout(false);
            this.mrcBuscarDeportista.PerformLayout();
            this.mrcDatosDeportistas.ResumeLayout(false);
            this.mrcDatosDeportistas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcBuscarDeportista;
        private System.Windows.Forms.Label lblCodigoDeportistaBusqueda;
        private System.Windows.Forms.Button btnBuscarDeportista;
        private System.Windows.Forms.MaskedTextBox mskCodigoDeportistaBusqueda;
        private System.Windows.Forms.TextBox txtCodigoDeportistaBusqueda;
        private System.Windows.Forms.GroupBox mrcDatosDeportistas;
        private System.Windows.Forms.Label lblTelefonoDeportista;
        private System.Windows.Forms.Label lblDireccionDeportista;
        private System.Windows.Forms.Label lblApellidoDeportista;
        private System.Windows.Forms.Label lblNombreDeportista;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.TextBox txtTelefonoDeportista;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarDeportista;
        private System.Windows.Forms.Label lblDeporteDeportista;
        private System.Windows.Forms.TextBox txtDeporteDeportista;
        private System.Windows.Forms.TextBox txtEdadDeportista;
        private System.Windows.Forms.Label lblEdadDeportista;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}