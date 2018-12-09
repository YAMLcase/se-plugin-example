using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using VRage.Plugins;  // VRage.Plugins is required for IPlugin

namespace se_plugin_example
{
    // IPlugin requires Init(object instance), Update(), and Dispose()
    public class SEPluginExample : IPlugin
    {
        public void Init(object gameInstance)
        {
            // Writes "Hello World" to the server console and logs.
            Console.WriteLine("~~~~~~~~~~~~~~~ Hello World ~~~~~~~~~~~~~~~");
        }

        public void Update()
        {
            
        }

        public void Dispose()
        {

        }
    }
}
