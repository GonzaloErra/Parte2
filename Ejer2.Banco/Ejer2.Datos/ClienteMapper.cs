using Ejer2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodo()
        {
            string json2 = WebHelper.Get("cliente/89");
            List<Cliente> resultado = MapList(json2);
            return resultado;

        }

        private List<Cliente> MapList(string json2)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json2);
            return lst;
        }
        
        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("cliente", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("id", cliente.id.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaNac", cliente.FechaNac.ToString());
            n.Add("usuario", "89");
            return n;
        }
    }
}
