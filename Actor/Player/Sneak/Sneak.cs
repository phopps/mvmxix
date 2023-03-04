using System;
using Godot;

public class Sneak : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Sneak.cs)");
    }
}
