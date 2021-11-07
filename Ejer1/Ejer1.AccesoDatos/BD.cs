using Ejer1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.AccesoDatos
{
    public class BD
    {
        private List<Cliente> _clientes;
        private List<Cuenta> _cuenta;


        public BD()
        {
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente(1, 12, "@", DateTime.Now, true, "Ca", "Er", "J", "2231"));
            _clientes.Add(new Cliente(2, 32, "@", DateTime.Now, false, "Germ", "Fran", "sda", "4113"));
        }
        
        public void Agregar(Cliente cli)
        {
            _clientes.Add(cli);
        }
        public List<Cliente> Traer()
        {
            return _clientes;
        }
    }
}
