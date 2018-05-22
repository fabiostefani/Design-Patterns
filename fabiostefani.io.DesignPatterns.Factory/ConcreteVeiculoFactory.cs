using fabiostefani.io.DesignPatterns.Factory.Entities;
using fabiostefani.io.DesignPatterns.Factory.Enums;
using fabiostefani.io.DesignPatterns.Factory.Interface;
using System;

namespace fabiostefani.io.DesignPatterns.Factory
{
    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IVeiculo ObterVeiculo(EnumCategoria categoria)
        {
            switch (categoria)
            {
                case EnumCategoria.Leve:
                    return new Moto();
                case EnumCategoria.Medio:
                    return new Carro();
                case EnumCategoria.Pesado:
                    return new Caminhonete();
                default:
                    throw new ApplicationException($"Veículo {categoria} não pode ser criado.");
            }
        }
    }
}
