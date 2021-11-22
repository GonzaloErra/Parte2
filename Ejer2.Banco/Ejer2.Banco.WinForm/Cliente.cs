using Ejer2.Entidades;
using Ejer2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2.Banco.WinForm
{
    public partial class FrmCliente : Form
    {
        private ClienteNegocio _clienteNegocio;
        public FrmCliente(Form prop)
        {
            _clienteNegocio = new ClienteNegocio();
            this.Owner = prop;
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Recargar();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text;
            string apellido = txApellido.Text;
            string telefono = txTelefono.Text;
            Cliente cli = new Cliente(txNombre.Text, txApellido.Text, txTelefono.Text);
            _clienteNegocio.Agregar(cli);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txTelefono.Clear();
            txNombre.Clear();
            txApellido.Clear();
            Recargar();
        }

        private void Recargar()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = _clienteNegocio.TraerTodos();
        }
    }
}
