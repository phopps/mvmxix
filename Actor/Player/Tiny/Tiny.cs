using Godot;
using static Game;

public class Tiny : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Tiny.cs)");

        // Update inherited player variables
        gravity = game.tinyGravity;
        moveSpeed = game.tinyMoveSpeed;
        jumpSpeed = game.tinyJumpSpeed;
        jumpsRemaining = 3;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = game.tinyAirMoveSpeed;
            jumpSpeed = game.tinyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = game.tinyMoveSpeed;
            jumpSpeed = game.tinyJumpSpeed;
        }
    }
}
