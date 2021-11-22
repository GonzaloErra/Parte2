using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Entidades
{
    [DataContract]  
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
       
        
        //public string Mostrar
        //{
        //    get
        //    {
        //        return $"{this._nombre} -- {this._apellido}";
        //    }   
        //}

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        public int Cuit { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }
        [DataMember(Name = "FechaNacimiento")]
        public DateTime FechadeNacimiento { get => _fechadeNacimiento; set => _fechadeNacimiento = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember(Name = "Direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public Cliente()
        {

        }
        public Cliente(int id, int cuit, string email, string nombre, string apellido, string direccion, string telefono)
        {
            _id = id;
            _cuit = cuit;
            _email = email;
            //_fechadeNacimiento = fechadeNacimiento;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
        }
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
        public override string ToString()
        {
            return string.Format("{0}) {1} - {2}", this._id, this._nombre, this._apellido);
        }
    }
}
