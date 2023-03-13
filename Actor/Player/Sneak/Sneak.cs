using Godot;
// using static Game;

// TODO: Switch to MoveAndSlideWithSnap for movement, wall and ceiling crawling, collision detection raycast, rotate to match surface on collision, attack strength (can be default), special Dash, no need for wall jumping (disable if needed)

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
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak.cs)");

        // Update inherited player variables
        gravity = sneakGravity;
        moveSpeed = sneakMoveSpeed;
        jumpSpeed = sneakJumpSpeed;
        sneakAttack = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("attack"))
            Attack();
    }

    public override void Attack()
    {
        if (!_sprite.FlipH)
            sneakAttack.Play("AttackRight");
        else
            sneakAttack.Play("AttackLeft");
    }

    public void _Attack(GroundEnemy enemy)
    {
        enemy.health -= 10;
        GD.Print(enemy.health);
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
