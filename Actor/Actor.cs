using Godot;

// TODO: move moveDirections to NPC or global script

public class Actor : KinematicBody2D
{
    public string name;
    [Export] public int health;
    [Export] public float moveSpeed;
    public Vector2 velocity = Vector2.Zero;

    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Actor.cs)");
    }

}
