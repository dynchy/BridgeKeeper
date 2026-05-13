using Godot;
using System;

public partial class Npc : CharacterBody2D
{
	private RayCast2D _rayCast;
	public  float Speed = -45.0f;
	private float Gravity = 300f;

	public override void _PhysicsProcess(double delta){

		Vector2 velocity = Velocity;

		if (!IsOnFloor()){
            Gravity = 300f;
		}
		
		_rayCast = GetNode<RayCast2D>("RayCast2D");

		if (_rayCast.IsColliding())
		{
			Speed = 0.0f;
			
		}
		else
		{
			
			Speed = -35.0f;
		}
		//Velocity = new Vector2(Speed, Gravity);
		velocity.X = Speed;
		velocity.Y += Gravity * (float)delta;
		Velocity = velocity;
		MoveAndSlide();
		//MoveAndCollide(Velocity * (float)delta);
	}
	
}
