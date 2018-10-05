using System;

namespace fabiostefani.io.DesignPatterns.Facade
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"Verificar empréstimo para {customer.Nome}");
            return true;
        }
    }
}
