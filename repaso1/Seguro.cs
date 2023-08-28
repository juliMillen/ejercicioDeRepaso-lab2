using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1
{
    class Seguro:Costo
    {
        public double ValorAsegurado { get; set; }
        public double Porcentaje { get; set; }

        public Seguro(double valorA, double porcentaje)
        {
            ValorAsegurado = valorA;
            this.Porcentaje = porcentaje;
        }

        public override double Valor()
        {
            return Porcentaje / 100 * ValorAsegurado;
        }

        public override string ToString()
        {
            return "Valor Asegurado: " + ValorAsegurado + " Porcentaje: %" + Porcentaje;
        }
    }
}
