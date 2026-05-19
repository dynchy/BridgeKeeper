using Godot;
using System;

public partial class Label : Godot.Label
{	
	

	[Export]
	public int coins;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		Text = $"$: {coins}";
		GD.Print(Text);
		GD.Print(coins);
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void UpdateText()
	{	
		coins += 1;
		Text = $"$: {coins}";
		GD.Print(Text);
		GD.Print(coins);
	
	}
}
