using fabiostefani.io.DesignPatterns.Factory.Enums;
using System;

namespace fabiostefani.io.DesignPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcreteVeiculoFactory();

            var moto = factory.ObterVeiculo(EnumCategoria.Leve);
            moto.Limite(300);

            var carro = factory.ObterVeiculo(EnumCategoria.Medio);
            carro.Limite(250);

            var caminhonete = factory.ObterVeiculo(EnumCategoria.Pesado);
            caminhonete.Limite(180);

            Console.ReadKey();
        }
    }
}
