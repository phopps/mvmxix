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
        GD.Print(this.Name + " is ready. (World.cs)");

        // Set starting player character to sneak
        game.currentPlayer = "sneak";

        // Creating a player instance of sneak
        game.InstanceSneak(game.startingPlayerPosition);
    }

    public override void _Input(InputEvent e)
    {
        // Pause the game and open the pause menu
        if (e.IsActionPressed("pause"))
        {
            GD.Print("pause sent?");
            EmitSignal("Pause");
        }

        // Select player character Sneak
        if (e.IsActionPressed("selectSneak"))
        {
            GD.Print("Sneak has been selected. (World.cs)");
            // Remove previous character
            // If selected character already exists in the world node
            // Then refill health, update position, etc.
            // Else create an instance of the character
            game.InstanceSneak(game.startingPlayerPosition);
            game.currentPlayer = "sneak";
            EmitSignal("PlayerSelected");
        }

        // Select player character Heavy
        if (e.IsActionPressed("selectHeavy"))
        {
            GD.Print("Heavy has been selected. (World.cs)");
            // Remove previous character
            // If selected character already exists in the world node
            // Then refill health, update position, etc.
            // Else create an instance of the character
            game.InstanceHeavy(game.startingPlayerPosition);
            game.currentPlayer = "heavy";
            EmitSignal("PlayerSelected");
        }

        // Select player character Tiny
        if (e.IsActionPressed("selectTiny"))
        {
            GD.Print("Tiny has been selected. (World.cs)");
            // Remove previous character
            // If selected character already exists in the world node
            // Then refill health, update position, etc.
            // Else create an instance of the character
            game.InstanceTiny(game.startingPlayerPosition);
            game.currentPlayer = "tiny";
            EmitSignal("PlayerSelected");
        }

        // Select player character Dude
        if (e.IsActionPressed("selectDude"))
        {
            GD.Print("Dude has been selected. (World.cs)");
            // Remove previous character
            // If selected character already exists in the world node
            // Then refill health, update position, etc.
            // Else create an instance of the character
            game.InstanceDude(new Vector2(232, 24));
            game.currentPlayer = "dude";
            EmitSignal("PlayerSelected");
        }
    }
}
