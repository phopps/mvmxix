using System;
using System.Linq;
using Godot;

public class ToastGuy : NPC
{
    public ToastGuy()
    {
        name = "Toast Guy";
    }

    int randomNum;
    Random Rng = new Random();
    AnimatedSprite NPCSprite;
    Timer NPCDelay;
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (ToastGuy.cs)");

        NPCSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        NPCDelay = GetNode<Timer>("Timer");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(float delta)
    {
        if (!NPCDelay.IsStopped())
            NPCMovement();
    }

    public void NPCMovement()
    {
        velocity = moveDirections.ElementAt(randomNum).Value;
        if (velocity.x > 0)
            NPCSprite.FlipH = false;
        else
            NPCSprite.FlipH = true;
        if (velocity == Vector2.Zero)
            NPCSprite.Stop(); // change this to idle animation later
        NPCSprite.Play("walk");
        MoveAndCollide(velocity);
    }

    public void _OnTimerTimeout()
    {
        randomNum = Rng.Next(0, 3);
        NPCDelay.Start();
    }
}
