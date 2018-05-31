using fabiostefani.io.DesignPatterns.AbstractFactory.Model;

namespace fabiostefani.io.DesignPatterns.AbstractFactory.Factory
{
    internal class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro ObterCarnivoro()
        {
            return new Lobo();
        }

        public override Herbivoro ObterHerbivoro()
        {
            return new Coelho();
        }
    }
}
