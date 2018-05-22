using fabiostefani.io.DesignPatterns.Factory2.Interface;
using System;
using System.Collections.Generic;

namespace fabiostefani.io.DesignPatterns.Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new List<string> {
                typeof(Car).AssemblyQualifiedName,
                typeof(Truck).AssemblyQualifiedName
            };
            var transports = new List<ITransport>();
            types.ForEach(x => transports.Add(TransportFactory.CreateInstance(x)));
            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            Console.ReadKey();
        }
    }
}
