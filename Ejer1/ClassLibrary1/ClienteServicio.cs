using Ejer1.AccesoDatos;
using Ejer1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Negocio
{
    public class ClienteServicio
    {
        private BD _bd;

        public ClienteServicio()
        {
            _bd = new BD();
        }

        public void AddCliente(Cliente cli) 
        {
            _bd.Agregar(cli);
        }
        public List<Cliente> GetClientes()
        {
            return _bd.Traer();

        }
    }
}
