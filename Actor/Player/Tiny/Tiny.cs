using Godot;
using static Game;

// TODO: Extra air jump, attack strength, special Launch (superjump), wall jumping

public class Tiny : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Tiny.cs)");

        // Update inherited player variables
        gravity = TinyGravity;
        moveSpeed = TinyMoveSpeed;
        jumpSpeed = TinyJumpSpeed;
        jumpsRemaining = 3;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = TinyAirMoveSpeed;
            jumpSpeed = TinyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = TinyMoveSpeed;
            jumpSpeed = TinyJumpSpeed;
        }
    }
}
