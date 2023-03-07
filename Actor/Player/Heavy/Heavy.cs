using Godot;
using static Game;

// TODO: Attack strength, special Thump, allow obstacle pushing/breaking, wall jumping

public class Heavy : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Heavy.cs)");

        // Update inherited player variables
        gravity = HeavyGravity;
        moveSpeed = HeavyMoveSpeed;
        jumpSpeed = HeavyJumpSpeed;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = HeavyAirMoveSpeed;
            jumpSpeed = HeavyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = HeavyMoveSpeed;
            jumpSpeed = HeavyJumpSpeed;
        }
    }
}
