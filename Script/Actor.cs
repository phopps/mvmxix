using Godot;
using System;
using System.Collections.Generic;

public class Actor : KinematicBody2D
{
    public string name;
    public int health;
    public int speed;
    public Vector2 velocity = Vector2.Zero;
    public Dictionary<string, Vector2> moveDirections = new Dictionary<string, Vector2>()
    {
        {"left", Vector2.Left},
        {"right", Vector2.Right},
        {"idle", Vector2.Zero}
    };

    public void Movement(string dir) // may need to be virtual to override later
    {
        // GetNode<AnimationPlayer>("AnimationPlayer").Play(dir);
        GD.Print("Moving" + dir);
    }
}
