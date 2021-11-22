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
    public class TarjetaMapper
    {
        public List<TarjetaCredito> TraerTarjeta()
        {
            string json2 = WebHelper.Get("tarjetacredito/89");
            List<TarjetaCredito> resultado = MapList(json2);
            return resultado;
        }

        private List<TarjetaCredito> MapList(string json2)
        {
            List<TarjetaCredito> lst = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json2);
            return lst;
        }

        public TransactionResult Insertar(TarjetaCredito tarjeta)
        {
            NameValueCollection obj = ReverseMap(tarjeta);
            string json = WebHelper.Post("tarjetacredito", obj);
            TransactionResult rta = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rta;

        }

        private NameValueCollection ReverseMap(TarjetaCredito tarjeta)
        {
            NameValueCollection n = new NameValueCollectio();
            n.Add("tipo", tarjeta.Tipo.ToString());
            n.Add("peridoVencimiento", tarjeta.PeriodoVencimiento.ToString());
            n.Add("limiteCompra", tarjeta.LimiteCompra.ToString());
            n.Add("nroPlastico", tarjeta.NroPlastico);
            n.Add("usuario", "89");
            return n;

        }
    }
}
