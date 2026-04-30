using Godot;
using System;

public partial class Upgrades : Node2D
<<<<<<< HEAD
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
=======
{		
	public string upgradeName{get; set;}
	public string upgradeDescription{get; set;}
	public int upgradeCost{get; set;}
	public int upgradeLevel{get; set;}

	public int modifier{get; set;}

	public Upgrades(string name, string description, int cost, int level, int modifier)
	{
		this.upgradeName = name;
		this.upgradeDescription = description;
		this.upgradeCost = cost;
		this.upgradeLevel = level;
		this.modifier = modifier;
>>>>>>> bb15e87f717949a05a2cc4b8810dc7dc5ae1dd4e
	}

	
	public void UpgradeList()
	{
		Upgrades bushes = new Upgrades("Bushes", "Astetic bushes that pretty up the bridge.", 50, 1, 1);
		Upgrades welcomeSign = new Upgrades("Welcome Sign", "A sign that welcomes people to the bridge.", 20, 1, 1);
		Upgrades lights = new Upgrades("Lights", "Lights that light up the bridge at night.", 75, 1, 1);
		Upgrades handrails = new Upgrades("Handrails", "Handrails that make the bridge safer.", 100, 1, 2);
		Upgrades doubleWide = new Upgrades("Double Wide", "Make the bridge double wide to allow more traffic.", 200, 1, 2);
		Upgrades tripleWide = new Upgrades("Triple Wide", "Make the bridge triple wide to allow even more traffic.", 400, 1, 3);
		Upgrades glassFloor = new Upgrades("Glass Floor", "Make the floor of the bridge out of glass to give people a better view.", 500, 1, 3);
	}	
	


	
}

