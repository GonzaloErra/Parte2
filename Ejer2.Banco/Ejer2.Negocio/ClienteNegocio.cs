using Ejer2.Datos;
using Ejer2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2.Negocio
{
    public class ClienteNegocio
    {
        ClienteMapper _clienteMapper;
        List<Cliente> _lstClientes;
        public ClienteNegocio()
        {
            _clienteMapper = new ClienteMapper();
        }
        public List<Cliente> TraerTodos()
        {
            _lstClientes = _clienteMapper.TraerTodo();
            return _lstClientes;
        }
        public TransactionResult Agregar(Cliente cliente)
        {
            TransactionResult result = _clienteMapper.Insertar(cliente);

            if (result.IsOk == false)
                throw new Exception("No se pudo insertar el cliente. Motivo " + result.Error);
            return result;

        }
    }
}
