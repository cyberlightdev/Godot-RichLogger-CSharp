#if TOOLS
using Godot;

namespace RichLogger;

[Tool]
public partial class Plugin : LoggerToolbarPlugin
{
    private string PluginPath => GetScript().As<CSharpScript>().ResourcePath.GetBaseDir();
    
    public override void _EnablePlugin()
    {
        AddAutoloadSingleton("RichLogger", $"{PluginPath}/LoggerAutoload.cs");
        base._EnablePlugin();
    }
    
    public override void _DisablePlugin()
    {
        RemoveAutoloadSingleton("Logger");
        base._DisablePlugin();
    }
}
#endif
