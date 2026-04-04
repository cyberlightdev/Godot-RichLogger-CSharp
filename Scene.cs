using Godot;

namespace RichLogger;

public partial class Scene : Node2D
{
	public override void _Ready()
	{
		Logger.Info("Test");
		GetTree().Quit();
	}
}
