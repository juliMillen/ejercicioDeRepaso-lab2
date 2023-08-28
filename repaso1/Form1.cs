using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Envio e1 = new Envio();
            e1.AgregarCosto(new Transporte(13.3, 43.4));
            e1.AgregarCosto(new Seguro(15.5, 8.8));
            e1.AgregarCosto(new TasaAduanera(12.1));

            for(int i=0; i< e1.CantidadCostos; i++)
            {
                Costo costo = e1.VerCosto(i);
                lbLista.Items.Add($"{costo,-40}{costo.Valor(),10:f2}");
            }
            lbLista.Items.Add("-------------------------------------------------");
            lbLista.Items.Add($"{"Costo total: $",-40}{e1.ValorFinal(),10:f2}");
        }
    }
}
