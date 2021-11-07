
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejer1.Entidades;
using Ejer1.Negocio;
using Newtonsoft.Json;

namespace Ejer1.WinForm
{
    public partial class FrmListarCliente : Form
    {
        private ClienteServicio _clienteServ;
        private FrmCargarCliente _formCargarCliente;
  
        
        public FrmListarCliente(Form Prop)
        {
            this.Owner = Prop;
            _formCargarCliente = new FrmCargarCliente(this);
            _clienteServ = new ClienteServicio();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void CargarLista()
        {
            lstClientes.DataSource = null ;
            lstClientes.DataSource = _clienteServ.GetClientes();
            lstClientes.DisplayMember = "Mostrar";
            lstClientes.ValueMember = "Legajo";
        }
        public void AgregarCliente(Cliente cli)
        {
            if (cli != null)
            {
                _clienteServ.AddCliente(cli);
            }
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _formCargarCliente.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
