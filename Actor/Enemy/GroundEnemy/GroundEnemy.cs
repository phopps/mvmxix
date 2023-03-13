using System.Collections.Generic;
using System.Linq;
using Godot;

public class GroundEnemy : Enemy
{
    public GroundEnemy()
    {
        name = "Ground Enemy";
        health = 30;
        moveSpeed = 80;
        gravity = 2000;
        isAggro = false;
        isAttacking = false;
        moveDirections = new Dictionary<string, Vector2>()
        {
            { "left", Vector2.Left},
            { "right", Vector2.Right}
        };
    }

    int option = 1;
    public KinematicBody2D playerBody;
    AnimatedSprite EnemySprite;
    CollisionShape2D EnemyLeft, EnemyRight;
    AnimationPlayer EnemyAttack;
    Timer EnemyDelay;

    public override void _Ready()
    {
        GD.Print(Name + " is ready. (GroundEnemy.cs)");

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
            AttackAnimation();
    }

    public void Gravity(float delta)
    {
        velocity.y = velocity.y + gravity * delta;
    }

    public void EnemyMovement(float delta)
    {
        if (isAggro)
            velocity = Position.DirectionTo(playerBody.Position) * moveSpeed;
        else
            velocity = moveDirections.ElementAt(option).Value * (moveSpeed / 2);

        DirectionFacing();
        EnemySprite.Play("walk");
        Gravity(delta);
        MoveAndSlide(velocity);
    }

    public void DirectionFacing()
    {
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
    }

    public void AttackAnimation()
    {
        if (!EnemySprite.FlipH)
            EnemyAttack.Play("AttackRight");
        else
            EnemyAttack.Play("AttackLeft");
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

    // No longer in player hurtbox
    public void _StopDamage(Player body)
    {
        isAttacking = false;
    }
}
