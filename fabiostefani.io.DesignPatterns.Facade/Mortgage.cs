using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Facade
{
    public class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Credit _credit = new Credit();
        private readonly Loan _loan = new Loan();

        public void IsEligible(Customer cust, int amount)
        {            
            var eligible = true;
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            Console.WriteLine($"{cust.Nome} foi {ResolverTextoEligible(eligible)} para empréstimo de {amount:C}");            
        }

        private static string ResolverTextoEligible(bool eligible)
        {
            return eligible ? "Aprovado" : "Rejeitoad";
        }
    }
}
