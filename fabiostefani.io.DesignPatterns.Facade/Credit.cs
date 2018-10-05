using System;

namespace fabiostefani.io.DesignPatterns.Facade
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"Validar crédito para {customer.Nome}");
            return true;
        }
    }
}
