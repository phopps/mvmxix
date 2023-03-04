using System;
using Godot;

// Global autoloaded singleton for game management
public class Game : Node
{
    public static Game game;

    // Selectable player characters
    public PackedScene heavy;
    public PackedScene sneak;
    public PackedScene tiny;

    // Currently and previously selected player characters
    public string currentPlayer = "none";
    public string previousPlayer = "none";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Game.cs)");
        game = this;

        // Load selectable player characters
        heavy = (PackedScene)ResourceLoader.Load("res://Actor/Player/Heavy/Heavy.tscn");
        sneak = (PackedScene)ResourceLoader.Load("res://Actor/Player/Sneak/Sneak.tscn");
        tiny = (PackedScene)ResourceLoader.Load("res://Actor/Player/Tiny/Tiny.tscn");
    }
}
