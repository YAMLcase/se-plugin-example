# Example Plugin for Space Engineers Dedicated Server

This is a very bare-bones example project for building a plugin for Space Engineers Dedicated Server.  It may also be used for the client as well, but no console is present for testing.  This is not meant to be functional or even a framework for building your own plugin, it is just a "Hello World" example for the bare minimum plugin.

If you are interested in using plugins and want a robust actively developed project, head on over to [TorchAPI](https://github.com/TorchAPI/Torch)

## Usage

### Re-link References

On my build machine, Space Engineers dedicated server is kept in `C:\server\DedicatedServer64\`.  You will either need to 1) Copy your DedicatedServer64 directory to that location, or 2) Remove the `VRage.dll` reference and re-add it linking to your DedicatedServer64 location.

### Build

Press `Build` -> `Build Solution`.  This will create a `PluginExample.dll` file in the `bin\Debug\` directory of your project.  Copy this to your preferred location.  I keep mine in `C:\server\DedicatedServer64\Plugins\`.

### Run the Dedicated Server

Execute the dedicated server and be sure console is active.  Add the `-plugin file.dll` to the command.  Alternatively, run the Dedicated Server GUI if you're testing from scratch. 

```
SpaceEngineersDedicated.exe -console -path c:\data -plugin Plugins/se-plugin-example.dll
```

 You will see this in the console output:

 ```
2018-12-09 11:14:31.544: Session loaded
2018-12-09 11:14:31.580: Plugin Init: se_plugin_example.SEPluginExample
~~~~~~~~~~~~~~~ Hello World ~~~~~~~~~~~~~~~
```

