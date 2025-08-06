using Godot;
using System;

[Tool]
[GlobalClass]
public partial class ElementCardInfo : CardInfo
{
	private Element _element;

	[Export]
	public Element Element
	{
		get => _element;
		set
		{
			_element = value;
			EmitChanged();
		}
	}
}
