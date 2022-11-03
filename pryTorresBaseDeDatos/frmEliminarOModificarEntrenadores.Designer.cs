namespace pryTorresBaseDeDatos
{
    partial class frmEliminarOModificarEntrenadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarOModificarEntrenadores));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarEntrenador = new System.Windows.Forms.Button();
            this.mrcBuscarEntrenador = new System.Windows.Forms.GroupBox();
            this.lblCodigoEntrenadorBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarEntrenador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mskCodigoEntrenadorBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoEntrenadorBusqueda = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.txtDireccionEntrenador = new System.Windows.Forms.TextBox();
            this.txtApellidoEntrenador = new System.Windows.Forms.TextBox();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.lblNombreEntrenador = new System.Windows.Forms.Label();
            this.lblApellidoEntrenador = new System.Windows.Forms.Label();
            this.lblDireccionEntrenador = new System.Windows.Forms.Label();
            this.lblProvinciaEntrenador = new System.Windows.Forms.Label();
            this.txtProvinciaEntrenador = new System.Windows.Forms.TextBox();
            this.txtDeporteEntrenador = new System.Windows.Forms.TextBox();
            this.lblDeporteEntrenador = new System.Windows.Forms.Label();
            this.mrcDatosEntrenador = new System.Windows.Forms.GroupBox();
            this.mrcBuscarEntrenador.SuspendLayout();
            this.mrcDatosEntrenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(95, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(176, 303);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarEntrenador
            // 
            this.btnEliminarEntrenador.Enabled = false;
            this.btnEliminarEntrenador.Location = new System.Drawing.Point(13, 303);
            this.btnEliminarEntrenador.Name = "btnEliminarEntrenador";
            this.btnEliminarEntrenador.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEntrenador.TabIndex = 19;
            this.btnEliminarEntrenador.Text = "Eliminar";
            this.btnEliminarEntrenador.UseVisualStyleBackColor = true;
            this.btnEliminarEntrenador.Click += new System.EventHandler(this.btnEliminarEntrenador_Click);
            // 
            // mrcBuscarEntrenador
            // 
            this.mrcBuscarEntrenador.Controls.Add(this.lblCodigoEntrenadorBusqueda);
            this.mrcBuscarEntrenador.Controls.Add(this.btnBuscarEntrenador);
            this.mrcBuscarEntrenador.Controls.Add(this.btnSalir);
            this.mrcBuscarEntrenador.Controls.Add(this.mskCodigoEntrenadorBusqueda);
            this.mrcBuscarEntrenador.Controls.Add(this.txtCodigoEntrenadorBusqueda);
            this.mrcBuscarEntrenador.Location = new System.Drawing.Point(12, 12);
            this.mrcBuscarEntrenador.Name = "mrcBuscarEntrenador";
            this.mrcBuscarEntrenador.Size = new System.Drawing.Size(238, 87);
            this.mrcBuscarEntrenador.TabIndex = 17;
            this.mrcBuscarEntrenador.TabStop = false;
            this.mrcBuscarEntrenador.Text = "Buscar Entrenador:";
            // 
            // lblCodigoEntrenadorBusqueda
            // 
            this.lblCodigoEntrenadorBusqueda.AutoSize = true;
            this.lblCodigoEntrenadorBusqueda.Location = new System.Drawing.Point(17, 32);
            this.lblCodigoEntrenadorBusqueda.Name = "lblCodigoEntrenadorBusqueda";
            this.lblCodigoEntrenadorBusqueda.Size = new System.Drawing.Size(98, 13);
            this.lblCodigoEntrenadorBusqueda.TabIndex = 6;
            this.lblCodigoEntrenadorBusqueda.Text = "Codigo Entrenador:";
            // 
            // btnBuscarEntrenador
            // 
            this.btnBuscarEntrenador.Enabled = false;
            this.btnBuscarEntrenador.Location = new System.Drawing.Point(134, 58);
            this.btnBuscarEntrenador.Name = "btnBuscarEntrenador";
            this.btnBuscarEntrenador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEntrenador.TabIndex = 2;
            this.btnBuscarEntrenador.Text = "Buscar";
            this.btnBuscarEntrenador.UseVisualStyleBackColor = true;
            this.btnBuscarEntrenador.Click += new System.EventHandler(this.btnBuscarEntrenador_Click);
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
            // mskCodigoEntrenadorBusqueda
            // 
            this.mskCodigoEntrenadorBusqueda.Location = new System.Drawing.Point(126, 32);
            this.mskCodigoEntrenadorBusqueda.Mask = "AAAAA";
            this.mskCodigoEntrenadorBusqueda.Name = "mskCodigoEntrenadorBusqueda";
            this.mskCodigoEntrenadorBusqueda.Size = new System.Drawing.Size(83, 20);
            this.mskCodigoEntrenadorBusqueda.TabIndex = 1;
            this.mskCodigoEntrenadorBusqueda.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoEntrenadorBusqueda_MaskInputRejected);
            this.mskCodigoEntrenadorBusqueda.TextChanged += new System.EventHandler(this.mskCodigoEntrenadorBusqueda_TextChanged);
            // 
            // txtCodigoEntrenadorBusqueda
            // 
            this.txtCodigoEntrenadorBusqueda.Location = new System.Drawing.Point(134, 32);
            this.txtCodigoEntrenadorBusqueda.Name = "txtCodigoEntrenadorBusqueda";
            this.txtCodigoEntrenadorBusqueda.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoEntrenadorBusqueda.TabIndex = 0;
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(157, 32);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.ReadOnly = true;
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(51, 20);
            this.txtCodigoEntrenador.TabIndex = 0;
            // 
            // txtDireccionEntrenador
            // 
            this.txtDireccionEntrenador.Location = new System.Drawing.Point(108, 107);
            this.txtDireccionEntrenador.Name = "txtDireccionEntrenador";
            this.txtDireccionEntrenador.ReadOnly = true;
            this.txtDireccionEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionEntrenador.TabIndex = 2;
            // 
            // txtApellidoEntrenador
            // 
            this.txtApellidoEntrenador.Location = new System.Drawing.Point(108, 81);
            this.txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            this.txtApellidoEntrenador.ReadOnly = true;
            this.txtApellidoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEntrenador.TabIndex = 3;
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.Location = new System.Drawing.Point(108, 55);
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.ReadOnly = true;
            this.txtNombreEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntrenador.TabIndex = 4;
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(16, 32);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(98, 13);
            this.lblCodigoEntrenador.TabIndex = 5;
            this.lblCodigoEntrenador.Text = "Codigo Entrenador:";
            // 
            // lblNombreEntrenador
            // 
            this.lblNombreEntrenador.AutoSize = true;
            this.lblNombreEntrenador.Location = new System.Drawing.Point(16, 55);
            this.lblNombreEntrenador.Name = "lblNombreEntrenador";
            this.lblNombreEntrenador.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEntrenador.TabIndex = 6;
            this.lblNombreEntrenador.Text = "Nombre:";
            // 
            // lblApellidoEntrenador
            // 
            this.lblApellidoEntrenador.AutoSize = true;
            this.lblApellidoEntrenador.Location = new System.Drawing.Point(16, 81);
            this.lblApellidoEntrenador.Name = "lblApellidoEntrenador";
            this.lblApellidoEntrenador.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoEntrenador.TabIndex = 7;
            this.lblApellidoEntrenador.Text = "Apellido:";
            // 
            // lblDireccionEntrenador
            // 
            this.lblDireccionEntrenador.AutoSize = true;
            this.lblDireccionEntrenador.Location = new System.Drawing.Point(16, 107);
            this.lblDireccionEntrenador.Name = "lblDireccionEntrenador";
            this.lblDireccionEntrenador.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionEntrenador.TabIndex = 8;
            this.lblDireccionEntrenador.Text = "Dirección:";
            // 
            // lblProvinciaEntrenador
            // 
            this.lblProvinciaEntrenador.AutoSize = true;
            this.lblProvinciaEntrenador.Location = new System.Drawing.Point(16, 133);
            this.lblProvinciaEntrenador.Name = "lblProvinciaEntrenador";
            this.lblProvinciaEntrenador.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaEntrenador.TabIndex = 10;
            this.lblProvinciaEntrenador.Text = "Provincia:";
            // 
            // txtProvinciaEntrenador
            // 
            this.txtProvinciaEntrenador.Location = new System.Drawing.Point(108, 133);
            this.txtProvinciaEntrenador.Name = "txtProvinciaEntrenador";
            this.txtProvinciaEntrenador.ReadOnly = true;
            this.txtProvinciaEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtProvinciaEntrenador.TabIndex = 11;
            // 
            // txtDeporteEntrenador
            // 
            this.txtDeporteEntrenador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDeporteEntrenador.Location = new System.Drawing.Point(108, 159);
            this.txtDeporteEntrenador.Name = "txtDeporteEntrenador";
            this.txtDeporteEntrenador.ReadOnly = true;
            this.txtDeporteEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtDeporteEntrenador.TabIndex = 12;
            // 
            // lblDeporteEntrenador
            // 
            this.lblDeporteEntrenador.AutoSize = true;
            this.lblDeporteEntrenador.Location = new System.Drawing.Point(16, 159);
            this.lblDeporteEntrenador.Name = "lblDeporteEntrenador";
            this.lblDeporteEntrenador.Size = new System.Drawing.Size(48, 13);
            this.lblDeporteEntrenador.TabIndex = 13;
            this.lblDeporteEntrenador.Text = "Deporte:";
            // 
            // mrcDatosEntrenador
            // 
            this.mrcDatosEntrenador.Controls.Add(this.lblDeporteEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtDeporteEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtProvinciaEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.lblProvinciaEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.lblDireccionEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.lblApellidoEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.lblNombreEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.lblCodigoEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtNombreEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtApellidoEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtDireccionEntrenador);
            this.mrcDatosEntrenador.Controls.Add(this.txtCodigoEntrenador);
            this.mrcDatosEntrenador.Location = new System.Drawing.Point(13, 105);
            this.mrcDatosEntrenador.Name = "mrcDatosEntrenador";
            this.mrcDatosEntrenador.Size = new System.Drawing.Size(237, 192);
            this.mrcDatosEntrenador.TabIndex = 18;
            this.mrcDatosEntrenador.TabStop = false;
            this.mrcDatosEntrenador.Text = "Datos Entrenador";
            // 
            // frmEliminarOModificarEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 332);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.mrcDatosEntrenador);
            this.Controls.Add(this.btnEliminarEntrenador);
            this.Controls.Add(this.mrcBuscarEntrenador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarOModificarEntrenadores";
            this.Text = "Gestionar Entrenadores";
            this.Load += new System.EventHandler(this.frmEliminarOModificarEntrenadores_Load);
            this.mrcBuscarEntrenador.ResumeLayout(false);
            this.mrcBuscarEntrenador.PerformLayout();
            this.mrcDatosEntrenador.ResumeLayout(false);
            this.mrcDatosEntrenador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarEntrenador;
        private System.Windows.Forms.GroupBox mrcBuscarEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenadorBusqueda;
        private System.Windows.Forms.Button btnBuscarEntrenador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mskCodigoEntrenadorBusqueda;
        private System.Windows.Forms.TextBox txtCodigoEntrenadorBusqueda;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.TextBox txtDireccionEntrenador;
        private System.Windows.Forms.TextBox txtApellidoEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Label lblNombreEntrenador;
        private System.Windows.Forms.Label lblApellidoEntrenador;
        private System.Windows.Forms.Label lblDireccionEntrenador;
        private System.Windows.Forms.Label lblProvinciaEntrenador;
        private System.Windows.Forms.TextBox txtProvinciaEntrenador;
        private System.Windows.Forms.TextBox txtDeporteEntrenador;
        private System.Windows.Forms.Label lblDeporteEntrenador;
        private System.Windows.Forms.GroupBox mrcDatosEntrenador;
    }
}