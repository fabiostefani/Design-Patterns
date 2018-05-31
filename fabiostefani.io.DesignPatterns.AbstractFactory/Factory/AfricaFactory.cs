using fabiostefani.io.DesignPatterns.AbstractFactory.Model;

namespace fabiostefani.io.DesignPatterns.AbstractFactory.Factory
{
    internal class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro ObterCarnivoro()
        {
            return new Leao();
        }

        public override Herbivoro ObterHerbivoro()
        {
            return new Gazela();
        }
    }
}
