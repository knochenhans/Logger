using Godot;
using System;

public partial class Example : Node
{
	public override void _Ready()
	{
		Logger.Log("Hello, World!", Logger.LogTypeEnum.Ready);
	}
}
