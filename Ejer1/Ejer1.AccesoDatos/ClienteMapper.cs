using Ejer1.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.AccesoDatos
{
    public class ClienteMapper
    {
        private List<Cliente> _clientes;
        private List<Cuenta> _cuenta;


        //public BD()
        //{
        //    _clientes = new List<Cliente>();
        //    _clientes.Add(new Cliente(1, 12, "@", "Ca", "Er", "J", "2231"));
        //    _clientes.Add(new Cliente(2, 32, "@", "Germ", "Fran", "sda", "4113"));
        //}
        //public void Agregar(Cliente cli)
        //{
        //    _clientes.Add(cli);
        //}
        //public List<Cliente> Traer()
        //{
        //    return _clientes;
        //}
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente");
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }
        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>> (json);
            return lst;
        }
        public Entidades.POST.PostRta Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("cliente", obj);

            Entidades.POST.PostRta lst = JsonConvert.DeserializeObject<Entidades.POST.PostRta>(json);
            return lst;

        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.Id.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Email);
            n.Add("DNI","41" );
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaNacimiento", cliente.FechadeNacimiento.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "892967");
            return n;
        }


    }
}
