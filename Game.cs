using System;
using Godot;

// TODO: Global constants, methods, resources, etc.

// Global autoloaded singleton for game management
public class Game : Node
{
    // Global game manager
    public static Game game;

    // Selectable player characters
    public PackedScene heavyScene;
    public PackedScene sneakScene;
    public PackedScene tinyScene;

    // Non-player characters
    public PackedScene dudeScene;

    // Currently and previously selected player characters
    public string currentPlayer = "none";
    public string previousPlayer = "none";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Game.cs)");
        game = this;

        LoadScenes();
    }

    // Load selectable player characters, NPCs, items
    public void LoadScenes()
    {
        heavyScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Heavy/Heavy.tscn");
        sneakScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Sneak/Sneak.tscn");
        tinyScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Tiny/Tiny.tscn");
        dudeScene = (PackedScene)ResourceLoader.Load("res://Actor/NPC/Dude/Dude.tscn");
    }

    public void InstanceSneak(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D sneak = (KinematicBody2D)game.sneakScene.Instance();
        sneak.Name = "Sneak";
        sneak.GlobalPosition = position;

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(sneak);
        GD.Print("Sneak has been instanced. (Game.cs)");
    }

    public void InstanceHeavy(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D heavy = (KinematicBody2D)game.heavyScene.Instance();
        heavy.Name = "Heavy";
        heavy.GlobalPosition = position;

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(heavy);
        GD.Print("Heavy has been instanced. (Game.cs)");
    }

    public void InstanceTiny(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D tiny = (KinematicBody2D)game.tinyScene.Instance();
        tiny.Name = "Tiny";
        tiny.GlobalPosition = position;

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(tiny);
        GD.Print("Tiny has been instanced. (Game.cs)");
    }

    public void InstanceDude(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D dude = (KinematicBody2D)game.dudeScene.Instance();
        dude.Name = "Dude";
        dude.GlobalPosition = position;

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(dude);
        GD.Print("Dude has been instanced. (Game.cs)");
    }
}
