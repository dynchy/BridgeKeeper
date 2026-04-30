using Godot;
using System;


public partial class Bridge : Node2D
{
	[Export]
	public Resource Stats;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Bridgestats bridgestats = new Bridgestats();
		Upgrades upgrade = new Upgrades("name","name",  1,1,1);
		GD.Print(upgrade.UpgradePicker("bushes"));
		GD.Print(bridgestats.Health);
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
