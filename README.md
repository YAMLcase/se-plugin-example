# Example Plugin for Space Engineers Dedicated Server

## Usage

### Re-link References

On my build machine, Space Engineers dedicated server is kept in `C:\server\DedicatedServer64\`.  You will either need to 1) Copy your DedicatedServer64 directory to that location, or 2) Remove the `VRage.dll` reference and re-add it linking to your DedicatedServer64 location.

### Build

Press `Build` -> `Build Solution`.  This will create a `PluginExample.dll` file in the `bin\Debug\` directory of your project.  Copy this to your preferred location.  I keep mine in `C:\server\DedicatedServer64\Plugins\`.

### Run the Dedicated Server

Execute the dedicated server and be sure console is active.  Add the `-plugin file.dll` to the command.  Alternatively, run the Dedicated Server GUI if you're testing from scratch. `SpaceEngineersDedicated.exe -console -path c:\data -plugin Plugins/se-plugin-example.dll`

 You will see this in the console output:

 ```
2018-12-09 11:14:31.544: Session loaded
2018-12-09 11:14:31.580: Plugin Init: se_plugin_example.SEPluginExample
~~~~~~~~~~~~~~~ Hello World ~~~~~~~~~~~~~~~
```