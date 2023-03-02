using System;
using Godot;
using static Game;

// TODO: fullscreen, pause, exit

public class World : Node2D
{
    [Signal] public delegate void Pause();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("(world ready)");

        // Currently selected player character
        game.currentPlayer = "sneak";
    }

    public override void _Input(InputEvent e)
    {
        if (e.IsActionPressed("pause"))
        {
            GD.Print("pause sent?");
            EmitSignal("Pause");
        }

        // Select player character Heavy
        if (e.IsActionPressed("selectHeavy"))
        {
            GD.Print("Heavy has been selected.");
            game.currentPlayer = "heavy";
            EmitSignal("PlayerSelected");
        }

        // Select player character Sneak
        if (e.IsActionPressed("selectSneak"))
        {
            GD.Print("Sneak has been selected.");
            game.currentPlayer = "sneak";
            EmitSignal("PlayerSelected");
        }

        // Select player character Tiny
        if (e.IsActionPressed("selectTiny"))
        {
            GD.Print("Tiny has been selected.");
            game.currentPlayer = "tiny";
            EmitSignal("PlayerSelected");
        }
    }
}
