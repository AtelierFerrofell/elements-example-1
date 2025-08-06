using Godot;
using System;

[Tool]
public partial class ElementCard : Card
{
	protected override void OnInfoChanged()
	{
		// Clean up with guardrails later
		if (Info is ElementCardInfo elementCardInfo && elementCardInfo.Element.Info is BasicElementInfo basicElementInfo)
		{
			GetNode<ColorRect>("ColorRect").Color = basicElementInfo.Color;
			GetNode<Label>("Label").Text = basicElementInfo.Name;
		}
		else
		{
			GetNode<ColorRect>("ColorRect").Color = Colors.White;
			GetNode<Label>("Label").Text = "";
		}
	}
}
