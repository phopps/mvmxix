using Godot;
// using static Game;

// TODO: Extra air jump, attack strength, special Launch (superjump), wall jumping

public class Tiny : Player
{
    // Tiny default values
    [Export] public float tinyGravity = 1000;
    [Export] public float tinyMoveSpeed = 150;
    [Export] public float tinyJumpSpeed = 450;
    [Export] public float tinyAirMoveSpeed = 200;
    [Export] public float tinyAirJumpSpeed = 400;
    [Export] public int tinyCollisionLayer = 8;
    [Export] public int tinyCollisionMask = 2033;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Tiny.cs)");

        // Update inherited player variables
        gravity = tinyGravity;
        moveSpeed = tinyMoveSpeed;
        jumpSpeed = tinyJumpSpeed;
        jumpsRemaining = 3;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = tinyAirMoveSpeed;
            jumpSpeed = tinyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = tinyMoveSpeed;
            jumpSpeed = tinyJumpSpeed;
        }
    }
}
