using fabiostefani.io.DesignPatterns.Adapter.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Startup.Start();
            var boleto = Startup.Container.GetInstance<IBoleto>();

            var adapter = new Boleto(boleto);
            adapter.ImprimirBoleto();

            Console.ReadKey();
        }
    }
}
