using Godot;
using System.Collections.Generic;

public class NPC : Actor
{
    public Dictionary<string, Vector2> moveDirections = new Dictionary<string, Vector2>()
    {
        {"left", Vector2.Left},
        {"right", Vector2.Right},
        {"idle", Vector2.Zero}
    };
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (NPC.cs)");
    }
}
