using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Entidades
{
    public class Cuenta
    {
        private int _id;
        private int _numeroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;

        public Cuenta(int id, int numeroCuenta, string descripcion, double saldo, DateTime fechaApertura, DateTime fechaModificacion)
        {
            _id = id;
            _numeroCuenta = numeroCuenta;
            _descripcion = descripcion;
            _saldo = saldo;
            _fechaApertura = fechaApertura;
            _fechaModificacion = fechaModificacion;
        }
    }

    
}
