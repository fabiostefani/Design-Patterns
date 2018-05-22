using fabiostefani.io.DesignPatterns.Factory.Interface;
using System;

namespace fabiostefani.io.DesignPatterns.Factory.Entities
{
    public class Caminhonete : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine($"Limite de velocidade {typeof(Caminhonete).Name}: {limite}");
        }
    }
}
