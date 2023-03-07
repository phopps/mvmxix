using Godot;
using static Game;

// TODO: Switch to MoveAndSlideWithSnap for movement, wall and ceiling crawling, collision detection raycast, rotate to match surface on collision, attack strength (can be default), special Dash, no need for wall jumping (disable if needed)

public class Sneak : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak.cs)");

        // Update inherited player variables
        gravity = SneakGravity;
        moveSpeed = SneakMoveSpeed;
        jumpSpeed = SneakJumpSpeed;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!IsOnFloor())
        {
            // Air movement
            moveSpeed = SneakAirMoveSpeed;
            jumpSpeed = SneakAirJumpSpeed;
        }
        else
        {
            // Floor movement
            moveSpeed = SneakMoveSpeed;
            jumpSpeed = SneakJumpSpeed;
        }
    }

    // Move Sneak using move and slide with snap
    public override void Move()
    {
        // Sneak uses MoveAndSlideWithSnap(velocity, snap, up) instead of MoveAndSlide(velocity, up)
        // Sneak can jump when snap vector is set to Vector.Zero
        // MoveAndSlideWithSnap automatically uses delta in calculations
        velocity = MoveAndSlideWithSnap(velocity, Vector2.Zero, Vector2.Up);
    }
}
