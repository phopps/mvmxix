using Godot;
using System;
using System.Linq;

public class NPC : Actor
{
    public NPC()
    {
        name = "Toast Guy";
    }

    AnimatedSprite NPCSprite;
    Timer NPCDelay;
    Vector2 velocity = new Vector2();
    public override void _Ready()
    {
        NPCSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        NPCDelay = GetNode<Timer>("Timer");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(float delta)
    {
        if (NPCDelay.IsStopped())
            NPCMovement();
        // MoveAndCollide(Vector2.Down);
    }

    public void NPCMovement()
    {
        // randomly select a movement direction key
        // then move using the Vector2 value
        var currentDirection = moveDirections.ElementAt(1);
        // GD.Print(currentDirection.Value);
        velocity = currentDirection.Value;
        MoveAndCollide(velocity);
        NPCDelay.Start();
    }
}
