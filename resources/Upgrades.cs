using Godot;
using System;

public partial class Upgrades : Node2D
{

	public string Name{get;}
	public int Strengthmod{get;}
	public int Attractmod{get;}


	public string Upgrades(string name, int sMod, int aMod){

		this.Name = name;
		this.Strengthmod = sMod;
		this.Attractmod = aMod;


	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Upgrades upgradelist[] = [];

		upgradename[0] = "bushes";
		upgradename[1] = "welcomesign";
		upgradename[2] = "handrails";
		upgradename[3] = "doublewide";
		upgradename[4] = "triplewide";
		upgradename[4] = "glassfloor";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
