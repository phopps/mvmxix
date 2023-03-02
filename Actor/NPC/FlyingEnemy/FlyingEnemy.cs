using System;
using System.Collections.Generic;
using System.Linq;
using Godot;

public class FlyingEnemy : Actor
{
    public FlyingEnemy()
    {
        name = "Flying Enemy";
        health = 10;
        moveDirections.Clear();
        moveDirections = new Dictionary<string, Vector2>()
        {
            // Right
            {"down-right", new Vector2(1, 1)},
            // Down
            {"down-left", new Vector2(-1, 1)},
            // Left
            {"up-left", new Vector2(-1, -1)},
            // Up
            {"up-right", new Vector2(1, -1)}
        };
    }

    int option = 0;
    AnimatedSprite FlyingSprite;
    Timer FlyingDelay;

    public override void _Ready()
    {
        GD.Print(this.Name + " is ready.");

        FlyingSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        FlyingDelay = GetNode<Timer>("Timer");
    }

    public override void _PhysicsProcess(float delta)
    {
        if (!FlyingDelay.IsStopped())
            FlyingMovement();
    }

    public void FlyingMovement()
    {
        velocity = moveDirections.ElementAt(option).Value;
        if (velocity.x > 0)
            FlyingSprite.FlipH = false;
        else
            FlyingSprite.FlipH = true;
        FlyingSprite.Play("walk");
        MoveAndCollide(velocity);
    }

    public void _OnTimerTimeout()
    {
        if (option >= moveDirections.Count - 1)
            option = 0;
        else
            option += 1;
        FlyingDelay.Start();
    }
}
