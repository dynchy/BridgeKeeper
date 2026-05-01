using Godot;
using System;

public partial class Npc : CharacterBody2D
{
	public const float Speed = -50.0f;

	public override void _PhysicsProcess(double delta){

		Velocity = new Vector2(Speed,0);
		MoveAndCollide(Velocity * (float)delta);
	}
	
}
