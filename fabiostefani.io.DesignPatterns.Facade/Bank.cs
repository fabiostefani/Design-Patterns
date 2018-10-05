using System;

namespace fabiostefani.io.DesignPatterns.Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"Validar conta de {customer.Nome}");
            return true;
        }
    }
}
