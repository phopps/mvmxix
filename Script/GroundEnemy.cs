using Godot;
using System;
using System.Linq;

public class GroundEnemy : Actor
{
    public GroundEnemy()
    {
        name = "Ground Enemy";
        health = 30;
        moveDirections.Remove("idle");
    }

    int option = 0;
    AnimatedSprite EnemySprite;
    Timer EnemyDelay;

    public override void _Ready()
    {
        EnemySprite = GetNode<AnimatedSprite>("AnimatedSprite");
        EnemyDelay = GetNode<Timer>("Timer");
    }
    public override void _PhysicsProcess(float delta)
    {
        if (!EnemyDelay.IsStopped())
            EnemyMovement();
    }

    public void EnemyMovement()
    {
        velocity = moveDirections.ElementAt(option).Value;
        if (velocity.x > 0)
            EnemySprite.FlipH = false;
        else
            EnemySprite.FlipH = true;
        EnemySprite.Play("walk");
        MoveAndCollide(velocity);
    }

    public void _OnTimerTimeout()
    {
        if (option >= moveDirections.Count - 1)
            option = 0;
        else
            option += 1;
        EnemyDelay.Start();
    }
}
