using fabiostefani.io.DesignPatterns.Factory2.Interface;
using System;

namespace fabiostefani.io.DesignPatterns.Factory2
{
    public class Car : ITransport
    {
        public string Build()
        {
            const string msg = "Car transport";
            Console.WriteLine(msg);
            return msg;
        }
    }
}
