using Godot;

public class Bridge : RigidBody2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Bridge.cs)");
    }
}
