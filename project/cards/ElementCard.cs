using Godot;
using System;

[Tool]
public partial class ElementCard : Card
{
	protected override void OnInfoChanged()
	{
		ColorRect colorRect = GetNode<ColorRect>("ColorRect");
		Label label = colorRect.GetNode<Label>("Label");
		if (Info is ElementCardInfo { Element: { Info: BasicElementInfo info } })
		{
			colorRect.Color = info.Color;
			label.Text = info.Name;
		}
		else
		{
			colorRect.Color = Colors.White;
			label.Text = "";
		}
	}
}
