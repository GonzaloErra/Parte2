
namespace Ejer2.Banco.WinForm
{
    partial class FrmTarjeta
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
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTarjeta = new System.Windows.Forms.ListBox();
            this.lbCantPlasticos = new System.Windows.Forms.Label();
            this.lbLimitePromedio = new System.Windows.Forms.Label();
            this.txCantidadPlasticos = new System.Windows.Forms.TextBox();
            this.txPromedio = new System.Windows.Forms.TextBox();
            this.lbTipoTarjeta = new System.Windows.Forms.Label();
            this.lbCierre = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txCompra = new System.Windows.Forms.TextBox();
            this.lbLimite = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbNPlasticos = new System.Windows.Forms.Label();
            this.txPlasticos = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.cmbCierre = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjeta.Location = new System.Drawing.Point(12, 43);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(397, 33);
            this.lbTarjeta.TabIndex = 1;
            this.lbTarjeta.Text = "Formulario Tarjeta de Credito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte de Tarjeta";
            // 
            // lstTarjeta
            // 
            this.lstTarjeta.FormattingEnabled = true;
            this.lstTarjeta.Location = new System.Drawing.Point(475, 77);
            this.lstTarjeta.Name = "lstTarjeta";
            this.lstTarjeta.Size = new System.Drawing.Size(218, 199);
            this.lstTarjeta.TabIndex = 3;
            // 
            // lbCantPlasticos
            // 
            this.lbCantPlasticos.AutoSize = true;
            this.lbCantPlasticos.Location = new System.Drawing.Point(475, 332);
            this.lbCantPlasticos.Name = "lbCantPlasticos";
            this.lbCantPlasticos.Size = new System.Drawing.Size(103, 13);
            this.lbCantPlasticos.TabIndex = 4;
            this.lbCantPlasticos.Text = "Cantidad de plastico";
            // 
            // lbLimitePromedio
            // 
            this.lbLimitePromedio.AutoSize = true;
            this.lbLimitePromedio.Location = new System.Drawing.Point(475, 383);
            this.lbLimitePromedio.Name = "lbLimitePromedio";
            this.lbLimitePromedio.Size = new System.Drawing.Size(81, 13);
            this.lbLimitePromedio.TabIndex = 5;
            this.lbLimitePromedio.Text = "Limite Promedio";
            // 
            // txCantidadPlasticos
            // 
            this.txCantidadPlasticos.Location = new System.Drawing.Point(577, 332);
            this.txCantidadPlasticos.Name = "txCantidadPlasticos";
            this.txCantidadPlasticos.Size = new System.Drawing.Size(100, 20);
            this.txCantidadPlasticos.TabIndex = 6;
            // 
            // txPromedio
            // 
            this.txPromedio.Location = new System.Drawing.Point(577, 375);
            this.txPromedio.Name = "txPromedio";
            this.txPromedio.Size = new System.Drawing.Size(100, 20);
            this.txPromedio.TabIndex = 7;
            // 
            // lbTipoTarjeta
            // 
            this.lbTipoTarjeta.AutoSize = true;
            this.lbTipoTarjeta.Location = new System.Drawing.Point(77, 116);
            this.lbTipoTarjeta.Name = "lbTipoTarjeta";
            this.lbTipoTarjeta.Size = new System.Drawing.Size(64, 13);
            this.lbTipoTarjeta.TabIndex = 9;
            this.lbTipoTarjeta.Text = "Tipo Tarjeta";
            // 
            // lbCierre
            // 
            this.lbCierre.AutoSize = true;
            this.lbCierre.Location = new System.Drawing.Point(77, 161);
            this.lbCierre.Name = "lbCierre";
            this.lbCierre.Size = new System.Drawing.Size(88, 13);
            this.lbCierre.TabIndex = 10;
            this.lbCierre.Text = "Periodo de Cierre";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(77, 218);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 11;
            this.lbCliente.Text = "Cliente";
            // 
            // txCompra
            // 
            this.txCompra.Location = new System.Drawing.Point(204, 274);
            this.txCompra.Name = "txCompra";
            this.txCompra.Size = new System.Drawing.Size(100, 20);
            this.txCompra.TabIndex = 13;
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Location = new System.Drawing.Point(78, 277);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(88, 13);
            this.lbLimite.TabIndex = 14;
            this.lbLimite.Text = "Limite de Compra";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(80, 321);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(272, 31);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lbNPlasticos
            // 
            this.lbNPlasticos.AutoSize = true;
            this.lbNPlasticos.Location = new System.Drawing.Point(62, 383);
            this.lbNPlasticos.Name = "lbNPlasticos";
            this.lbNPlasticos.Size = new System.Drawing.Size(104, 13);
            this.lbNPlasticos.TabIndex = 16;
            this.lbNPlasticos.Text = "Numero de Plasticos";
            // 
            // txPlasticos
            // 
            this.txPlasticos.Location = new System.Drawing.Point(204, 380);
            this.txPlasticos.Name = "txPlasticos";
            this.txPlasticos.Size = new System.Drawing.Size(100, 20);
            this.txPlasticos.TabIndex = 17;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(80, 414);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(272, 32);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(204, 113);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTarjeta.TabIndex = 19;
            // 
            // cmbCierre
            // 
            this.cmbCierre.FormattingEnabled = true;
            this.cmbCierre.Location = new System.Drawing.Point(204, 158);
            this.cmbCierre.Name = "cmbCierre";
            this.cmbCierre.Size = new System.Drawing.Size(121, 21);
            this.cmbCierre.TabIndex = 20;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(204, 210);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 21;
            // 
            // FrmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 449);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbCierre);
            this.Controls.Add(this.cmbTarjeta);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txPlasticos);
            this.Controls.Add(this.lbNPlasticos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.txCompra);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbCierre);
            this.Controls.Add(this.lbTipoTarjeta);
            this.Controls.Add(this.txPromedio);
            this.Controls.Add(this.txCantidadPlasticos);
            this.Controls.Add(this.lbLimitePromedio);
            this.Controls.Add(this.lbCantPlasticos);
            this.Controls.Add(this.lstTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTarjeta);
            this.Name = "FrmTarjeta";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTarjeta;
        private System.Windows.Forms.Label lbCantPlasticos;
        private System.Windows.Forms.Label lbLimitePromedio;
        private System.Windows.Forms.TextBox txCantidadPlasticos;
        private System.Windows.Forms.TextBox txPromedio;
        private System.Windows.Forms.Label lbTipoTarjeta;
        private System.Windows.Forms.Label lbCierre;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox txCompra;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbNPlasticos;
        private System.Windows.Forms.TextBox txPlasticos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.ComboBox cmbCierre;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}

