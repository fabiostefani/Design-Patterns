using fabiostefani.io.DesignPatterns.Factory.Enums;
using fabiostefani.io.DesignPatterns.Factory.Interface;

namespace fabiostefani.io.DesignPatterns.Factory
{
    public abstract class VeiculoFactory
    {
        public abstract IVeiculo ObterVeiculo(EnumCategoria categoria);

    }
}
