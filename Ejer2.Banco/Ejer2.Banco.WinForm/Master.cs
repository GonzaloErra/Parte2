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
    public partial class Master : Form
    {
        private FrmCliente _frmCliente;
        private FrmTarjeta _frmTarjeta;
        public Master()
        {
            _frmCliente = new FrmCliente(this);
            _frmTarjeta = new FrmTarjeta(this);
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmCliente.Show();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmTarjeta.Show();
        }
    }
}
