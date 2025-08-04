using Godot;
using System;

[GlobalClass]
public partial class ElementCardInfo : CardInfo
{
	[Export]
	public Element Element { get; set; }
}
