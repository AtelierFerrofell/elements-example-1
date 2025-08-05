using Godot;
using System;

[Tool]
[GlobalClass]
public partial class ElementCardInfo : CardInfo
{
	[Export]
	public Element Element { get; set; }
}
