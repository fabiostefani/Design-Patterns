using fabiostefani.io.DesignPatterns.Factory2.Interface;
using System;

namespace fabiostefani.io.DesignPatterns.Factory2
{
    public class Truck : ITransport
    {
        public string Build()
        {
            const string msg = "Truck transport";
            Console.WriteLine(msg);
            return msg;
        }
    }
}
