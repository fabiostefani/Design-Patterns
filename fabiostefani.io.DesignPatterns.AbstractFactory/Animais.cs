using fabiostefani.io.DesignPatterns.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.DesignPatterns.AbstractFactory
{
    public class Animais
    {
        private readonly Herbivoro _herbivoro;
        private readonly Carnivoro _carnivoro;
        public Animais(ContinenteFactory factory)
        {
            _carnivoro = factory.ObterCarnivoro();
            _herbivoro = factory.ObterHerbivoro();
        }

        public void CacarComida()
        {
            _carnivoro.Devorar(_herbivoro);
        }
    }
}
