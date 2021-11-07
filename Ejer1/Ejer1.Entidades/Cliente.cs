using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Entidades
{
    public class Cliente
    {
        private int _id;
        private int _cuit;
        private string _email;
        private DateTime _fechadeNacimiento;
        private bool _activo;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;

        public Cliente(int id, int cuit, string email, DateTime fechadeNacimiento, string nombre, string apellido, string direccion, string telefono)
        {
            _id = id;
            _cuit = cuit;
            _email = email;
            _fechadeNacimiento = fechadeNacimiento;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
        }
        
        public int ID { get { return _id; } set { _id = value; } } 
        public int Cuit { get => _id; set { _id = value; } }
        public string Email { get => _email; set { _email = value; } }
        public DateTime FN { get => _fechadeNacimiento; }
        public bool Activo { get => _activo; set { _activo = value; } }
        public string Nombre { get => _nombre; set { _nombre = value; } }
        public string Apellido { get => _apellido; set { _apellido = value; } }
        public string Direccion { get => _direccion; set { _direccion = value; } }
        public string Telefono { get => _telefono; set { _telefono = value; } }



        public Cliente(int id, int cuit, string email, DateTime fechadeNacimiento, bool activo, string nombre, string apellido, string direccion, string telefono)
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
