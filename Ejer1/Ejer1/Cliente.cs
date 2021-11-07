using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Libery
{
    public class Cliente
    {
        private int _id;
        private long _cuit;
        private string _email;
        private DateTime _fechadeNacimiento;
        private bool _activo;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;

        public Cliente(int id, long cuit, string email, DateTime fechadeNacimiento, bool activo, string nombre, string apellido, string direccion, string telefono)
        {
            _id = id;
            _cuit = cuit;
            _email = email;
            _fechadeNacimiento = fechadeNacimiento;
            _activo = activo;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;

        }
    }
}
