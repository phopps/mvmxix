using System;
using Godot;

public class Dude : NPC
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Dude.cs)");
    }
}
