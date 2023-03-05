using Godot;

// TODO: Attack strength, special Thump, allow obstacle pushing/breaking, wall jumping

public class Heavy : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Heavy.cs)");

        // Update inherited player variables
        this.gravity = 4000;
        this.moveSpeed = 100;
        this.jumpSpeed = 300;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!this.IsOnFloor())
        {
            // Air movement
            this.moveSpeed = 50;
            this.jumpSpeed = 300;
        }
        else
        {
            // Floor movement
            this.moveSpeed = 100;
            this.jumpSpeed = 400;
        }
    }
}
