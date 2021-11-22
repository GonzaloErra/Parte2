using Ejer2.Entidades;
using Ejer2.Entidades.Enum;
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
    public partial class FrmTarjeta : Form
    {
        private ClienteNegocio clienteNegocio;
        private TarjetaNegocio tarjetaNegocio;
        public FrmTarjeta(Form prop)
        {
            clienteNegocio = new ClienteNegocio();
            tarjetaNegocio = new TarjetaNegocio();
            this.Owner = prop;
            InitializeComponent();
        }

        private void FrmTarjeta_Load(object sender, EventArgs e)
        {
            RecargarLista();
            CargarCombos();
        }

        private void RecargarLista()
        {
            List<TarjetaCredito> tarj = tarjetaNegocio.TreerTodo();
            lstTarjeta.DataSource = null;
            lstTarjeta.DataSource = tarj;
            if (tarj == null)
                txCantidadPlasticos.Text = "NO HAY TARJETAS";
            txCantidadPlasticos.Text = tarj.Count().ToString();


            txPromedio.Text = Promedio().ToString("0.00");   

        }
        
        private void CargarCombos()
        {
            cmbTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
            cmbCierre.DataSource = Enum.GetValues(typeof(Periodo));

            cmbCliente.DataSource = clienteNegocio.TraerTodos();
            cmbCliente.DisplayMember = "Mostrar";
            cmbCliente.ValueMember = "id";


        }
        private void Limpiar()
        {
            txCantidadPlasticos.Clear();
            txCompra.Clear();
            cmbCierre.SelectedIndex = 0;
            cmbTarjeta.SelectedIndex = 0;
            txPlasticos.Clear();

        }

        

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ValidacionesItems();
            TipoTarjeta tipo = (TipoTarjeta)cmbTarjeta.SelectedIndex;
            Periodo periodo = (Periodo)cmbCierre.SelectedIndex;
            int clie = (int)cmbCliente.SelectedValue;
            string plastico = txPlasticos.Text;
            int limite = Convert.ToInt32(txCompra.Text);
            TarjetaCredito tarj = new TarjetaCredito((int)tipo,(int)periodo,limite,plastico,clie);
            tarjetaNegocio.Agregar(tarj);
            Limpiar();
            RecargarLista();
        }
        private void ValidacionesItems()
        {
            TipoTarjeta tipo = (TipoTarjeta)cmbTarjeta.SelectedIndex;
            Periodo periodo = (Periodo)cmbCierre.SelectedIndex;
            Cliente cli = (Cliente)cmbCliente.SelectedItem;

            if((int)tipo == 0)
                throw new Exception("Seleccione un tipo de tarjeta");
            if ((int)periodo == 0)
                throw new Exception("Seleccione un periodo");
            if (cli == null || cli.id == 0)
                throw new Exception("no selecciono un cliente");
        }
        private void ValidacionesAgregar()
        {
            ValidacionesItems();

            int value;

            if (!int.TryParse(txCompra.Text, out value))
                throw new Exception("Ingrese un valor Numerico");
            if (Convert.ToInt32(txCompra.Text) < 1000 || Convert.ToInt32(txCompra.Text) > 50000)
                throw new Exception("los montos no son los requeridos");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesAgregar();

                TipoTarjeta tipo = (TipoTarjeta)cmbTarjeta.SelectedIndex;
                Periodo periodo = (Periodo)cmbCierre.SelectedIndex;
                Cliente cli = (Cliente)cmbCliente.SelectedItem;

                if (cli != null)
                {
                    string NroTarjeta = tarjetaNegocio.CalcularNumero(tipo);

                    txPlasticos.Text = NroTarjeta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double Promedio()
        {
            double promedio = 0;
            double total = 0; 
            
            foreach (TarjetaCredito tarj in tarjetaNegocio.TreerTodo())
            {
                total += tarj.LimiteCompra;
            }
            promedio = total / tarjetaNegocio.TreerTodo().Count;
            return promedio;

        }
    }
}
