using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2.Entidades
{
    [DataContract]
    public class Cliente
    {
        private int _id;
        private string _apellido;
        private string _direccion;
        private string _nombre;
        private string _email;
        private DateTime _fechaNac;
        private string _telefono;
        private bool _activo;

      

        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "Direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        [DataMember(Name = "Nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido,string telefono)
        {
            _apellido = apellido;
            Nombre = nombre;
            _telefono = telefono;   
        }

        public override string ToString()   
        {
            return string.Format("{0}) {1} - {2}", this.id, this.Apellido, this.Nombre);
        }
        public string Mostrar
        {
            get
            {
                return $"{this.id}) {this.Nombre}-{this.Apellido}";
            }
        }
    }
}
