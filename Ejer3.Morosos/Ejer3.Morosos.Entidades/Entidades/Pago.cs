using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3.Morosos.Entidades.Entidades
{
    public class Pago
    {
        private int id;
        private int idServicio;
        private int idCliente;
        private DateTime fechaVencimiento;
        private DateTime fechaPago;
        private double importeAdeudado;
        private double InteresPunitorio; //(autocalculable => ((FechaPago - FechaVencimiento) (en dias)* Servicio.PunitorioDiario )
        private double importeTotal; //(autocalculable => ImporteAdeudado + InteresPunitorio)
        private string usuario;
        private Servicio servicio;

        public Pago(int id, int idServicio, int idCliente, DateTime fechaVencimiento, DateTime fechaPago, double importeAdeudado, double interesPunitorio, double importeTotal, string usuario, Servicio servicio)
        {
            this.id = id;
            this.idServicio = idServicio;
            this.idCliente = idCliente;
            this.fechaVencimiento = fechaVencimiento;
            this.fechaPago = fechaPago;
            this.importeAdeudado = importeAdeudado;
            interesPunitorio = (fechaPago - fechaVencimiento).TotalDays * servicio.PunitorioDiario;
            importeTotal = importeAdeudado+ interesPunitorio;
            this.usuario = usuario;
            this.servicio = servicio;
        }

        public int Id { get => id; set => id = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public double ImporteAdeudado { get => importeAdeudado; set => importeAdeudado = value; }
        public double InteresPunitorio1 { get => InteresPunitorio; set => InteresPunitorio = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
    }
}
