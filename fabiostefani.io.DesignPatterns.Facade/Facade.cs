using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Facade
{
    public static class Facade
    {
        public static void Execucao()
        {
            var mortGage = new Mortgage();
            var customer = new Customer("João");
            mortGage.IsEligible(customer, 250000);
            //Console.WriteLine($"{customer.Nome} foi {ResolverTextoEligible(eligible)}");
        }

        
    }
}
