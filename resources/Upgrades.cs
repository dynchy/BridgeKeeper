using Godot;
using System;

public partial class Upgrades : Node2D

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

	}

	
	public Upgrades UpgradePicker(String choice)
	{
		Upgrades bushes = new Upgrades("Bushes", "Astetic bushes that pretty up the bridge.", 50, 1, 1);
		Upgrades welcomeSign = new Upgrades("Welcome Sign", "A sign that welcomes people to the bridge.", 20, 1, 1);
		Upgrades lights = new Upgrades("Lights", "Lights that light up the bridge at night.", 75, 1, 1);
		Upgrades handrails = new Upgrades("Handrails", "Handrails that make the bridge safer.", 100, 1, 2);
		Upgrades doubleWide = new Upgrades("Double Wide", "Make the bridge double wide to allow more traffic.", 200, 1, 2);
		Upgrades tripleWide = new Upgrades("Triple Wide", "Make the bridge triple wide to allow even more traffic.", 400, 1, 3);
		Upgrades glassFloor = new Upgrades("Glass Floor", "Make the floor of the bridge out of glass to give people a better view.", 500, 1, 3);

		if(choice == "bushes"){
			return bushes;
		}
		/*
		else if (choice == "welcome"){
			return bushes;
		}
		else if (choice == "lights"){
			return lights.modifier;
		}
		else if (choice == "handrails"){
			return handrails.modifier;
		}
		else if (choice == "doubleWide"){
			return doubleWide.modifier;
		}
		else if (choice == "tripleWide"){
			return tripleWide.modifier;
		}
		else if (choice == "glassFloor"){
			return glassFloor.modifier;
		}
		else {return 0;}
*/
		return welcomeSign;

	}	
	
	public int UpgradeBridge(Upgrades upgrade){

		return this.modifier;
		
	}


	
}

