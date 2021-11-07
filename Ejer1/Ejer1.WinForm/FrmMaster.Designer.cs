
namespace Ejer1.WinForm
{
    partial class FrmMaster
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
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(214, 101);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(206, 47);
            this.btnListarClientes.TabIndex = 0;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(605, 478);
            this.Controls.Add(this.btnListarClientes);
            this.Name = "FrmMaster";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarClientes;
    }
}