using System;
using System.Linq;
using Godot;

public class GroundEnemy : Actor
{
    public GroundEnemy()
    {
        name = "Ground Enemy";
        health = 30;
        moveSpeed = 80;
        moveDirections.Remove("idle");
    }

    int option = 1;
    bool isAggro = false;
    KinematicBody2D playerBody;
    AnimatedSprite EnemySprite;
    CollisionShape2D EnemyLeft, EnemyRight;
    Timer EnemyDelay;

    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (GroundEnemy.cs)");

        EnemySprite = GetNode<AnimatedSprite>("AnimatedSprite");
        EnemyDelay = GetNode<Timer>("Timer");
        EnemyLeft = GetNode<CollisionShape2D>("LineOfSight/LookLeft");
        EnemyRight = GetNode<CollisionShape2D>("LineOfSight/LookRight");
    }

    public override void _PhysicsProcess(float delta)
    {
        if (!EnemyDelay.IsStopped())
            EnemyMovement(delta);
    }

    public void EnemyMovement(float delta)
    {
        if (isAggro)
            velocity = Position.DirectionTo(playerBody.Position) * delta * moveSpeed;
        else
            velocity = moveDirections.ElementAt(option).Value * delta * (moveSpeed / 2);

        if (velocity.x > 0)
        {
            EnemySprite.FlipH = false;
            EnemyLeft.Disabled = true;
            EnemyRight.Disabled = false;
        }
        else
        {
            EnemySprite.FlipH = true;
            EnemyLeft.Disabled = false;
            EnemyRight.Disabled = true;
        }

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

    public void _OnBodyEntered(KinematicBody2D body)
    {
        isAggro = true;
        playerBody = body;
    }

    public void _OnBodyExited(KinematicBody2D body)
    {
        isAggro = false;
        playerBody = null;
    }

    public void _Damage(Area2D aBody)
    {
        // Handle damage given + taken here
        GD.Print(aBody.Name + " collided with " + this.Name + "!");
    }
}
