using System;
using VRage.Plugins;  // VRage.Plugins is required for IPlugin

namespace se_plugin_example
{
    // IPlugin requires Init(object instance), Update(), and Dispose()
    public class SEPluginExample : IPlugin
    {
        public void Init(object gameInstance)
        {
            // Writes "Hello World" to the server console.
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
