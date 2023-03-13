using Godot;
using System;

public class PowerupPickup : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public String whichPowerup;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public String GetWhichPowerup() {
      return whichPowerup;
    }

}
