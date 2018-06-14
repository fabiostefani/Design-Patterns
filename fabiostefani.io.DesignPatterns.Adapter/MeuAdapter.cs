using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Adapter
{
    public class MeuAdapter : BoletoPdf, IBoleto
    {
        public void ImprimirBoleto()
        {
            SalvarBoletoPdf();
        }
    }
}
