using fabiostefani.io.DesignPatterns.Factory2.Interface;
using System;

namespace fabiostefani.io.DesignPatterns.Factory2
{
    public static class TransportFactory
    {
        public static ITransport CreateInstance(string name)
        {
            return Activator.CreateInstance(Type.GetType(name)) as ITransport;
        }
    }
}