using System;
using Godot;


// TODO: fullscreen, pause, exit

public class World : Node2D
{
    [Signal]
    public delegate void Pause();

    public string activePlayer = "none";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("(world ready)");

        // Get selectable player types
        Player heavy = GetNode<Player>("Heavy");
        Player sneak = GetNode<Player>("Sneak");
        Player tiny = GetNode<Player>("Tiny");
    }

    // public override void _Process(float delta) {
    //   if (Input.IsActionPressed("pause")) {
    //     GD.Print("pause sent?");
    //     EmitSignal("Pause");
    //   }
    // }

    public override void _Input(InputEvent e)
    {
        if (e.IsActionPressed("pause"))
        {
            GD.Print("pause sent?");
            EmitSignal("Pause");
        }

        // select heavy as player character
        if (e.IsActionPressed("selectHeavy"))
        {
            GD.Print("Heavy has been selected");
            activePlayer = "heavy";
        }

        // select sneak as player character
        if (e.IsActionPressed("selectSneak"))
        {
            GD.Print("Sneak has been selected");
            activePlayer = "sneak";
        }

        // select tiny as player character
        if (e.IsActionPressed("selectTiny"))
        {
            GD.Print("Tiny has been selected");
            activePlayer = "tiny";
        }
    }
}
