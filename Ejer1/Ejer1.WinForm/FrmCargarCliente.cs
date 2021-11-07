using Ejer1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1.WinForm
{
    public partial class FrmCargarCliente : Form
    {
        private List<string> _activo;
        public FrmCargarCliente(FrmListarCliente FrmListar)
        {
            _activo = new List<string>();
            _activo.Add("Activo");
            _activo.Add("Desactivo");
            this.Owner = FrmListar;

            InitializeComponent();
        }

        

        private void Limpiar()
        {

            this.txtApellido.Text = string.Empty;
            this.txtCuit.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFN.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            InicializarControles();

        }
        private void InicializarControles()
        {
            //cmbActivo.DataSource = null;
            cmbActivo.DataSource = this._activo;
            //cmbActivo.DisplayMember = "Mostrar";
            //cmbActivo.ValueMember = "Legajo";
        }

        private void Validaciones()
        {

            if ((int)cmbActivo.SelectedValue == 0)
                throw new Exception("Seleccione un valor");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmCargarCliente_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente(Convert.ToInt32(this.txtId.Text), Convert.ToInt32(this.txtCuit.Text), this.txtEmail.Text, Convert.ToDateTime(this.txtFN),/* (bool)this.cmbActivo.SelectedItem*/this.txtNombre.Text, this.txtApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text);

                ((FrmListarCliente)this.Owner).AgregarCliente(cli);
               
                Limpiar();
                this.Hide();
                this.Owner.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
