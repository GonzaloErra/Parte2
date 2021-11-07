
namespace Ejer1.WinForm
{
    partial class FrmCargarCliente
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbActivo = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCuit = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(228, 318);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 35;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(228, 280);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 34;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(228, 244);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 218);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(228, 151);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(228, 79);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 27;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(29, 325);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 26;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(29, 287);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 25;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(29, 251);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 24;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 225);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 23;
            this.lbNombre.Text = "Nombre";
            // 
            // lbActivo
            // 
            this.lbActivo.AutoSize = true;
            this.lbActivo.Location = new System.Drawing.Point(29, 196);
            this.lbActivo.Name = "lbActivo";
            this.lbActivo.Size = new System.Drawing.Size(37, 13);
            this.lbActivo.TabIndex = 22;
            this.lbActivo.Text = "Activo";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(29, 158);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(108, 13);
            this.lbFN.TabIndex = 21;
            this.lbFN.Text = "Fecha de Nacimiento";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(29, 123);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "Email";
            // 
            // lbCuit
            // 
            this.lbCuit.AutoSize = true;
            this.lbCuit.Location = new System.Drawing.Point(29, 86);
            this.lbCuit.Name = "lbCuit";
            this.lbCuit.Size = new System.Drawing.Size(25, 13);
            this.lbCuit.TabIndex = 19;
            this.lbCuit.Text = "Cuit";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(29, 53);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 18;
            this.lbId.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(263, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbActivo
            // 
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Location = new System.Drawing.Point(228, 187);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(100, 21);
            this.cmbActivo.TabIndex = 38;
            // 
            // FrmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 433);
            this.Controls.Add(this.cmbActivo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbActivo);
            this.Controls.Add(this.lbFN);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCuit);
            this.Controls.Add(this.lbId);
            this.Name = "FrmCargarCliente";
            this.Text = "Cargar Cliente";
            this.Load += new System.EventHandler(this.FrmCargarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbActivo;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCuit;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbActivo;
    }
}

