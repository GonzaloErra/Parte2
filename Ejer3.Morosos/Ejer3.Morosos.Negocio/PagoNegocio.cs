using Ejer3.Morosos.Data;
using Ejer3.Morosos.Entidades.Entidades;
using Ejer3.Morosos.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3.Morosos.Negocio
{
    public class PagoNegocio
    {
        private List<Pago> pagos;
        private PagoMapper pagoMapper;
        public PagoNegocio()
        {
            pagoMapper = new PagoMapper();
        }

        public List<Pago> Traer()
        {
            pagos = pagoMapper.TraerTodo();
            return pagos;
        }
        public TransactionResult Agregar(Pago pago)
        {
            TransactionResult rta = pagoMapper.Insertar(pago);
            if (rta.IsOk == false)
                throw new Exception("No se pudo Ingresar el Pagoo");
            return rta;

        }
    }
}
