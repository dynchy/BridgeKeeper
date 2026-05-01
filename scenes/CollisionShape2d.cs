using Godot;
using System;

public partial class CollisionShape2d : CollisionShape2D
{
	private Timer _timer;
	private Timer _waitTimer;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()

	{
		_timer = GetNode<Timer>("Timer");
		_waitTimer = GetNode<Timer>("../WaitTimer");
		_waitTimer.WaitTime = 1.0f;
		_waitTimer.OneShot = false;
		_waitTimer.Timeout += _on_wait_timer_timeout;

		Disabled = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_timer_timeout(){
		GD.Print("Collision OFF");
		Disabled = true;
		_waitTimer.Start();
		
		
	}
	private void _on_wait_timer_timeout(){
		
		GD.Print("Collision ON");
		Disabled = false;
		_waitTimer.Stop();

	}
}
