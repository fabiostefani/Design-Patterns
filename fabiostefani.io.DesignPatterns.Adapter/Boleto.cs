using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Adapter
{
    public class Boleto
    {
        private readonly IBoleto _boleto;
        public Boleto(IBoleto boleto)
        {
            _boleto = boleto;
        }

        public void ImprimirBoleto()
        {
            _boleto.ImprimirBoleto();
        }
    }
}
