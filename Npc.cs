using Godot;
using System;

public partial class Npc : CharacterBody2D
{
	private RayCast2D _rayCast;
	public  float Speed = -50.0f;

	public override void _PhysicsProcess(double delta){

		_rayCast = GetNode<RayCast2D>("RayCast2D");

		if (_rayCast.IsColliding())
		{
			Speed = 0.0f;
		}
		else
		{
			Speed = -50.0f;
		}
		Velocity = new Vector2(Speed,0);
		MoveAndCollide(Velocity * (float)delta);
	}
	
}
