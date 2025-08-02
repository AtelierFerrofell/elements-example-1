using Godot;
using System;

[GlobalClass]
public partial class NamedInteraction : ElementInteraction
{
	[Export]
	public string Name { get; set; }
}
