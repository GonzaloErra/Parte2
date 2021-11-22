using Ejer2.Datos;
using Ejer2.Entidades;
using Ejer2.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2.Negocio
{
    public class TarjetaNegocio
    {
        private TarjetaMapper tarjetaMapper;
        private List<TarjetaCredito> tarjetaCreditos;
        public TarjetaNegocio()
        {
            tarjetaMapper = new TarjetaMapper();
            
        }

        public List<TarjetaCredito> TreerTodo()
        {
            tarjetaCreditos = tarjetaMapper.TraerTarjeta();
            return tarjetaCreditos;
        }

        public TransactionResult Agregar(TarjetaCredito tarjeta)
        {
            TransactionResult rta= tarjetaMapper.Insertar(tarjeta);
            if (rta.IsOk == false)
                throw new Exception("no se pudo agregar la Tarjeta" + rta.Error);
            return rta;
        }

        public string CalcularNumero(TipoTarjeta tipo)
        {

            Random random = new Random();
            int ultimos3dígitos = random.Next(1000,9999);
            string Digitos = "567437289654" + ultimos3dígitos;

            if (tipo == TipoTarjeta.Amex)
                Digitos = Digitos.Substring(1, 15);
            return Digitos;

        }
    }
}
