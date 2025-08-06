using Godot;
using System;

[Tool]
public partial class ElementCard : Card
{
	protected override void OnInfoChanged()
	{
		if (Info is ElementCardInfo { Element: { Info: BasicElementInfo info } })
		{
			GetNode<ColorRect>("ColorRect").Color = info.Color;
			GetNode<Label>("Label").Text = info.Name;
		}
		else
		{
			GetNode<ColorRect>("ColorRect").Color = Colors.White;
			GetNode<Label>("Label").Text = "";
		}
	}
}
