using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3.Morosos.Entidades
{
    public class Servicio
    {
        private int _id;
        private double _punitorioDiario;
        private string _nombre;

        public Servicio(int id, double punitorioDiario, string nombre)
        {
            _id = id;
            _punitorioDiario = punitorioDiario;
            _nombre = nombre;
        }
        public int Id { get => _id; set => _id = value; }
        public double PunitorioDiario { get => _punitorioDiario; set => _punitorioDiario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
