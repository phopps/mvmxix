using Godot;
using static Game;

// TODO: Player character switching

public class World : Node2D
{
    // Signals emitted from this script
    [Signal] public delegate void Pause();
    [Signal] public delegate void PlayerSelected();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready.");

        // Set starting player character to sneak
        game.currentPlayer = "sneak";
    }

    public override void _Input(InputEvent e)
    {
        // Pause the game and open the pause menu
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
