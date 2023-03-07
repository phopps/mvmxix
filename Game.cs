using Godot;

// TODO: Global constants, methods, resources, etc.

// Global autoloaded singleton for game management
public class Game : Node
{
    // Global game manager
    public static Game game;

    // Player characters
    [Export] public PackedScene heavyScene;
    [Export] public PackedScene sneakScene;
    [Export] public PackedScene tinyScene;
    [Export] public Godot.Collections.Array Players;

    // Non-player characters
    [Export] public PackedScene dudeScene;
    [Export] public Godot.Collections.Array NPCs;

    // Items such as gates, keys, obstacles, shrines, and switches
    [Export] public PackedScene bridgeScene;
    [Export] public PackedScene doorScene;
    [Export] public PackedScene keyCardScene;
    [Export] public PackedScene skeletonKeyScene;
    [Export] public PackedScene crateScene;
    [Export] public PackedScene rockScene;
    [Export] public PackedScene shrineScene;
    [Export] public PackedScene buttonScene;
    [Export] public PackedScene leverScene;
    [Export] public Godot.Collections.Array Items;

    // Current and previous player characters
    [Export] public string currentPlayer = "none";
    [Export] public string previousPlayer = "none";

    // Player starting postion
    [Export] public Vector2 startingPlayerPosition = new Vector2(200, 264);

    // Sneak default values
    public const float SneakGravity = 3000;
    public const float SneakMoveSpeed = 300;
    public const float SneakJumpSpeed = 450;
    public const float SneakAirMoveSpeed = 600;
    public const float SneakAirJumpSpeed = 350;
    public const int SneakCollisionLayer = 2;
    public const int SneakCollisionMask = 2033;

    // Heavy default values
    public const float HeavyGravity = 4000;
    public const float HeavyMoveSpeed = 175;
    public const float HeavyJumpSpeed = 400;
    public const float HeavyAirMoveSpeed = 50;
    public const float HeavyAirJumpSpeed = 300;
    public const int HeavyCollisionLayer = 4;
    public const int HeavyCollisionMask = 2033;

    // Tiny default values
    public const float TinyGravity = 1000;
    public const float TinyMoveSpeed = 150;
    public const float TinyJumpSpeed = 450;
    public const float TinyAirMoveSpeed = 200;
    public const float TinyAirJumpSpeed = 400;
    public const int TinyCollisionLayer = 8;
    public const int TinyCollisionMask = 2033;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Game.cs)");
        game = this;
        LoadScenes();
    }

    // Load actor and item packed scenes
    public void LoadScenes()
    {
        // Load actors such as player characters, allies, and enemies
        heavyScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Heavy/Heavy.tscn");
        sneakScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Sneak/Sneak.tscn");
        tinyScene = (PackedScene)ResourceLoader.Load("res://Actor/Player/Tiny/Tiny.tscn");
        dudeScene = (PackedScene)ResourceLoader.Load("res://Actor/NPC/Dude/Dude.tscn");
        // toastGuyScene = (PackedScene)ResourceLoader.Load("res://Actor/NPC/ToastGuy/ToastGuy.tscn");
        // groundEnemyScene = (PackedScene)ResourceLoader.Load("res://Actor/NPC/GroundEnemy/GroundEnemy.tscn");
        // flyingEnemyScene = (PackedScene)ResourceLoader.Load("res://Actor/NPC/FlyingEnemy/FlyingEnemy.tscn");

        // Load items such as gates, keys, obstacles, shrines, and switches
        bridgeScene = (PackedScene)ResourceLoader.Load("res://Item/Gate/Bridge/Bridge.tscn");
        doorScene = (PackedScene)ResourceLoader.Load("res://Item/Gate/Door/Door.tscn");
        // keyCardScene = (PackedScene)ResourceLoader.Load("res://Item/Key/KeyCard/KeyCard.tscn");
        // skeletonKeyScene = (PackedScene)ResourceLoader.Load("res://Item/Key/SkeletonKey/SkeletonKey.tscn");
        // crateScene = (PackedScene)ResourceLoader.Load("res://Item/Obstacle/Crate/Crate.tscn");
        // rockScene = (PackedScene)ResourceLoader.Load("res://Item/Obstacle/Rock/Rock.tscn");
        // buttonScene = (PackedScene)ResourceLoader.Load("res://Item/Switch/Button/Button.tscn");
        // leverScene = (PackedScene)ResourceLoader.Load("res://Item/Switch/Lever/Lever.tscn");
        shrineScene = (PackedScene)ResourceLoader.Load("res://Item/Shrine/Shrine.tscn");
    }

    public void InstanceSneak(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D sneak = (KinematicBody2D)game.sneakScene.Instance();
        sneak.Name = "Sneak";
        sneak.GlobalPosition = position;

        // Remove any existing players
        RemoveExistingPlayers();

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(sneak);

        // Add Sneak to the Players group
        sneak.AddToGroup("Players");
        GD.Print("Sneak has been instanced. (Game.cs)");
    }

    public void InstanceHeavy(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D heavy = (KinematicBody2D)game.heavyScene.Instance();
        heavy.Name = "Heavy";
        heavy.GlobalPosition = position;

        // Remove any existing players
        RemoveExistingPlayers();

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(heavy);

        // Add Heavy to the Players group
        heavy.AddToGroup("Players");
        GD.Print("Heavy has been instanced. (Game.cs)");
    }

    public void InstanceTiny(Vector2 position)
    {
        // Create an instance of the packed scene
        KinematicBody2D tiny = (KinematicBody2D)game.tinyScene.Instance();
        tiny.Name = "Tiny";
        tiny.GlobalPosition = position;

        // Remove any existing players
        RemoveExistingPlayers();

        // Add the instance as a child of the world node
        GetNode("/root/World").AddChild(tiny);

        // Add Tiny to the Players group
        tiny.AddToGroup("Players");
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

        // Add Dude to the NPCs group
        dude.AddToGroup("NPCs");
        GD.Print("Dude has been instanced. (Game.cs)");
    }

    // Remove any existing players
    public void RemoveExistingPlayers()
    {
        // Get an array of existing players
        Players = GetTree().GetNodesInGroup("Players");

        // Loop through existing players and delete their nodes and children nodes
        foreach (KinematicBody2D player in Players) { player.QueueFree(); }
    }
}
