using fabiostefani.io.DesignPatterns.AbstractFactory.Model;

namespace fabiostefani.io.DesignPatterns.AbstractFactory
{
    public abstract class ContinenteFactory
    {
        public abstract Herbivoro ObterHerbivoro();
        public abstract Carnivoro ObterCarnivoro();
    }
}
