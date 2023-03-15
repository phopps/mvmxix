using Godot;
// using static Game;

public class Sneak : Player
{
    // Sneak default values
    [Export] public float sneakGravity = 3000;
    [Export] public float sneakMoveSpeed = 300;
    [Export] public float sneakJumpSpeed = 450;
    [Export] public float sneakAirMoveSpeed = 600;
    [Export] public float sneakAirJumpSpeed = 350;
    [Export] public int sneakCollisionLayer = 2;
    [Export] public int sneakCollisionMask = 2033;
    AnimationPlayer sneakAttack;
    private Area2D hitBox;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak.cs)");

        // Update inherited player variables
        gravity = sneakGravity;
        moveSpeed = sneakMoveSpeed;
        jumpSpeed = sneakJumpSpeed;
        sneakAttack = GetNode<AnimationPlayer>("AnimationPlayer");
        hitBox = GetNode<Area2D>("HitBox");
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("attack"))
            Attack();
    }

    public override void Attack()
    {
        GD.Print("triggered attack?");
        if (!_sprite.FlipH)
        {
            sneakAttack.Play("AttackRight");
        }
        else
        {
            sneakAttack.Play("AttackLeft");
        }
    }

    // public void _Attack(GroundEnemy enemy)
    // {
    //     enemy.health -= 10;
    //     GD.Print(enemy.health);
    // }

    public void NewAttack()
    {

        //if HitBox is active
        // check for overlapping areas
        // if overlapping area is enemy, do damage.
        Godot.Collections.Array targets = hitBox.GetOverlappingBodies();

        foreach (PhysicsBody2D body in targets)
        {
            if (body is Enemy enemy)
            {
                enemy.health -= 10;
            }
            else
            {
                GD.Print("Found other bodies that were not enemies");
                GD.Print(body);
            }
        }

    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = sneakAirMoveSpeed;
            jumpSpeed = sneakAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = sneakMoveSpeed;
            jumpSpeed = sneakJumpSpeed;
        }
    }

    //FIXME: I need an event with which to play sounds 'on landing'. Where does that go? It is currently not obvious. -Max

    // Move Sneak using move and slide with snap
    public override void Move()
    {
        // Sneak uses MoveAndSlideWithSnap(velocity, snap, up) instead of MoveAndSlide(velocity, up)
        // Sneak can jump when snap vector is set to Vector.Zero
        // MoveAndSlideWithSnap automatically uses delta in calculations
        velocity = MoveAndSlideWithSnap(velocity, Vector2.Zero, Vector2.Up);
    }
}
