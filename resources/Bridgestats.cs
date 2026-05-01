using Godot;
using System;

[GlobalClass]
public partial class Bridgestats: Resource
{
	[Export]
	public int Health {get; set;}
	[Export]
	public int Attract {get; set;}
	[Export]
	public int Strength{get; set;}
	[Export]
	public int Price{get; set;}
	[Export]
	public int Flow{get; set;}

	public Bridgestats(){
		this.Health = 50;
		this.Attract = 10;
		this.Strength = 50;
		this.Price = 5;
		this.Flow = 1;
		
	}

	

	

}
