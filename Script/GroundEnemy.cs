using Godot;
using System;
using System.Linq;

public class GroundEnemy : Actor
{
    public GroundEnemy()
    {
        name = "Ground Enemy";
        health = 30;
        speed = 80;
        gravity = 2000;
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
        GD.Print("(ground enemy ready)");

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

    public void Gravity(float delta)
    {
        velocity.y = velocity.y + gravity * delta;
    }

    public void EnemyMovement(float delta)
    {
        if (isAggro)
            velocity = Position.DirectionTo(playerBody.Position) * speed;
        else
            velocity = moveDirections.ElementAt(option).Value * (speed / 2);

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
        Gravity(delta);
        MoveAndSlide(velocity);
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
        // aBody.health -= 10;
        GD.Print("Collision with ground enemy!");
    }
}
