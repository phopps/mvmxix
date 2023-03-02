using System;
using Godot;

// Global autoloaded singleton for game management
public class Game : Node
{
    // User has selected current player character
    [Signal] public delegate void PlayerSelected();

    public static Game game;

    // Selectable player characters
    public PackedScene heavy;
    public PackedScene sneak;
    public PackedScene tiny;
    public string currentPlayer = "none";
    public string previousPlayer = "none";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("(game ready)");
        game = this;

        // Load selectable player characters
        heavy = (PackedScene)ResourceLoader.Load("res://Actor/Player/Heavy/Heavy.tscn");
        sneak = (PackedScene)ResourceLoader.Load("res://Actor/Player/Sneak/Sneak.tscn");
        tiny = (PackedScene)ResourceLoader.Load("res://Actor/Player/Tiny/Tiny.tscn");
    }
}
