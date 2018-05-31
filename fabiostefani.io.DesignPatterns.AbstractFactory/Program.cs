using fabiostefani.io.DesignPatterns.AbstractFactory.Factory;
using System;

namespace fabiostefani.io.DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var animaisAfrica = new Animais(new AfricaFactory());
            animaisAfrica.CacarComida();

            var animaisAmerica = new Animais(new AmericaFactory());
            animaisAmerica.CacarComida();
            Console.ReadKey();
        }
    }
}
