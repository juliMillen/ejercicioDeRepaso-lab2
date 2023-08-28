using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace repaso1
{
    class Envio
    {
        private ArrayList costito = new ArrayList();
        public int CantidadCostos
        {
            get { return costito.Count; }
        }

        public Envio()
        {

        }

        public void AgregarCosto(Costo costo)
        {
            costito.Add(costo);
        }

        public double ValorFinal()
        {
            double aux=0;
            foreach(Costo nuevoC in costito)
            {
                aux += nuevoC.Valor();
            }
            return aux;
        }

        public Costo VerCosto(int idx)
        {
            return (Costo)costito[idx];
        }
    }
}
