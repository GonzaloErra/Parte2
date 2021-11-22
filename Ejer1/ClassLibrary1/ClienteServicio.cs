using Ejer1.AccesoDatos;
using Ejer1.Entidades;
using Ejer1.Entidades.POST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        private List<Cliente> _listaclientes;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
            _listaclientes = new List<Cliente>();

        }
        public List<Cliente> Traer()
        {
            _listaclientes = _clienteMapper.TraerTodos();
            return _listaclientes;
        }



        //public void AddCliente(Cliente cli) 
        //{
        //    _bd.Agregar(cli);
        //}
        //public List<Cliente> GetClientes()
        //{
        //    return _bd.Traer();


        public PostRta Agregar(int id, int cuit, string email, DateTime fechaNac, bool activo, string nombre, string apellido, string telefono)
        {
            Cliente cli = new Cliente();
            cli.Id = id;
            cli.Cuit = cuit;
            cli.Email = email;
            cli.FechadeNacimiento = fechaNac;
            cli.Nombre = nombre;
            cli.Apellido = apellido;
            cli.Telefono = telefono;
            cli.Activo = activo;

            PostRta rta = _clienteMapper.Insertar(cli);
            return rta;
        }


    }
}
