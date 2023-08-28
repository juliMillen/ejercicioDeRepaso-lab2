using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1
{
    class TasaAduanera:Costo
    {
        public double ValorFijo { get; set; }

        public TasaAduanera(double valor)
        {
            ValorFijo = valor;
        }

        public override double Valor()
        {
            return ValorFijo;
        }

        public override string ToString()
        {
            return "Tasa Aduanera: " + ValorFijo; 
        }
    }
}
