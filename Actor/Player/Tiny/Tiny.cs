using Godot;

public class Tiny : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Tiny.cs)");

        // Update inherited player variables
        this.gravity = 1000;
        this.moveSpeed = 125;
        this.jumpSpeed = 450;
        this.jumpsRemaining = 3;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!this.IsOnFloor())
        {
            // Air movement
            this.moveSpeed = 200;
            this.jumpSpeed = 400;
        }
        else
        {
            // Floor movement
            this.moveSpeed = 125;
            this.jumpSpeed = 450;
        }
    }
}
