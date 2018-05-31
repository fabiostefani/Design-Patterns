using System;

namespace fabiostefani.io.DesignPatterns.AbstractFactory.Model
{
    public class Leao : Carnivoro
    {
        public override void Devorar(Herbivoro h)
        {
            Console.WriteLine($"{GetType().Name} devora {h.GetType().Name}");
        }
    }
}
