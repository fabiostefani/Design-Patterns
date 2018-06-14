using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Adapter.IoC
{
    public class Startup
    {
        public static Container Container;

        public static void Start()
        {
            // Create the _container as usual.
            Container = new Container();

            // Register your types, for instance:
            Container.Register<IBoleto, MeuAdapter>(Lifestyle.Singleton);
            
            // Optionally verify the _container.
            Container.Verify();
        }
    }
}
