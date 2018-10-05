namespace fabiostefani.io.DesignPatterns.Facade
{
    public class Customer
    {
        public Customer(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

    }
}
