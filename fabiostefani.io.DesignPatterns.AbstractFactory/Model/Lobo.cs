using System;

namespace fabiostefani.io.DesignPatterns.AbstractFactory.Model
{
    public class Lobo : Carnivoro
    {
        public override void Devorar(Herbivoro h)
        {
            Console.WriteLine($"{GetType().Name} devora {h.GetType().Name}");
        }
    }
}
