using Godot;
// using static Game;

public class Heavy : Player
{
    // Heavy default values
    [Export] public float heavyGravity = 4000;
    [Export] public float heavyMoveSpeed = 175;
    [Export] public float heavyJumpSpeed = 400;
    [Export] public float heavyAirMoveSpeed = 50;
    [Export] public float heavyAirJumpSpeed = 300;
    [Export] public int heavyCollisionLayer = 4;
    [Export] public int heavyCollisionMask = 2033;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Heavy.cs)");

        // Update inherited player variables
        gravity = heavyGravity;
        moveSpeed = heavyMoveSpeed;
        jumpSpeed = heavyJumpSpeed;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = heavyAirMoveSpeed;
            jumpSpeed = heavyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = heavyMoveSpeed;
            jumpSpeed = heavyJumpSpeed;
        }
    }
}
