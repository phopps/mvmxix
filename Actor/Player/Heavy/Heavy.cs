using Godot;
using static Game;

public class Heavy : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Heavy.cs)");

        // Update inherited player variables
        gravity = game.heavyGravity;
        moveSpeed = game.heavyMoveSpeed;
        jumpSpeed = game.heavyJumpSpeed;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = game.heavyAirMoveSpeed;
            jumpSpeed = game.heavyAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = game.heavyMoveSpeed;
            jumpSpeed = game.heavyJumpSpeed;
        }
    }
}
