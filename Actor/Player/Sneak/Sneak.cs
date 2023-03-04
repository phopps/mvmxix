using Godot;

public class Sneak : Player
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Sneak.cs)");

        // Update inherited player variables
        this.gravity = 3000;
        this.moveSpeed = 150;
        this.jumpSpeed = 450;
    }

    public override void AdjustMovementSpeeds()
    {
        if (!this.IsOnFloor())
        {
            // Air movement
            this.moveSpeed = 400;
            this.jumpSpeed = 350;
        }
        else
        {
            // Floor movement
            this.moveSpeed = 150;
            this.jumpSpeed = 450;
        }
    }
}
