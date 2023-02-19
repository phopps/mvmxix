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
    public override void _Ready()
    {
        NPCSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        NPCDelay = GetNode<Timer>("Timer");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(float delta)
    {
        if (!NPCDelay.IsStopped())
            NPCMovement();
    }

    public void NPCMovement()
    {
        var currentDirection = moveDirections.ElementAt(1);
        velocity = currentDirection.Value;
        // NPCSprite.Play("walk");
        MoveAndCollide(velocity);
    }
}
