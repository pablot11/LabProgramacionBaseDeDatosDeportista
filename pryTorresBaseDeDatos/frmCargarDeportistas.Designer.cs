namespace pryTorresBaseDeDatos
{
    partial class frmCargarDeportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarDeportistas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarDeportista = new System.Windows.Forms.Button();
            this.lstDeporteDeportista = new System.Windows.Forms.ComboBox();
            this.lblDeporteDeportista = new System.Windows.Forms.Label();
            this.lblTelefonoDeportista = new System.Windows.Forms.Label();
            this.lblNombreDeportista = new System.Windows.Forms.Label();
            this.lblApellidoDeportista = new System.Windows.Forms.Label();
            this.lblDireccionDeportista = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.lblEdadDeportista = new System.Windows.Forms.Label();
            this.mrcDeportistaCargar = new System.Windows.Forms.GroupBox();
            this.mskEdadDeportista = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefonoDeportista = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.mrcDeportistaCargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarDeportista
            // 
            this.btnCargarDeportista.Enabled = false;
            this.btnCargarDeportista.Location = new System.Drawing.Point(137, 231);
            this.btnCargarDeportista.Name = "btnCargarDeportista";
            this.btnCargarDeportista.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDeportista.TabIndex = 28;
            this.btnCargarDeportista.Text = "Cargar";
            this.btnCargarDeportista.UseVisualStyleBackColor = true;
            this.btnCargarDeportista.Click += new System.EventHandler(this.btnCargarDeportista_Click);
            // 
            // lstDeporteDeportista
            // 
            this.lstDeporteDeportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporteDeportista.FormattingEnabled = true;
            this.lstDeporteDeportista.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporteDeportista.Location = new System.Drawing.Point(94, 184);
            this.lstDeporteDeportista.Name = "lstDeporteDeportista";
            this.lstDeporteDeportista.Size = new System.Drawing.Size(100, 21);
            this.lstDeporteDeportista.TabIndex = 7;
            this.lstDeporteDeportista.SelectedIndexChanged += new System.EventHandler(this.lstDeporteDeportista_SelectedIndexChanged);
            // 
            // lblDeporteDeportista
            // 
            this.lblDeporteDeportista.AutoSize = true;
            this.lblDeporteDeportista.Location = new System.Drawing.Point(6, 184);
            this.lblDeporteDeportista.Name = "lblDeporteDeportista";
            this.lblDeporteDeportista.Size = new System.Drawing.Size(48, 13);
            this.lblDeporteDeportista.TabIndex = 25;
            this.lblDeporteDeportista.Text = "Deporte:";
            // 
            // lblTelefonoDeportista
            // 
            this.lblTelefonoDeportista.AutoSize = true;
            this.lblTelefonoDeportista.Location = new System.Drawing.Point(6, 134);
            this.lblTelefonoDeportista.Name = "lblTelefonoDeportista";
            this.lblTelefonoDeportista.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoDeportista.TabIndex = 23;
            this.lblTelefonoDeportista.Text = "Telefono:";
            // 
            // lblNombreDeportista
            // 
            this.lblNombreDeportista.AutoSize = true;
            this.lblNombreDeportista.Location = new System.Drawing.Point(6, 56);
            this.lblNombreDeportista.Name = "lblNombreDeportista";
            this.lblNombreDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDeportista.TabIndex = 22;
            this.lblNombreDeportista.Text = "Nombre:";
            // 
            // lblApellidoDeportista
            // 
            this.lblApellidoDeportista.AutoSize = true;
            this.lblApellidoDeportista.Location = new System.Drawing.Point(6, 82);
            this.lblApellidoDeportista.Name = "lblApellidoDeportista";
            this.lblApellidoDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoDeportista.TabIndex = 21;
            this.lblApellidoDeportista.Text = "Apellido:";
            // 
            // lblDireccionDeportista
            // 
            this.lblDireccionDeportista.AutoSize = true;
            this.lblDireccionDeportista.Location = new System.Drawing.Point(6, 108);
            this.lblDireccionDeportista.Name = "lblDireccionDeportista";
            this.lblDireccionDeportista.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionDeportista.TabIndex = 20;
            this.lblDireccionDeportista.Text = "Dirección:";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(6, 30);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoDeportista.TabIndex = 19;
            this.lblCodigoDeportista.Text = "Codigo:";
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.Location = new System.Drawing.Point(94, 56);
            this.txtNombreDeportista.MaxLength = 10;
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDeportista.TabIndex = 2;
            this.txtNombreDeportista.TextChanged += new System.EventHandler(this.txtNombreDeportista_TextChanged);
            this.txtNombreDeportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDeportista_KeyPress);
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.Location = new System.Drawing.Point(94, 82);
            this.txtApellidoDeportista.MaxLength = 10;
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDeportista.TabIndex = 3;
            this.txtApellidoDeportista.TextChanged += new System.EventHandler(this.txtApellidoDeportista_TextChanged);
            this.txtApellidoDeportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoDeportista_KeyPress);
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.Location = new System.Drawing.Point(94, 108);
            this.txtDireccionDeportista.MaxLength = 20;
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionDeportista.TabIndex = 4;
            this.txtDireccionDeportista.TextChanged += new System.EventHandler(this.txtDireccionDeportista_TextChanged);
            // 
            // lblEdadDeportista
            // 
            this.lblEdadDeportista.AutoSize = true;
            this.lblEdadDeportista.Location = new System.Drawing.Point(6, 158);
            this.lblEdadDeportista.Name = "lblEdadDeportista";
            this.lblEdadDeportista.Size = new System.Drawing.Size(35, 13);
            this.lblEdadDeportista.TabIndex = 31;
            this.lblEdadDeportista.Text = "Edad:";
            // 
            // mrcDeportistaCargar
            // 
            this.mrcDeportistaCargar.Controls.Add(this.mskEdadDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.mskTelefonoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtCodigoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblCodigoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblEdadDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtDireccionDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtApellidoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtNombreDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblDireccionDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lstDeporteDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblApellidoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblDeporteDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblNombreDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblTelefonoDeportista);
            this.mrcDeportistaCargar.Location = new System.Drawing.Point(12, 12);
            this.mrcDeportistaCargar.Name = "mrcDeportistaCargar";
            this.mrcDeportistaCargar.Size = new System.Drawing.Size(200, 213);
            this.mrcDeportistaCargar.TabIndex = 32;
            this.mrcDeportistaCargar.TabStop = false;
            this.mrcDeportistaCargar.Text = "Datos Deportista";
            // 
            // mskEdadDeportista
            // 
            this.mskEdadDeportista.Location = new System.Drawing.Point(94, 160);
            this.mskEdadDeportista.Mask = "00";
            this.mskEdadDeportista.Name = "mskEdadDeportista";
            this.mskEdadDeportista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskEdadDeportista.Size = new System.Drawing.Size(38, 20);
            this.mskEdadDeportista.TabIndex = 6;
            // 
            // mskTelefonoDeportista
            // 
            this.mskTelefonoDeportista.Location = new System.Drawing.Point(94, 134);
            this.mskTelefonoDeportista.Mask = "999999999";
            this.mskTelefonoDeportista.Name = "mskTelefonoDeportista";
            this.mskTelefonoDeportista.Size = new System.Drawing.Size(98, 20);
            this.mskTelefonoDeportista.TabIndex = 5;
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(94, 30);
            this.txtCodigoDeportista.MaxLength = 5;
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoDeportista.Size = new System.Drawing.Size(53, 20);
            this.txtCodigoDeportista.TabIndex = 1;
            this.txtCodigoDeportista.TextChanged += new System.EventHandler(this.txtCodigoDeportista_TextChanged);
            this.txtCodigoDeportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeportista_KeyPress);
            // 
            // frmCargarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 264);
            this.Controls.Add(this.mrcDeportistaCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarDeportista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarDeportistas";
            this.Text = "Carga Deportistas";
            this.Load += new System.EventHandler(this.frmCargarDeportistas_Load);
            this.mrcDeportistaCargar.ResumeLayout(false);
            this.mrcDeportistaCargar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarDeportista;
        private System.Windows.Forms.ComboBox lstDeporteDeportista;
        private System.Windows.Forms.Label lblDeporteDeportista;
        private System.Windows.Forms.Label lblTelefonoDeportista;
        private System.Windows.Forms.Label lblNombreDeportista;
        private System.Windows.Forms.Label lblApellidoDeportista;
        private System.Windows.Forms.Label lblDireccionDeportista;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.Label lblEdadDeportista;
        private System.Windows.Forms.GroupBox mrcDeportistaCargar;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.MaskedTextBox mskEdadDeportista;
        private System.Windows.Forms.MaskedTextBox mskTelefonoDeportista;
    }
}