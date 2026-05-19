using Godot;
using System;


public partial class PayPoint : CollisionShape2D
{
	// Called when the node enters the scene tree for the first time.

	private Area2D  _area2d;
	
	
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_area_2d_area_entered(){

		GD.Print("Entered");
		
		
	}

	public void _on_area_2d_body_entered(CharacterBody2D body){

		

         var label = GetNode<Label>("scenes/Label.cs");
		 GD.Print(label);
		 label.UpdateText();

		GD.Print("Entered");
	}
}
