using Ejer3.Morosos.Entidades.Entidades;
using Ejer3.Morosos.Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3.Morosos.Data
{
    public class PagoMapper
    {
        public List<Pago> TraerTodo()
        {

            string json = WebHelper.Get("PagoMorosos /");
            List<Pago> rta = Maplist(json);
            return rta;
        }

        private List<Pago> Maplist(string json)
        {
            List<Pago> rta = JsonConvert.DeserializeObject<List<Pago>>(json);
            return rta;
        }

        public TransactionResult Insertar(Pago pago)
        {
            NameValueCollection obj = ReversMap(pago);
            string json = WebHelper.Post("PagoMorosos", obj);
            TransactionResult rta = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rta;
        }

        private NameValueCollection ReversMap(Pago pago)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", pago.Id.ToString());
            n.Add("idServicio", pago.IdServicio.ToString());
            n.Add("idCliente", pago.IdCliente.ToString());
            n.Add("fechaVencimiento", pago.FechaVencimiento.ToString("yyyy-MM-dd"));
            n.Add("fechaPago", pago.FechaPago.ToString("yyyy-MM-dd"));
            n.Add("interesePunitorio", pago.InteresPunitorio.ToString());
            n.Add("importeTotal", pago.ImporteTotal.ToString());
            n.Add("usuario", "89");
            return n;
        }
    }
}
