using Godot;

public class PowerupPickup : Area2D
{
    [Export] public string whichPowerup;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (PowerPickup.cs)");
    }

    public string GetWhichPowerup()
    {
        return whichPowerup;
    }
}
