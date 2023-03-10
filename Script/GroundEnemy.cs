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
    bool isAttacking = false;
    KinematicBody2D playerBody;
    AnimatedSprite EnemySprite;
    CollisionShape2D EnemyLeft, EnemyRight;
    AnimationPlayer EnemyAttack;
    Timer EnemyDelay;

    public override void _Ready()
    {
        GD.Print("(ground enemy ready)");

        EnemySprite = GetNode<AnimatedSprite>("AnimatedSprite");
        EnemyDelay = GetNode<Timer>("Timer");
        EnemyLeft = GetNode<CollisionShape2D>("LineOfSight/LookLeft");
        EnemyRight = GetNode<CollisionShape2D>("LineOfSight/LookRight");
        EnemyAttack = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    public override void _PhysicsProcess(float delta)
    {
        if (!EnemyDelay.IsStopped())
            EnemyMovement(delta);
        if (isAttacking)
            EnemyAttack.Play("Attack");
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

    // Movement Pattern
    public void _OnTimerTimeout()
    {
        if (option >= moveDirections.Count - 1)
            option = 0;
        else
            option += 1;
        EnemyDelay.Start();
    }

    // Enemy vision
    public void _LineOfSightEntered(KinematicBody2D body)
    {
        isAggro = true;
        playerBody = body;
    }

    public void _LineOfSightExited(KinematicBody2D body)
    {
        isAggro = false;
        playerBody = null;
    }

    // Attack collision
    public void _Damage(Player body)
    {
        // Handle damage given + taken here
        // aBody.health -= 10;
        GD.Print("Collision with ground enemy!");
        isAttacking = true;
    }

    public void _StopDamage(Player body)
    {
        isAttacking = false;
    }
}
