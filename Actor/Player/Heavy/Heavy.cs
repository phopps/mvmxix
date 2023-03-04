using System;
using Godot;

public class Heavy : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Heavy.cs)");

        // Update inherited player variables
        this.moveSpeed -= 100;
        this.jumpSpeed -= 100;
    }
}
