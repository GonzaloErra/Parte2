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
    public partial class FrmMaster : Form
    {
        private FrmListarCliente _formListarClientes;

        public FrmMaster()
        {
            _formListarClientes = new FrmListarCliente(this);
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                _formListarClientes.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
