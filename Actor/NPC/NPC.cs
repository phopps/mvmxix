using Godot;

public class NPC : Actor
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (NPC.cs)");
    }
}
