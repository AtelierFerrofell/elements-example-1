using Godot;
using System;

[Tool]
[GlobalClass]
public partial class ElementCard : Card
{
	protected override void OnInfoChanged()
	{
		ColorRect front = GetNode<ColorRect>("Front");
		Label name = front.GetNode<Label>("Name");
		if (Info is ElementCardInfo { Element: { Info: BasicElementInfo info } })
		{
			front.Color = info.Color;
			name.Text = info.Name;
		}
		else
		{
			front.Color = Colors.White;
			name.Text = "";
		}
	}

	public override void Reveal()
	{
		GetNode<ColorRect>("Back").Hide();
	}
}
