using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2.Entidades
{
    public class TarjetaCredito
    {
        private int _tipo;
        private int _periodoVencimiento;
        private double _limiteCompra;
        private string _nroPlastico;
        private string _usuario;
        private int _idCliente;

        public TarjetaCredito(int tipo, int periodoVencimiento, double limiteCompra, string nroPlastico, string usuario, int idCliente)
        {
            _tipo = tipo;
            _periodoVencimiento = periodoVencimiento;
            _limiteCompra = limiteCompra;
            _nroPlastico = nroPlastico;
            _usuario = usuario;
            this._idCliente = idCliente;
        }

        public int Tipo { get => _tipo; set => _tipo = value; }
        public int PeriodoVencimiento { get => _periodoVencimiento; set => _periodoVencimiento = value; }
        public double LimiteCompra { get => _limiteCompra; set => _limiteCompra = value; }
        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
    }
}
