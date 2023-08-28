using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1
{
    class Transporte:Costo
    {
        public double Distancia { get; set; }
        public double PrecioPorKm { get; set; }

        public Transporte(double distancia, double precio)
        {
            this.Distancia = distancia;
            PrecioPorKm = precio;
        }

        public override double Valor()
        {
            return PrecioPorKm * Distancia;
        }

        public override string ToString()
        {
            return "Distancia: " + Distancia + " Precio por kilometro: " + PrecioPorKm;
        }
    }
}
